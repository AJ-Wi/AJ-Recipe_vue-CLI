<?php
	class MiBD extends SQLite3 {
		function __construct(){
			$this->open(__DIR__ . '/recipe.db');
		}
	}
?>