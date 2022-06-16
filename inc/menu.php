<header>	
			<button id="enfermedad" class="menu" type="submit" onclick="mostrarMenu('subEnfermedad', 'enfermedad');" ><img src="img/enfermedades.png">Enfermedades</button>
			<button id="dieta" class="menu" type="submit" onclick="mostrarMenu('subDietas', 'dieta');" ><img src="img/dietas.png">Dietas</button>
			<button id="terapia" class="menu" type="submit" onclick="mostrarMenu('subTerapias', 'terapia');" ><img src="img/terapias.png">Terapias</button>
			<button id="consejo" class="menu" type="submit" onclick="mostrarMenu('subConsejos', 'consejo');" ><img src="img/consejos.png">Consejos</button>	
			<button id="consulta" class="menu" type="submit" onclick="mostrarMenu('subConsultas', 'consulta');" ><img src="img/paciente.png">Consultas</button>	
			<button id="historial" class="menu" type="submit" onclick="mostrarMenu('subHistorial', 'historial');" ><img src="img/historial.png">Historial</button>							
			<button class="menu config" type="submit" onclick="window.location='usuario.php';" ><img src="img/<?php echo $NIVEL; ?>.png"><br/><?php if ($NIVEL == 'medico'){echo 'Dr. '.$NOMBRE;}else{echo 'Ing. '.$NOMBRE;} ?></button>
			<button class="menu config C2" type="submit" onclick="window.location='config.php';" ><img src="img/config.png">Configuración</button>
			<?php if ($ACTUALIZACION){ ?>
			<button class="menu config C3" type="submit" onclick="window.location='actualizar.php?id=<?php echo $ACTUALIZACION; ?>';" ><img id="des" src="img/actualizar.png"><br/>Actualizar</button>
			<?php } ?>
			<div id="subEnfermedad" class="subMenu">
				<button class="itemSubMenu" type="submit" onclick="window.location='enfermedad.php';" >Nueva Enfermedad</button>
				<button class="itemSubMenu" type="submit" onclick="window.location='listarEnfermedades.php';" >Listar Enfermedades</button>
			</div>
			<div id="subDietas" class="subMenu">
				<button class="itemSubMenu" type="submit" onclick="window.location='dieta.php';" >Nueva Dieta</button>
				<button class="itemSubMenu" type="submit" onclick="window.location='listarDietas.php';" >Listar Dietas</button>
			</div>
			<div id="subTerapias" class="subMenu">
				<button class="itemSubMenu" type="submit" onclick="window.location='terapia.php';" >Nueva Terapia</button>
				<button class="itemSubMenu" type="submit" onclick="window.location='listarTerapias.php';" >Listar Terapias</button>
			</div>
			<div id="subConsejos" class="subMenu">
				<button class="itemSubMenu" type="submit" onclick="window.location='consejo.php';" >Nuevo Consejo</button>
				<button class="itemSubMenu" type="submit" onclick="window.location='listarConsejos.php';" >Listar Consejos</button>
			</div>
			<div id="subHistorial" class="subMenu">
				<div id="busqueda" class="itemSubMenu"><div id="B1" class="buscador"><input id="buscar" type="text" onkeyup="buscarHistorial(event)" placeholder="Buscar.." ></div></div>
			</div>
			<div id="subConsultas" class="subMenu">
				<button class="itemSubMenu" type="submit" onclick="window.location='consultaNormal.php';" >Consulta en Formato NORMAL</button>
				<button class="itemSubMenu" type="submit" onclick="window.location='consultaLegal.php';" >Consulta en Formato LEGAL</button>
			</div>
		</header>