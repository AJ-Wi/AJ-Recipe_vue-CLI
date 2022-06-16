<?php
session_start(); 
$Iniciada = isset($_SESSION["autentificado"]) ? $_SESSION["autentificado"] : null;
$USUARIO = isset($_SESSION["usuario"]) ? $_SESSION["usuario"] : null; 
$NOMBRE = isset($_SESSION["nombre"]) ? $_SESSION["nombre"] : null;
$CEDULA = isset($_SESSION["cedula"]) ? $_SESSION["cedula"] : null;
$NIVEL = isset($_SESSION["nivel"]) ? $_SESSION["nivel"] : null;
$ACTUALIZACION = isset($_SESSION["actualizacion"]) ? $_SESSION["actualizacion"] : null;
if ($Iniciada != "SI") { 
    header("Location: /"); //pasa a la pagina  de login
}	
?>