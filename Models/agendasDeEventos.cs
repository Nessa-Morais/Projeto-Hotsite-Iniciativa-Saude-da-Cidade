using System.ComponentModel.DataAnnotations;
using System;
namespace Hotsite.Models
{
    public class agendasDeEventos
    {

        public int Id {get; set;}
        public DateTime dataEvento {get; set;}

         [StringLength(1000)]
        public string evento {get; set;}
        
    }
}