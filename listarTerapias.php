<?php 
include('seg/seguridad.php');
require('conexion/conexion.php');

$Datos = buscarDietas();

function buscarDietas() {
	$BD = new MiBD();
    $sql = "SELECT * FROM terapias";
    if (!$resultado = $BD->query($sql)){
	   return false;
    }
    return $resultado;    
}

?>
<!DOCTYPE html>
<html lang="es">
	<head>
		<?php include('inc/head.php') ?>
		<link rel="stylesheet" href="css/listar.css">
	</head>
	<body>
		<?php include('inc/menu3.php') ?>
		<div class="ventana" >
			<div class="cabecera" >
				<h3>Lista de Terapias</h3>
				<button type="submit" onclick="window.location='recipe.php';" >X</button>	
			</div>
			<div class="cuerpo">
				<ul id="lista" class="listar">
					<?php while ($fila = $Datos->fetchArray()) { ?>
					<li onclick="window.location='terapia.php?id=<?php echo $fila[0]; ?>'"><?php echo substr($fila[1],0,67); ?>...</li>
					<?php } ?>
				</ul>
			</div>
		</div>
		<?php include('inc/footer.php') ?>
	</body>
</html>