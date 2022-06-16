<?php 
require('conexion.php');

$usuario = isset($_POST["usuario"]) ? $_POST["usuario"] : null;
$clave = isset($_POST["clave"]) ? $_POST["clave"] : null;
$cedula = isset($_POST["cedula"]) ? $_POST["cedula"] : null;

if (guardarUsuario($usuario, $clave, $cedula)){header("Location: ../recipe.php");}

function guardarUsuario($Usuario, $Clave, $Cedula) {
	$BD = new MiBD();
    $sql = "UPDATE usuarios SET usuario='".$Usuario."', clave='".$Clave."' WHERE cedula='".$Cedula."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;}
}

?>