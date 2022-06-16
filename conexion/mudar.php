<?php 
date_default_timezone_set ('America/La_Paz');
require('conexion.php');

$Datos = buscarConsejo();

while ($Dato = mysqli_fetch_row($Datos)){
	if ($Dato[0] > 0){
		guardarConsejo($Dato[0], $Dato[1], $Dato[2], $Dato[2]);
	}
}

function guardarConsejo($id, $consejo, $des, $fecha) {
	$BD = new MiBD();
    $sql = "INSERT INTO dietas (IDdieta, dieta, FechaM) VALUES ('".$id."','".$consejo."', '".$fecha."')";
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;}
}

function buscarConsejo() {
    $sql = "SELECT * FROM dietas";
    if (!$resultado = mysqli_query(conexion(), $sql)){return false;}else{return $resultado;} 
}

?>