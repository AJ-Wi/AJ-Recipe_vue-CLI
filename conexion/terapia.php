<?php 
date_default_timezone_set ('America/La_Paz');
require('conexion.php');

$ID = isset($_POST["id"]) ? $_POST["id"] : null;
$TERAPIA = isset($_POST["terapia"]) ? $_POST["terapia"] : null;

if (isset($_REQUEST['guardar'])){
	if (buscarTerapia($ID)){
		if (actualizarTerapia($ID, $TERAPIA)){header("Location: ../recipe.php");}
	}else{	
		if (guardarTerapia($TERAPIA)){header("Location: ../recipe.php");}
	}
}else{
	if (eliminarTerapia($ID)){header("Location: ../recipe.php");}
}

function guardarTerapia($terapia) {
	$BD = new MiBD();
	$id = contarTerapia();
    $sql = "INSERT INTO terapias (IDterapia, terapia, FechaM) VALUES ('".$id."','".$terapia."', '".date('y-m-d h:i:s')."')";
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;}
}

function actualizarTerapia($id, $terapia) {
	$BD = new MiBD();
    $sql = "UPDATE terapias SET terapia='".$terapia."', FechaM='".date('y-m-d h:i:s')."' WHERE IDterapia='".$id."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;}
}

function buscarTerapia($id) {
	$BD = new MiBD();
    $sql = "SELECT * FROM terapias WHERE IDterapia='".$id."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;} 
}

function eliminarTerapia($id) {
	$BD = new MiBD();
    $sql = "DELETE FROM terapias WHERE IDterapia='".$id."'";
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;} 
}

function contarTerapia() {
	$BD = new MiBD();
    $sql = "SELECT MAX(IDterapia) FROM terapias";
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