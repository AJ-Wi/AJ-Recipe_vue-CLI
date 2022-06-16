<?php 
header('Content-Type: text/html; charset=UTF-8');
require('seg/seguridad.php');
require('conexion/conexion.php');

$ID = isset($_GET["id"]) ? $_GET["id"] : null;
$FORMATO = isset($_GET["formato"]) ? $_GET["formato"] : null;
$N = 1;

if (!is_null($ID)){
    $Datos = buscarHistorial($ID);
	$FEXPIRACION = '';
	$FNACIMIENTO = '';
	while ($fila = $Datos->fetchArray()) {
		$CEDULA = $fila[1];
		$PACIENTE = $fila[2];
		$ENFERMEDAD = $fila[3];
		$MEDICAMENTOS = $fila[4];
		$INDICACIONES = $fila[5];
		$TERAPIA = $fila[6];
		$CONSEJO = $fila[7];
		$DIETA = $fila[8];
		$LUGAR = $fila[9];
		$Fem = explode('-', $fila[10]);
		$FEMISION = $Fem[2]."-".$Fem[1]."-".$Fem[0];
		if ($FEXPIRACION) {
			$Fex = explode('-', $fila[11]);
			$FEXPIRACION = $Fex[2]."-".$Fex[1]."-".$Fex[0];
		}
		if ($FNACIMIENTO) {
			$Fna = explode('-', $fila[12]);
			$FNACIMIENTO = $Fna[2]."-".$Fna[1]."-".$Fna[0];
		}	
		if ($fila[13]){
			$FORMATO = $fila[13];
		}		
	}
}

if ($FORMATO == 'normal'){
	$CSS = 'imprimirNormal';
	IF (($TERAPIA) || ($CONSEJO)){
		$N += 1;
	}
	IF ($DIETA){
		$N += 1;
	}
}else{
	$CSS = 'imprimirLegal';
}

function buscarHistorial($id) {
	$BD = new MiBD();
    $sql = "SELECT * FROM historias WHERE IDhistoria='".$id."'";
    if (!$resultado = $BD->query($sql)){
	   return false;
    }	
    return $resultado;    
}

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
		<link rel="stylesheet" href="css/<?php echo $CSS; ?>.css">
	</head>
	<body>
		<?php include('inc/menu4.php') ?>
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
							<h5 class="texto j"><?php echo $MEDICAMENTOS; ?></h5>
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
								<h5 class="texto j"><?php echo $TERAPIA; ?></h5><?php if ($TERAPIA){echo '<br/>';} ?>
								<h5 class="texto"><?php if ($CONSEJO){echo 'Consejo:';} ?></h5>
								<h5 class="texto j"><?php echo $CONSEJO; ?></h5>
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
								<h5 class="texto j"><?php echo $DIETA; ?></h5>
							</div>
						</div>
					</div>
				<?php } ?>
			</div>
		</div>
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
					<div class="contenido a">
						<div class="centro">
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
					<div class="contenido a">
						<div class="centro">
							<h4 class="texto">Indicaciones.</h4>
							<div class="contenido2 conT">
								<h5 class="texto"><?php echo $INDICACIONES; ?></h5>		
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
					
					<h5>CENTRO CLÍNICO PROFECIONAL CARACAS (Anexo Hospital Clinico Caracas)</h5>
					<h5>Av. Panteón. San Bernardino. Piso 3. Cons. 312.</h5>
					<h5>Teléfonos: (0212)574-20-91 - 574-62-35 Central: (0212)574-39-94 Caracas.</h5>
				</div>
			</div>
		</div>
	</body>
</html>