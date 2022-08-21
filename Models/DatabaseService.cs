using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Hotsite.Models
{
    public class DatabaseService
    {
        public int CadastraInteresse(Interesse cad)
        {
            using(var context = new DatabaseContext())
            {
                context.Add(cad);
                context.SaveChanges();
                return cad.Id;
            }


            
        }

        public List<dicas> dica(){

            using(DatabaseContext context = new DatabaseContext()){
                             
               
                     return (context.dica.ToList());            
            }
        
        }
        public void  cadastrarEventos( agendasDeEventos novoEvento){

            using( DatabaseContext dc = new DatabaseContext()){
                dc.agendas.Add(novoEvento);
                dc.SaveChanges();
            }
        }

        public List<agendasDeEventos> listarEvento (){
            using(DatabaseContext dc = new DatabaseContext()){
                
                           
                return dc.agendas.ToList();
            }

           }
    




    }
}