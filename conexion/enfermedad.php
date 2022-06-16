<?php 
date_default_timezone_set ('America/La_Paz');
require('conexion.php');

$ID = isset($_POST["id"]) ? $_POST["id"] : null;
$ENFERMEDAD = isset($_POST["enfermedad"]) ? $_POST["enfermedad"] : null;
$DESCRIPCION = isset($_POST["descripcion"]) ? $_POST["descripcion"] : null;

if (isset($_REQUEST['guardar'])){
	if (buscarEnfermedad($ID)){
		if (actualizarEnfermedad($ID, $ENFERMEDAD, $DESCRIPCION)){header("Location: ../recipe.php");}
	}else{	
		if (guardarEnfermedad($ENFERMEDAD, $DESCRIPCION)){header("Location: ../recipe.php");}
	}
}else{
	if (eliminarEnfermedad($ID)){header("Location: ../recipe.php");}
}

function guardarEnfermedad($enfermedad, $descripcion) {
	$BD = new MiBD();
	$id = contarenfermedad();
    $sql = "INSERT INTO enfermedades (IDenfermedad, enfermedad, descripcion, FechaM) VALUES ('".$id."','".$enfermedad."', '".$descripcion."', '".date('y-m-d h:i:s')."')";
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;}
}

function actualizarEnfermedad($id, $enfermedad, $descripcion) {
	$BD = new MiBD();
    $sql = "UPDATE enfermedades SET enfermedad='".$enfermedad."', descripcion='".$descripcion."', FechaM='".date('y-m-d h:i:s')."' WHERE IDenfermedad='".$id."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;}
}

function buscarEnfermedad($id) {
	$BD = new MiBD();
    $sql = "SELECT * FROM enfermedades WHERE IDenfermedad='".$id."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;} 
}

function eliminarEnfermedad($id) {
	$BD = new MiBD();
    $sql = "DELETE FROM enfermedades WHERE IDenfermedad='".$id."'";
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;} 
}

function contarEnfermedad() {
	$BD = new MiBD();
    $sql = "SELECT MAX(IDenfermedad) FROM enfermedades";
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