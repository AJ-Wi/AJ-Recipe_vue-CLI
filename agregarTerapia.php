<?php 
include('seg/seguridad.php');
require('conexion/conexion.php');

$Datos = buscarDietas();

function buscarDietas() {
	$BD = new MiBD();
    $sql = "SELECT * FROM terapias";
    if (!$resultado = $BD->query($sql)){return false;}
    return $resultado;    
}
?>
<!DOCTYPE html>
<html lang="es">
	<head>
		<?php include('inc/head.php') ?>
		<link rel="stylesheet" href="css/agregar.css">
	</head>
	<body>
		<?php include('inc/menu5.php') ?>
		<div class="ventana" >
			<div class="cabecera" >
				<h3>Lista de Terapias</h3>
			</div>
			<div class="cuerpo">
				<ul id="lista" class="listar">
					<?php while ($fila = $Datos->fetchArray()) { ?>
					<input id="T<?php echo $fila[0]; ?>" type="hidden" value="<?php echo $fila[1]; ?>">
					<li onclick="buscarTerapia('<?php echo $fila[0]; ?>')"><?php echo substr($fila[1],0,50); ?>...</li>
					<?php } ?>
				</ul>
			</div>
		</div>
	</body>
</html>