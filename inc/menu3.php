<header>	
			<button class="menu" type="submit" onclick="window.location='recipe.php';" ><img src="img/atras.png"></button>
			<div class="buscador"><input id="buscar" type="text" onkeyup="buscarEnLista()" placeholder="Buscar.." ></div>
			<div class="menu config dos"><img src="img/<?php echo $NIVEL; ?>.png"><br/><?php if ($NIVEL == 'medico'){echo 'Dr. '.$NOMBRE;}else{echo 'Ing. '.$NOMBRE;} ?></div>
			<div id="subConsultas" class="subMenu">
				<button class="itemSubMenu" type="submit" onclick="window.location='consultaNormal.php<?php echo $enviar; ?>';" >Consulta en Formato NORMAL</button>
				<button class="itemSubMenu" type="submit" onclick="window.location='consultaLegal.php<?php echo $enviar; ?>';" >Consulta en Formato LEGAL</button>
			</div>
		</header>