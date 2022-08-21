function validarFormulario(form){
    
    
    var nome = document.getElementById("nome"); // recebe o valor dos imputs atraves dos id
    var msg_nome = document.querySelector(".msg-nome");/* estamos selecionando a tag onde vai estar a classe .msg-nome  */

    msg_nome.style.display="none"; // esconde o conteudo de texto da tag

    if(nome.value == ""){
        
        msg_nome.setAttribute("style","color:red;") // define uma cor para o conteudo da tag que foi selecionada, e armazenada em msg_nome
        msg_nome.innerHTML="Nome: preenchimento obrigatorio"; // define uma um conteudo de texto para a  tag que foi selecionada, e armazenada em msg_nome
        msg_nome.style.display="block"; // faz aparecer o conteudo de text defino na tag
        nome.focus(); // da focu  tag que teve seu conteudo armazenado na variavel nome 
        return false; // não permite que o envio da pagina prossiga

    }else{
        var Email = document.getElementById("Email");
        var msg_email = document.querySelector(".msg-email");
        
        msg_email.style.display="none";
        
        if(Email.value==""){
            msg_email.setAttribute("style","color:red;")
            msg_email.innerHTML="E-mail: preenchimento obrigatorio";
            msg_email.style.display="block";
            Email.focus();
            return false;
    
        }

    }





   

    return true;





}


/* a função abaixo limpa os inputs

$("#formularioInteresse").submit(function(){

     // seu codigo aqui

     $("#nome").val(""); // função de resetar form
     $("#Email").val("");
}); 


*/