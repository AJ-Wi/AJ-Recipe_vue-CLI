<header>
			<button class="menu" type="submit" onclick="window.location='recipe.php';" ><img src="img/atras.png"></button>
			<button id="imp" class="menu" type="submit" onclick="imprimir();" ><img src="img/imprimir.png"></button>
			<button class="menu" type="submit" onclick="mover('anterior');" ><img src="img/anterior.png"></button>
			<div id="actual" class="items">1 / <?php echo $N; ?></div>
			<button class="menu" type="submit" onclick="mover('siguiente');" ><img src="img/siguiente.png"></button>
			<div class="menu config dos"><img src="img/<?php echo $NIVEL; ?>.png"><br/><?php if ($NIVEL == 'medico'){echo 'Dr. '.$NOMBRE;}else{echo 'Ing. '.$NOMBRE;} ?></div>
		</header>