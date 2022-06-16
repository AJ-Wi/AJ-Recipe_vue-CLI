<?php 
include('seg/seguridad.php');
require('conexion/conexion.php');

$ID = isset($_GET["id"]) ? $_GET["id"] : null;

$CONSEJO = buscarConsejo($ID);

function buscarConsejo($id) {
	$BD = new MiBD();
    $sql = "SELECT * FROM consejos WHERE IDconsejo='".$id."'";
    if (!$resultado = $BD->query($sql)){
	   return false;
    }
    
	while ($fila = $resultado->fetchArray()) {
		return $fila[1];
	}    
}

?>
<!DOCTYPE html>
<html lang="es">
	<head>
		<?php include('inc/head.php'); ?>
		<link rel="stylesheet" href="css/dieta.css">
	</head>
	<body>
		<?php include('inc/menu2.php'); ?>
		<div class="ventana" >
			<div class="cabecera" >
				<h3>Consejos</h3>
				<button type="submit" onclick="window.location='recipe.php';" >X</button>	
			</div>
			<div class="cuerpo">
				<form method="post" action="conexion/consejo.php">
					<input type="hidden" name="id" value="<?php echo $ID; ?>" >
					<label for="consejo">Descripción:</label>
					<textarea name="consejo" required rows="19" cols="90"><?php echo $CONSEJO; ?></textarea>
					<input class="boton boton2" name="eliminar" type="submit" value="Eliminar">
					<input class="boton" name="guardar" type="submit" value="Guardar">
				</form>
			</div>
		</div>
		<?php include('inc/footer.php'); ?>
	</body>
</html>