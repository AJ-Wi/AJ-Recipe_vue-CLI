<?php 
date_default_timezone_set ('America/La_Paz');
require('conexion.php');

$CEDULA = isset($_POST["cedula"]) ? $_POST["cedula"] : null;
$PACIENTE = isset($_POST["paciente"]) ? $_POST["paciente"] : null;
$ENFERMEDAD = isset($_POST["enfermedad"]) ? $_POST["enfermedad"] : null;
$MEDICAMENTOS = isset($_POST["medicamentos"]) ? $_POST["medicamentos"] : null;
$INDICACIONES = isset($_POST["indicaciones"]) ? $_POST["indicaciones"] : null;
$TERAPIA = isset($_POST["terapia"]) ? $_POST["terapia"] : null;
$CONSEJO = isset($_POST["consejo"]) ? $_POST["consejo"] : null;
$DIETA = isset($_POST["dieta"]) ? $_POST["dieta"] : null;
$LUGAR = isset($_POST["lugar"]) ? $_POST["lugar"] : null;
$FEMISION = isset($_POST["fechaEm"]) ? $_POST["fechaEm"] : null;
$FEXPIRACION = isset($_POST["fechaEx"]) ? $_POST["fechaEx"] : null;
$FNACIMIENTO = isset($_POST["fechaN"]) ? $_POST["fechaN"] : null;
$FORMATO = isset($_POST["formato"]) ? $_POST["formato"] : null;

if (guardarHistoria($CEDULA, $PACIENTE, $ENFERMEDAD, $MEDICAMENTOS, $INDICACIONES, $TERAPIA, $CONSEJO, $DIETA, $LUGAR, $FEMISION, $FEXPIRACION, $FNACIMIENTO, $FORMATO)) {
	header("Location: ../imprimir.php?id=".contarHistorias());
	//header("Location: ../recipe.php");
}else{
	//header("Location: ../recipe.php");
}

function guardarHistoria($cedula, $paciente, $enfermedad, $medicamentos, $indicaciones, $terapia, $consejo, $dieta, $lugar, $fechaEmision, $fechaExpiracion, $fechaNacimiento, $formato) {
	$BD = new MiBD();
	$id = contarHistorias() + 1;	
    $sql = "INSERT INTO historias ";
	$sql .= "(IDhistoria, cedula, paciente, enfermedad, medicamentos, indicaciones, terapia, consejo, dieta, lugar, fechaEmision, fechaExpiracion, fechaNacimiento, formato, FechaM) VALUES ";
	$sql .= "('".$id."', '".$cedula."', '".$paciente."', '".$enfermedad."', '".$medicamentos."', '".$indicaciones."', '".$terapia."', '".$consejo."', '".$dieta."', '".$lugar."', '";
	$sql .= $fechaEmision."', '".$fechaExpiracion."', '".$fechaNacimiento."', '".$formato."', '".date('y-m-d h:i:s')."')";
	echo $sql;
    if (!$resultado = $BD->exec($sql)){return false;}else{return true;}
}

function contarHistorias(){
	$BD = new MiBD();
    $sql = "SELECT MAX(IDhistoria) FROM historias";
    if (!$resultado = $BD->query($sql)){
	   return 0;
	   exit;
    }else{
		while ($Dato = $resultado->fetchArray()){
			$N = $Dato[0];
		}
        return $N;
    } 
}

?>