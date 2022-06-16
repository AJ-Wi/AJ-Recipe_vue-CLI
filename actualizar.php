<?php 
require('seg/seguridad.php');
require('conexion/conexion.php');
$ID = isset($_GET["id"]) ? $_GET["id"] : null;

exec('actualizar.exe');
if (actualizarActualizacion($ID)){header("Location: ../recipe.php");}

function actualizarActualizacion($ID){
	$BD = new MiBD();
	$sql = "UPDATE actualizacion SET estado='instalado' WHERE IDactualizacion='".$ID."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;} 
}
?>