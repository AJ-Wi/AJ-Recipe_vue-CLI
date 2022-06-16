<header>	
			<button class="menu" type="submit" onclick="window.location='recipe.php';" ><img src="img/atras.png"></button>
			<div class="menu config dos"><img src="img/<?php echo $NIVEL; ?>.png"><br/><?php if ($NIVEL == 'medico'){echo 'Dr. '.$NOMBRE;}else{echo 'Ing. '.$NOMBRE;} ?></div>
		</header>