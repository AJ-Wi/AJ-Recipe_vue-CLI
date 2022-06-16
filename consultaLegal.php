<?php 
date_default_timezone_set ('America/La_Paz');
include('seg/seguridad.php');
require('conexion/conexion.php');

$Cedula = isset($_GET["c"]) ? $_GET["c"] : null;
$Paciente = isset($_GET["p"]) ? $_GET["p"] : null;
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
$IMPRIMIR = '';

if ($CEDULA){
	if (guardarHistoria($CEDULA, $PACIENTE, $ENFERMEDAD, $MEDICAMENTOS, $INDICACIONES, $TERAPIA, $CONSEJO, $DIETA, $LUGAR, $FEMISION, $FEXPIRACION, $FNACIMIENTO, $FORMATO)) {
		$Fem = explode('-', $FEMISION);
		$FEMISION = $Fem[2]."-".$Fem[1]."-".$Fem[0];
		if ($FEXPIRACION) {
			$Fex = explode('-', $FEXPIRACION);
			$FEXPIRACION = $Fex[2]."-".$Fex[1]."-".$Fex[0];
		}
		if ($FNACIMIENTO) {
			$Fna = explode('-', $FNACIMIENTO);
			$FNACIMIENTO = $Fna[2]."-".$Fna[1]."-".$Fna[0];
		}
		header("Location: imprimir.php?id=".$IMPRIMIR);
	}
}

function guardarHistoria($cedula, $paciente, $enfermedad, $medicamentos, $indicaciones, $terapia, $consejo, $dieta, $lugar, $fechaEmision, $fechaExpiracion, $fechaNacimiento, $formato) {
	$BD = new MiBD();
	$id = contarHistorias() + 1;	
    $sql = "INSERT INTO historias ";
	$sql .= "(IDhistoria, cedula, paciente, enfermedad, medicamentos, indicaciones, terapia, consejo, dieta, lugar, fechaEmision, fechaExpiracion, fechaNacimiento, formato, FechaM) VALUES ";
	$sql .= "('".$id."', '".$cedula."', '".$paciente."', '".$enfermedad."', '".$medicamentos."', '".$indicaciones."', '".$terapia."', '".$consejo."', '".$dieta."', '".$lugar."', '";
	$sql .= $fechaEmision."', '".$fechaExpiracion."', '".$fechaNacimiento."', '".$formato."', '".date('y-m-d h:i:s')."')";
    if (!$resultado = $BD->exec($sql)){return false;}else{$IMPRIMIR = $id; return true;}
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
<!DOCTYPE html>
<html lang="es">
	<head>
		<?php include('inc/head.php') ?>
		<link rel="stylesheet" href="css/consulta.css">
		<link rel="stylesheet" href="css/imprimirLegal.css">
	</head>
	<body>
		<?php include('inc/menu2.php') ?>
		<div id="principal" class="ventana" >
			<div class="cabecera" >
				<h3>Consulta</h3>
				<button type="submit" onclick="window.location='recipe.php';" >X</button>	
			</div>
			<div class="cuerpo">
				<form method="post" action="">
					<div class="F1">
						<div>
							<label for="fechaEm">Fecha de Emisión:</label>
							<input type="date" name="fechaEm" required value="<?php echo date("Y-m-d");?>">
						</div>
						<div>
							<label for="lugar">Lugar de Emisión:</label>
							<select name="lugar" >
								<option value=""></option>
								<option value="Caracas">Caracas</option>
								<option value="Guarenas">Guarenas</option>
							</select>
						</div>
						<div>
							<label for="fechaEx">Fecha de Expiración:</label>
							<input type="date" name="fechaEx" required>
						</div>
					</div>
					<div class="F1">
						<div>
							<label for="paciente">Paciente:</label>
							<input type="text" name="paciente" required value="<?php echo $Paciente; ?>">
						</div>
						<div>
							<label for="cedula">Cedula:</label>
							<input id="cedula" type="text" name="cedula" required value="<?php echo $Cedula; ?>">
						</div>
						<div>
							<label for="fechaN">Fecha de Nacimiento:</label>
							<input type="date" name="fechaN" required>
						</div>
					</div>
					<input type="hidden" name="id" value="<?php echo $ID; ?>" >
					<label for="enfermedad">Enfermedad:</label>					
					<input id="e" type="text" name="enfermedad" required>
					<img class="agregar" src="img/agregar.png" onclick="abrir('agregarEnfermedad.php','PopupE');return false;">
					<label for="medicamentos">Recipe:</label>
					<textarea id="m" class="areaLegal" name="medicamentos" required rows="19" cols="90"></textarea>
					<label for="indicaciones">Indicaciones:</label>
					<textarea class="areaLegal" name="indicaciones" required rows="19" cols="90"></textarea>
					<input type="hidden" name="formato" value="legal">
					<input class="boton" type="submit" value="Guardar">
				</form>
			</div>
		</div>
		<?php include('inc/footer.php') ?>
		<div id="legal" class="ventana Vimp" >
			<div class="cabecera" >
				<h3>Imprimir</h3>	
			</div>
			<div class="cuerpo Cimp">
				<div id="Imp1" class="Imprimir">
					<img src="img/logo.png">
					<h3>Dr. Augusto J. Gonzalez C</h3>
					<h5 class="a">Cédula: 4.142.121&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Registro M.P.P.S: 41691</h5>
					<h5>Rif: V-04142121-1</h5>
					<h5 class="a">MÉDICO CIRUJANO - MEDICINA INTERNA</h5>
					<h5 class="a">CENTRO CLÍNICO PROFECIONAL CARACAS (Anexo Hospital Clinico Caracas)</h5>
					<h5>Av. Panteón. San Bernardino. Piso 3. Cons. 312.</h5>
					<h5>Teléfonos: (0212)574-20-91 - 574-62-35 Central: (0212)574-39-94 Caracas.</h5>					
					<div class="contenido a b">
						<h4 class="texto">Rp.</h4>
						<div class="contenido2">
							<h5 class="texto"><?php echo $MEDICAMENTOS; ?></h5>
						</div>
						<div class="lineal2 c">
							<div class="lineal d">
								<h4 class="texto">Lugar: </h4>
								<h4 class="texto largo"><?php echo $LUGAR; ?></h4>
							</div>
							<div>
								<div class="lineal">
									<h4 class="texto">Fecha de Emisión: </h4>
									<h4 class="texto largo"><?php echo $FEMISION; ?></h4>
								</div>
								<div class="lineal">
									<h4 class="texto">Fecha de Expiración: </h4>
									<h4 class="texto largo"><?php echo $FEXPIRACION; ?></h4>
								</div>
							</div>
						</div>						
						<div class="paciente">
							<h4 class="texto">Datos del Paciente:</h4>
							<div class="lineal">
								<h4 class="texto">Paciente: </h4>
								<h4 class="texto largo"><?php echo $PACIENTE; ?></h4>
							</div>
							<div class="lineal2">
								<div class="lineal">
									<h4 class="texto">Cedula: </h4>
									<h4 class="texto largo"><?php echo $CEDULA; ?></h4>
								</div>
								<div class="lineal">
									<h4 class="texto">Fecha de Nacimiento: </h4>
									<h4 class="texto largo"><?php echo $FNACIMIENTO; ?></h4>
								</div>
							</div>
						</div>
					</div>
				</div>
				<div id="Imp2" class="Imprimir">
					<div class="lineal2 c">
						<div class="lineal">
							<h4 class="texto">Lugar: </h4>
							<h4 class="texto largo"><?php echo $LUGAR; ?></h4>
						</div>
						<div class="lineal">
							<h4 class="texto">Fecha de Emisión: </h4>
							<h4 class="texto largo"><?php echo $FEMISION; ?></h4>
						</div>
					</div>						
					<div class="contenido a b">
						<h4 class="texto">Indicaciones.</h4>
						<div class="contenido2 conT">
							<h5 class="texto"><?php echo $INDICACIONES; ?></h5>		
						</div>
						<div class="paciente">
							<h4 class="texto">Datos del Paciente:</h4>
							<div class="lineal">
								<h4 class="texto">Paciente: </h4>
								<h4 class="texto largo"><?php echo $PACIENTE; ?></h4>
							</div>
							<div class="lineal2">
								<div class="lineal">
									<h4 class="texto">Cedula: </h4>
									<h4 class="texto largo"><?php echo $CEDULA; ?></h4>
								</div>
								<div class="lineal">
									<h4 class="texto">Fecha de Nacimiento: </h4>
									<h4 class="texto largo"><?php echo $FNACIMIENTO; ?></h4>
								</div>
							</div>
						</div>
					</div>
					<h5>CENTRO CLÍNICO PROFECIONAL CARACAS (Anexo Hospital Clinico Caracas)</h5>
					<h5>Av. Panteón. San Bernardino. Piso 3. Cons. 312.</h5>
					<h5>Teléfonos: (0212)574-20-91 - 574-62-35 Central: (0212)574-39-94 Caracas.</h5>
				</div>
			</div>
		</div>
	</body>
</html>