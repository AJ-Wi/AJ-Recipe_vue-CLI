<?php 
date_default_timezone_set ('America/La_Paz');
require('conexion.php');

$ID = isset($_POST["id"]) ? $_POST["id"] : null;
$DIETA = isset($_POST["dieta"]) ? $_POST["dieta"] : null;

if (isset($_REQUEST['guardar'])){
	if (buscarDieta($ID)){
		if (actualizarDieta($ID, $DIETA)){header("Location: ../recipe.php");}
	}else{	
		if (guardarDieta($DIETA)){header("Location: ../recipe.php");}
	}
}else{
	if (eliminarDieta($ID)){header("Location: ../recipe.php");}
}

function guardarDieta($dieta) {
	$BD = new MiBD();
	$id = contarDieta();
    $sql = "INSERT INTO dietas (IDdieta, dieta, FechaM) VALUES ('".$id."','".$dieta."', '".date('y-m-d h:i:s')."')";
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;}
}

function actualizarDieta($id, $dieta) {
	$BD = new MiBD();
    $sql = "UPDATE dietas SET dieta='".$dieta."', FechaM='".date('y-m-d h:i:s')."' WHERE IDdieta='".$id."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;}
}

function buscarDieta($id) {
	$BD = new MiBD();
    $sql = "SELECT * FROM dietas WHERE IDdieta='".$id."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;} 
}

function eliminarDieta($id) {
	$BD = new MiBD();
    $sql = "DELETE FROM dietas WHERE IDdieta='".$id."'";
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;} 
}

function contarDieta() {
	$BD = new MiBD();
    $sql = "SELECT MAX(IDdieta) FROM dietas";
    if (!$resultado = $BD->query($sql)){
	   return 0;
	   exit;
    }else{
		while ($Dato = $resultado->fetchArray()){
			$N = $Dato[0] + 1;
		}
        return $N;
    } 
}

?>