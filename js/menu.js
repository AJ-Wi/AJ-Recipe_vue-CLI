function mostrarMenu(subMenu, menu){	
	var posicion = document.getElementById(subMenu).style.top;
	document.getElementById('subEnfermedad').style.top = '-100px';
	document.getElementById('subDietas').style.top = '-100px';
	document.getElementById('subTerapias').style.top = '-100px';
	document.getElementById('subConsejos').style.top = '-100px';
	document.getElementById('subHistorial').style.top = '-100px';
	document.getElementById('subConsultas').style.top = '-100px';
	
	if (posicion == '100px'){document.getElementById(subMenu).style.top = '-100px';}else{document.getElementById(subMenu).style.top = '100px';}
	document.getElementById(menu).blur();
	if (menu == 'historial'){document.getElementById('buscar').focus();}
}

function mostrarMenu2(subMenu, menu){	
	var posicion = document.getElementById(subMenu).style.top;
	
	if (posicion == '100px'){document.getElementById(subMenu).style.top = '-100px';}else{document.getElementById(subMenu).style.top = '100px';}
	document.getElementById(menu).blur();
}

function buscarEnLista() {
    var input, filter, ul, li, a, i;
    input = document.getElementById('buscar');
    filter = input.value.toUpperCase();
    ul = document.getElementById("lista");
    li = ul.getElementsByTagName('li');

    for (i = 0; i < li.length; i++) {
        a = li[i];
        if (a.innerHTML.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";
        }
    }
}

function buscarHistorial(e) {
	(e.keyCode)?k=e.keyCode:k=e.which;
 
	if(k == 13){
		var Cedula = document.getElementById('buscar').value;
		window.location='historial.php?cedula=' + Cedula;
	}
}

var win= null;
function abrir(pagina,nombre){
var w = 500;
var h = 650;
if (nombre == 'PopupI'){w = screen.width; h = screen.height;}
var winleft = (screen.width-w)/2;
var wintop = (screen.height-h)/2;
caracteristicas='height='+h+',width='+w+',top='+wintop+',left='+winleft+',scrollbars=no,toolbar=no,resizable=no'
win=window.open(pagina,nombre,caracteristicas)
if(parseInt(navigator.appVersion) >= 4){win.window.focus();}
}

function buscarEnfermedad(a){
	var id1 = 'E' + a;
	var id2 = 'M' + a;
	var V1 = document.getElementById(id1).value;
	var V2 = document.getElementById(id2).value;
	opener.document.getElementById('e').value = V1;
	opener.document.getElementById('m').value = V2;
	window.close()
}

function buscarTerapia(a){
	var id1 = 'T' + a;
	var V1 = document.getElementById(id1).value;
	opener.document.getElementById('t').value = V1;
	window.close()
}

function buscarConsejo(a){
	var id1 = 'C' + a;
	var V1 = document.getElementById(id1).value;
	opener.document.getElementById('c').value = V1;
	window.close()
}

function buscarDieta(a){
	var id1 = 'D' + a;
	var V1 = document.getElementById(id1).value;
	opener.document.getElementById('d').value = V1;
	window.close()
}

function mover(a){
	var b = document.getElementById('actual').innerHTML.split(' / ');
	var c = 1;
	if (a == 'siguiente'){
		if (b[0] <= (parseInt(b[1])-1)){			
			c = (parseInt(b[0]) + 1);
			var id1 = 'Imp' + b[0];
			var id2 = 'Imp' + c;
			document.getElementById('actual').innerHTML = c + ' / ' + b[1];
			document.getElementById(id1).style.display = 'none';
			document.getElementById(id2).style.display = 'block';
		}		
	}
	if (a == 'anterior'){
		if (b[0] >= (parseInt(b[1])-1)){
			if (b[0] != 1){
				c = (parseInt(b[0]) - 1);
				var id1 = 'Imp' + b[0];
				var id2 = 'Imp' + c;			
				document.getElementById('actual').innerHTML = c + ' / ' + b[1];			
				document.getElementById(id2).style.display = 'block';
				document.getElementById(id1).style.display = 'none';	
			}			
		}
	}	
}

function imprimir(){	
	var b = document.getElementById('actual').innerHTML.split(' / ');
	var id1 = 'Imp' + b[0];
	for (i = 1; i <= b[1]; i++){
		var id2 = 'Imp' + i;
		if (i != b[0]){
			document.getElementById(id2).style.display = 'block';
		}
	}
	window.print();
	for (i = 1; i <= b[1]; i++){
		var id2 = 'Imp' + i;
		if (i != b[0]){
			document.getElementById(id2).style.display = 'none';
		}
	}
}