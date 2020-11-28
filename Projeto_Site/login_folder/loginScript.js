function logar(){
    
    var username= document.getElementById("Login").value
    var senha = document.getElementById("Senha").value
    var sub = document.getElementById("error")

    if(username == 'user' && senha == '123')
    {
        sub.style.visibility= "visible"
    }
   else //if(username == userc && senha == senhac){
        window.alert("Você está logado")  
        window.location.replace("https://enzodalvi.github.io/Projeto_Site/home_folder/pag_home.html");
   // }
}   
