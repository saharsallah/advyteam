﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Solution.Web.Models
{
    public class ModelAvis
    {
        [Key]
        public int id { get; set; }

        
        public string avis1 { get; set; }

        
        public string avis2 { get; set; }

 
        public string avis3 { get; set; }

       

        public string avis4 { get; set; }

      
        public string avis5 { get; set; }
        [DataType(DataType.Date)]
        public DateTime? dateAvis { get; set; }

        public string rep1 { get; set; }

       
        public string rep10 { get; set; }

        public string rep11 { get; set; }

        
        public string rep12 { get; set; }

        
        public string rep13 { get; set; }

    
        public string rep14 { get; set; }

      
        public string rep15 { get; set; }

       
        public string rep2 { get; set; }

        
        public string rep3 { get; set; }

        
        public string rep4 { get; set; }

       
        public string rep5 { get; set; }


        public string rep6 { get; set; }

      
        public string rep7 { get; set; }

      
        public string rep8 { get; set; }

     
        public string rep9 { get; set; }
        public bool etat { get; set; }
        [Display(Name = "employee")]
        public int idEmplye { get; set; }
    }
}