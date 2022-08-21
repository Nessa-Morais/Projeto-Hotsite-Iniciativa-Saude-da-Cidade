using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;

namespace Hotsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           return View();
        }

        public IActionResult agenda(){
                DatabaseService ds = new DatabaseService();
                
            return View(ds.listarEvento().ToList());
        }

        public IActionResult cadastrarEvento(){
            return View();
        }
        
        [HttpPost]
        public IActionResult cadastrarEvento( agendasDeEventos e){
           DatabaseService ds = new DatabaseService();
           ds.cadastrarEventos(e);
            

            return View();
        }

        public IActionResult dicas(){

            return View(new DatabaseService().dica());
        }

        public IActionResult apoiadores(){

            return View();
        }



        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {

         try{            
                        DatabaseService dbs = new DatabaseService();
                    Interesse interesseId = new Interesse();

           
           
                    if(cad.Nome == null)
                    {
                            ViewBag.msgErro = "o campo nome não foi preenchido";
                                        
                    } 
                    else
                    {
                            if(cad.Email == null)
                        {
                            ViewBag.msgErro = "o campo E-mail não foi preenchido";
                        
                        }
                        else
                        {
                    
                   
                                interesseId.Id = dbs.CadastraInteresse(cad);

                                
                                if(interesseId.Id > 0)
                               {
                                   ViewBag.msgExito = "cadastro realizado com sucesso";
                               }
                        }       
                    }
                }
                catch
                {
                           
                       ViewBag.msgErroDeCadastro = "falha no cadastro! tente mais tarde";
                }
                     return View("Index",cad);
            
           
        }





        

       
    }

}   

