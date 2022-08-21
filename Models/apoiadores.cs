using System;
using System.ComponentModel.DataAnnotations;

namespace Hotsite.Models
{
    public class apoiadores
    {


         public int Id {get; set;}
         
        [StringLength(200)]
        public string nome{get; set;}


       
        public string descricao{get; set;}
    }
}