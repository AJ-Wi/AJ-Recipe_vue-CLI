<?php

require('../conexion/conexion.php');
require('../inc/actualizacion.php');

$usuario = isset($_POST["usuario"]) ? $_POST["usuario"] : null;
$clave = isset($_POST["clave"]) ? $_POST["clave"] : null;

if ($usuario){
    if (identificarUsuario($usuario, $clave)){
        header("Location: ../recipe.php"); //pasa a la pagina protegida
    }else{
        header("Location: ../?acceso=error");  // pasa a la pagina de login dando error		
    }
}

function buscarporUsuario($Usuario) {
	$BD = new MiBD();
    $sql = "SELECT * FROM usuarios WHERE usuario='".$Usuario."'";
    if (!$resultado = $BD->query($sql)){
	   return false;
    }    
    return $resultado;
}

function identificarUsuario($Usuario, $Clave) {
	$resultado = buscarporUsuario($Usuario);
	if (!$resultado){return false;}
	while ($fila = $resultado->fetchArray()) {		
		if ($Clave == $fila[1]){
			session_start(); 
            $_SESSION["autentificado"]= "SI";
			$_SESSION["usuario"]= $fila[0];
            $_SESSION["nombre"]= $fila[2];
            $_SESSION["cedula"]= $fila[3];
			$_SESSION["nivel"]= $fila[4];
			//$_SESSION["actualizacion"]= Actualizacion();
            return true;
		}
	}
}

?>