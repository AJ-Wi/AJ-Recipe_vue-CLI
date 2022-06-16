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
		header("Location: imprimir.php?id=".contarHistorias());		
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
		<link rel="stylesheet" href="css/imprimirNormal.css">
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
							<label for="paciente">Paciente:</label>
							<input type="text" name="paciente" required value="<?php echo $Paciente; ?>">
						</div>
						<div>
							<label for="cedula">Cedula:</label>
							<input id="cedula" type="text" name="cedula" required value="<?php echo $Cedula; ?>">
						</div>
						<div>
							<label for="fechaEm">Fecha de Emisión:</label>
							<input type="date" name="fechaEm" required value="<?php echo date("Y-m-d");?>">
						</div>
					</div>
					<label for="enfermedad">Enfermedad:</label>
					<input id="e" type="text" name="enfermedad" required>
					<img class="agregar" src="img/agregar.png" onclick="abrir('agregarEnfermedad.php','PopupE');return false;">	
					<label for="medicamentos">Medicamentos e Indicaciones:</label>
					<textarea id="m" name="medicamentos" required rows="19" cols="90"></textarea>
					<div class="F2">
						<div>
							<label for="terapia">Terapia:<img class="agregar1" src="img/agregar.png" onclick="abrir('agregarTerapia.php','PopupT');return false;"></label>							
							<textarea id="t" name="terapia" rows="19" cols="90"></textarea>
						</div>
						<div>
							<label for="consejo">Consejos o Tips:<img class="agregar1" src="img/agregar.png" onclick="abrir('agregarConsejo.php','PopupC');return false;"></label>							
							<textarea id="c" name="consejo" rows="19" cols="90"></textarea>
						</div>
					</div>	
					<label for="dieta">Dieta:<img class="agregar1" src="img/agregar.png" onclick="abrir('agregarDieta.php','PopupD');return false;"></label>					
					<textarea id="d" name="dieta" rows="19" cols="90"></textarea>
					<input type="hidden" name="formato" value="normal">
					<input class="boton" type="submit" value="Guardar">
				</form>
			</div>
		</div>
		<?php include('inc/footer.php') ?>
		<div id="normal" class="ventana Vimp" >
			<div class="cabecera" >
				<h3>Imprimir</h3>	
			</div>
			<div class="cuerpo Cimp">
				<div id="Imp1" class="Imprimir">
					<img src="img/logo.png">
					<h3>Dr. Augusto J. Gonzalez C</h3>
					<h5 class="enun"><?php echo $ENUNCIADO; ?></h5>
					<h4 class="web"><?php echo $WEB; ?></h4>
					<h4 class="texto">Medicamentos e Indicaciones:</h4>
					<div class="contenido">
						<div class="contenido2">
							<h5 class="texto"><?php echo $MEDICAMENTOS; ?></h5>
						</div>
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
								<h4 class="texto">Fecha: </h4>
								<h4 class="texto largo"><?php echo $FEMISION; ?></h4>
							</div>
						</div>
					</div>
					<div class="lineal2">
						<div class="horarios">
							<h6><?php echo $CLINICA1; ?></h6>
							<h6><?php echo $DIRECCION1; ?></h6>
							<h6><?php echo $TELEFONO1; ?></h6>
							<h6><?php echo $TELEFONO3; ?></h6><br/>
							<h6><?php echo $HORARIO1; ?></h6>
						</div>
						<div class="horarios">
							<h6><?php echo $CLINICA2; ?></h6>
							<h6><?php echo $DIRECCION2; ?></h6>
							<h6><?php echo $TELEFONO2; ?></h6>
							<h6><?php echo $TELEFONO4; ?></h6><br/>
							<h6><?php echo $HORARIO2; ?></h6>
						</div>
					</div>
				</div>
				<?php if (($TERAPIA) || ($CONSEJO)){ ?>
					<div class="salto"></div>
					<div id="Imp2" class="Imprimir">
						<h4 class="texto">Terapias y Consejos:</h4>
						<div class="contenido">
							<div class="contenido2 conT">
								<h5 class="texto"><?php if ($TERAPIA){echo 'Terapia:';} ?></h5>
								<h5 class="texto"><?php echo $TERAPIA; ?></h5><?php if ($TERAPIA){echo '<br/>';} ?>
								<h5 class="texto"><?php if ($CONSEJO){echo 'Consejo:';} ?></h5>
								<h5 class="texto"><?php echo $CONSEJO; ?></h5>
							</div>
						</div>
					</div>
				<?php } ?>
				<?php if ($DIETA){ ?>
					<div class="salto"></div>				
					<div id="Imp3" class="Imprimir">
						<h4 class="texto">Dietas:</h4>
						<div class="contenido">
							<div class="contenido2 conT">
								<h5 class="texto"><?php echo $DIETA; ?></h5>
							</div>
						</div>
					</div>
				<?php } ?>
			</div>
		</div>
	</body>
</html>