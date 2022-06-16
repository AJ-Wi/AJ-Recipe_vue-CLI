<?php 
require('seg/seguridad.php');
require('conexion/conexion.php');

$user = '';
$clave = '';

$Datos = buscarporCedula($CEDULA);
while ($fila = $Datos->fetchArray()) {
	$user = $fila[0];
	$clave = $fila[1];
}

function buscarporCedula($Cedula) {
	$BD = new MiBD();
    $sql = "SELECT * FROM usuarios WHERE cedula='".$Cedula."'";
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
		<link rel="stylesheet" href="css/usuario.css">
	</head>
	<body>
		<?php include('inc/menu2.php') ?>
		<div class="ventana" >
			<div class="cabecera" >
				<h3>Usuario</h3>
				<button type="submit" onclick="window.location='recipe.php';" >X</button>	
			</div>
			<div class="cuerpo">
				<img src="img/<?php echo $NIVEL; ?>.png">
				<h2><?php if ($NIVEL == 'medico'){echo 'Dr. '.$NOMBRE;}else{echo 'Ing. '.$NOMBRE;} ?></h2>
				<form method="post" action="conexion/usuario.php">					
					<label for="usuario">Usuario</label>
					<input type="text" name="usuario" required value="<?php echo $user; ?>" >
					<label for="clave">Clave</label>
					<input id="pas" type="password" name="clave" required value="<?php echo $clave; ?>" >
					<img id="ojo" src="img/ojo.png" onclick="mostrar();">					
					<input type="hidden" name="cedula" required value="<?php echo $CEDULA; ?>" >
					<input class="boton" type="submit" value="Guardar">
				</form>
			</div>
		</div>
		<?php include('inc/footer.php') ?>
		<script>
			function mostrar() {
				var tipo = document.getElementById('pas').type;
				if (tipo == 'password'){document.getElementById('pas').type = 'text';}
				if (tipo == 'text'){document.getElementById('pas').type = 'password';}
			}
		</script>
	</body>
</html>