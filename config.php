<?php 
require('seg/seguridad.php');
require('conexion/conexion.php');

$config = buscarConfig();

while ($fila = $config->fetchArray()) {
	$ENUNCIADO = $fila[1];
	$TELEFONO1 = $fila[2];
	$TELEFONO2 = $fila[3];
	$TELEFONO3 = $fila[4];
	$TELEFONO4 = $fila[5];
	$WEB = $fila[6];
	$CLINICA1 = $fila[7];
	$CLINICA2 = $fila[8];
	$DIRECCION1 = $fila[9];
	$DIRECCION2 = $fila[10];
	$HORARIO1 = $fila[11];
	$HORARIO2 = $fila[12];
	$IMG = $fila[13];
}

function buscarConfig() {
	$BD = new MiBD();
    $sql = "SELECT * FROM configuracion WHERE IDconfig='1'";
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
		<link rel="stylesheet" href="css/config.css">
	</head>
	<body>
		<?php include('inc/menu2.php') ?>
		<div class="ventana" >
			<div class="cabecera" >
				<h3>Configuración</h3>
				<button type="submit" onclick="window.location='recipe.php';" >X</button>	
			</div>
			<div class="cuerpo">
				<form method="post" action="conexion/config.php" enctype="multipart/form-data">	
					<div class="contenido">
						<label for="clinica1">Clinica 1:</label>
						<input type="text" name="clinica1" value="<?php echo $CLINICA1; ?>" >
						<label for="direccion1">Dirección 1:</label>
						<textarea class="dire" name="direccion1"><?php echo $DIRECCION1; ?></textarea>
						<label for="horario1">Horario 1:</label>
						<textarea class="dire" name="horario1"><?php echo $HORARIO1; ?></textarea>
						<label for="telefono1">Telefono 1:</label>
						<input type="text" name="telefono1" value="<?php echo $TELEFONO1; ?>" >
						<label for="telefono3">Telefono 3:</label>
						<input type="text" name="telefono3" value="<?php echo $TELEFONO3; ?>" >
						<label for="web">web:</label>
						<input type="text" name="web" value="<?php echo $WEB; ?>" >
						<label for="enunciado">Enunciado:</label>
						<textarea class="dire" name="enunciado" required><?php echo $ENUNCIADO; ?></textarea>
					</div>
					<div class="contenido">
						<label for="clinica2">Clinica 2:</label>
						<input type="text" name="clinica2" value="<?php echo $CLINICA2; ?>" >
						<label for="direccion2">Dirección 2:</label>
						<textarea class="dire" name="direccion2"><?php echo $DIRECCION2; ?></textarea>
						<label for="horario2">Horario 2:</label>
						<textarea class="dire" name="horario2"><?php echo $HORARIO2; ?></textarea>
						<label for="telefono2">Telefono 2:</label>
						<input type="text" name="telefono2" value="<?php echo $TELEFONO2; ?>" >
						<label for="telefono4">Telefono 4:</label>
						<input type="text" name="telefono4" value="<?php echo $TELEFONO4; ?>" >
						<div id="logo"><img class="logoIMG" src="<?php echo $IMG; ?>"></div>
						<input type="hidden" name="logoAct" value="<?php echo $IMG; ?>" >
						<input id="cargarL" type="file" name="logo">
					</div>					
					<input class="boton" type="submit" value="Guardar">
				</form>
				<?php if ($NIVEL == 'soporte'){ ?>
				<button class="boton boton3" type="submit" onclick="window.location='administrarUsuarios.php';" >Administrar Usuarios</button>
				<?php } ?>
			</div>
		</div>
		<?php include('inc/footer.php') ?>
		<script src="js/imagen.js"></script>
	</body>
</html>