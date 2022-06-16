<?php 
require('conexion.php');

$ENUNCIADO = isset($_POST['enunciado'])? $_POST['enunciado'] : null;
$TELEFONO1 = isset($_POST['telefono1'])? $_POST['telefono1'] : null;
$TELEFONO2 = isset($_POST['telefono2'])? $_POST['telefono2'] : null;
$TELEFONO3 = isset($_POST['telefono3'])? $_POST['telefono3'] : null;
$TELEFONO4 = isset($_POST['telefono4'])? $_POST['telefono4'] : null;
$WEB = isset($_POST['web'])? $_POST['web'] : null;
$CLINICA1 = isset($_POST['clinica1'])? $_POST['clinica1'] : null;
$CLINICA2 = isset($_POST['clinica2'])? $_POST['clinica2'] : null;
$DIRECCION1 = isset($_POST['direccion1'])? $_POST['direccion1'] : null;
$DIRECCION2 = isset($_POST['direccion2'])? $_POST['direccion2'] : null;
$HORARIO1 = isset($_POST['horario1'])? $_POST['horario1'] : null;
$HORARIO2 = isset($_POST['horario2'])? $_POST['horario2'] : null;
$nombre_archivo = isset($_FILES['logo']['name'])? $_FILES['logo']['name'] : null; 
$tipo_archivo = isset($_FILES['logo']['type'])? $_FILES['logo']['type'] : null; 
$tamano_archivo = isset($_FILES['logo']['size'])? $_FILES['logo']['size'] : null; 
$rutaIMG = isset($_POST['logoAct'])? $_POST['logoAct'] : null;

if ($nombre_archivo){
	$rutaIMG = 'img/'.$nombre_archivo;
	move_uploaded_file($_FILES['logo']['tmp_name'], '../'.$rutaIMG);
}
 
if (guardarConfig($ENUNCIADO, $TELEFONO1, $TELEFONO2, $TELEFONO3, $TELEFONO4, $WEB, $CLINICA1, $CLINICA2, $DIRECCION1, $DIRECCION2, $HORARIO1, $HORARIO2, $rutaIMG)){	
	header("Location: ../recipe.php");
}else{
	header("Location: ../config.php?error=1");
} 

function guardarConfig($enunciado, $telefono1, $telefono2, $telefono3, $telefono4, $web, $clinica1, $clinica2, $direccion1, $direccion2, $horario1, $horario2, $img) {
	$BD = new MiBD();
    $sql = "UPDATE configuracion SET enunciado='".$enunciado."', telefono1='".$telefono1."', telefono2='".$telefono2."', telefono3='".$telefono3."', telefono4='".$telefono4;
	$sql .= "', web='".$web."', clinica1='".$clinica1."', clinica2='".$clinica2."', direccion1='".$direccion1."', direccion2='".$direccion2."', horario1='".$horario1;
	$sql .= "', horario2='".$horario2."', img='".$img."'";
    if (!$resultado = $BD->query($sql)){return false;}else{return true;}
}

?>