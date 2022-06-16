<?php 
$Acceso = isset($_GET["acceso"]) ? $_GET["acceso"] : null;
if ($Acceso == 'error') {$mensaje = 'Usuario o Contraseña invalido';}else{$mensaje = '';}
?>
<!DOCTYPE html>
<html lang="es">
	<head>
		<title>Recipe Medico</title>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1, maximum-scale=1, minimun-scale=1">
		<meta name="author" content="Grupo CVCELL">
		<meta property="og:title" content="Recipe Medico">
        <link rel="shortcut icon" href="img/recipe.ico">
		<link rel="stylesheet" href="css/estilos.css">
		<link rel="stylesheet" href="css/login.css">
	</head>
	<body>
		<form action="seg/login.php" method="post">
			<h1>Iniciar sesión</h1>
			<div class="inset">
				<p>
					<label for="usuario">Usuario</label>
					<input type="text" name="usuario" required>
				</p>
				<p>
					<label for="clave">Contraseña</label>
					<input type="password" name="clave" required>
				</p>
				<p id="mensaje"><?php echo $mensaje; ?></p>
			</div>
			<p class="p-container">
				<input type="submit" value="Acceder">
			</p>
		</form>
	</body>
</html>