<?php 
include('seg/seguridad.php');
require('conexion/conexion.php');

$Cedula = isset($_GET["cedula"]) ? $_GET["cedula"] : null;
$Paciente = 'NO encontrado o no Existe';
$enviar= '';
$Datos = buscarHistorial($Cedula);

function buscarHistorial($cedula) {
	$BD = new MiBD();
    $sql = "SELECT IDhistoria, paciente, enfermedad, fechaEmision FROM historias WHERE cedula='".$cedula."'";
    if (!$resultado = $BD->query($sql)){
	   return false;
    }	
    return $resultado;    
}

while ($fila = $Datos->fetchArray()) {
	$Paciente = $fila[1];
}
//mysqli_data_seek($Datos, 0);

if ($Paciente){
	if ($Paciente == 'NO encontrado o no Existe'){
		$enviar= '?c='.$Cedula.'&p=';
	}else{
		$enviar= '?c='.$Cedula.'&p='.$Paciente;
	}
}

?>
<!DOCTYPE html>
<html lang="es">
	<head>
		<?php include('inc/head.php') ?>
		<link rel="stylesheet" href="css/historial.css">
	</head>
	<body>
		<?php include('inc/menu3.php') ?>
		<div class="ventana" >
			<div class="cabecera" >
				<h3>Historias Clinicas</h3>
				<button type="submit" onclick="window.location='recipe.php';" >X</button>	
			</div>
			<div class="cuerpo">
				<h3>Paciente: <?php echo $Paciente; ?></h3>				
				<ul id="lista" class="listar">
					<?php while ($fila = $Datos->fetchArray()) { 
						$F = explode('-', $fila[3]);
						$Fecha = $F[2]."-".$F[1]."-".$F[0];?>					
						<li onclick="window.location='imprimir.php?id=<?php echo $fila[0]; ?>'; return false;"><?php echo $Fecha.' | '.$fila[2]; ?></li>
					<?php } ?>
				</ul>
				<button id="consulta" class="boton" type="submit" onclick="mostrarMenu2('subConsultas', 'consulta');" >Nueva Consulta</button>
			</div>
		</div>
		<?php include('inc/footer.php') ?>
	</body>
</html>