<?php 
date_default_timezone_set ('America/La_Paz');
require('conexion.php');

$ID = isset($_POST["id"]) ? $_POST["id"] : null;
$CONSEJO = isset($_POST["consejo"]) ? $_POST["consejo"] : null;

if (isset($_REQUEST['guardar'])){
	if (buscarConsejo($ID)){
		if (actualizarConsejo($ID, $CONSEJO)){header("Location: ../recipe.php");}
	}else{	
		if (guardarConsejo($CONSEJO)){header("Location: ../recipe.php");}
	}
}else{
	if (eliminarConsejo($ID)){header("Location: ../recipe.php");}
}

function guardarConsejo($consejo) {
	$BD = new MiBD();
	$id = contarConsejo();
    $sql = "INSERT INTO consejos (IDconsejo, consejo, FechaM) VALUES ('".$id."','".$consejo."', '".date('y-m-d h:i:s')."')";
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;}
}

function actualizarConsejo($id, $consejo) {
	$BD = new MiBD();
    $sql = "UPDATE consejos SET consejo='".$consejo."', FechaM='".date('y-m-d h:i:s')."' WHERE IDconsejo='".$id."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;}
}

function buscarConsejo($id) {
	$BD = new MiBD();
    $sql = "SELECT * FROM consejos WHERE IDconsejo='".$id."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;} 
}

function eliminarConsejo($id) {
	$BD = new MiBD();
    $sql = "DELETE FROM consejos WHERE IDconsejo='".$id."'";
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;} 
}

function contarConsejo() {
	$BD = new MiBD();
    $sql = "SELECT MAX(IDconsejo) FROM consejos";
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