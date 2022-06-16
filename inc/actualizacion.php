<?php 
function Actualizacion() {
	$html = new DomDocument();
	$user = 'cvcell';
	$pass = 'Job3142617516';
	$app = 'recipe';
	$ID = '';
	$ultimaVersion = '';
	$nuevaVersion = '';
	$Ruta = 'http://cvcell.com.ve/actualizaciones/actualizaciones.php';

	$Datos = buscarActualizacion();

	while ($fila = $Datos->fetchArray()) {
		$ultimaVersion = new DateTime($fila[1]);	
		if($fila[2] == 'disponible'){
			$ID = $fila[0];
		}
	}

	if (is_file($Ruta)){	
		$html->loadHTMLFile($Ruta.'?usuario='.$user.'&clave='.$pass.'&app='.$app);
		$servidor = $html->getElementsByTagName('div');
	
		foreach ($servidor as $fecha) {
			$nuevaVersion = new DateTime($fecha->nodeValue);
			$archivo = $fecha->getAttribute('class');
			if ($nuevaVersion > $ultimaVersion){			
				$file = 'http://cvcell.com.ve/actualizaciones/recipe/'.$archivo;
				$local_file = 'actualizar.7z';
				$copy = copy($file, $local_file);
				if ($copy) {$ID = guardarActualizacion($nuevaVersion, 'disponible');}
			}
		}
	}
	return $ID;
}

function buscarActualizacion() {
	$BD = new MiBD();
    $sql = "SELECT * FROM actualizacion";
    if (!$resultado = $BD->query($sql)){return false;}   
	return $resultado;
}

function guardarActualizacion($Version, $Estado){
	$BD = new MiBD();
	$ID = contarActualizacion();
	$sql = "INSERT INTO actualizacion (IDactualizacion, fechaActualizacion, estado) VALUE ('".$ID."', '".$Version->format('Y-m-d H:i:s')."', '".$Estado."')";
    if (!$resultado = $BD->query($sql)){return false;}   
	return $ID;
}

function contarActualizacion() {
	$BD = new MiBD();
    $sql = "SELECT MAX(IDactualizacion) FROM actualizacion";
    if (!$resultado = $BD->query($sql)){
	   return 0;
	   exit;
    }else{
		while ($Dato = $resultado->fetchArray()){
			$N = $Dato[0] + 1;
		}
        return $N;
    } 
}
?>