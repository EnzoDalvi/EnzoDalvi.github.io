var btn;
var capital;
var juros;
var saldo;
var tempo;
var cont;
var acumulo;
var borracha;

function init(){
	btn = document.getElementById("btn_calc");
	btn.addEventListener("click", delga);
	btn.addEventListener("click", test );
}
function delga(){
	
	borracha = document.getElementById("pelotempo");
	borracha.innerHTML='';
	
	
}

function test(){

	capital = Number(document.getElementById("CapIni").value);
	juros = Number(document.getElementById("Juros").value);
	tempo = Number(document.getElementById("Time").value);
	if(Number.isNaN(capital) || Number.isNaN(juros) || Number.isNaN(tempo)){
		var rr = document.getElementById("resultado");
		rr.innerHTML = "Valor(es) Inválido(os), favor corrigir!";
		
	}
	else{
		calcula();
	}
}







function calcula(){
	for(cont= 1;cont <= tempo;cont++){
		saldo = capital*Math.pow(1+(juros/100),cont);
		acumulo = document.getElementById("pelotempo");
		var fixed = saldo.toFixed(2);
		acumulo.innerHTML += "Capital durante o "+cont+"°" +"Mês é: "+fixed.+"." + "<br>";
		document.body.appendChild(acumulo);
	}

	saldo = capital*Math.pow(1+(juros/100),tempo);
	var r = document.getElementById("resultado");
	r.innerHTML = "Seu Saldo:" + saldo;

}
init();//Chamar a budega da função 


/*Primeiro Erro, as informações utilizadas na estrutura de repetição estão se sobrepond;
  Segundo Erro, a estruturação do IF e do Else Estava incorreto*/

