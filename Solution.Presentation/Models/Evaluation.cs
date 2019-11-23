using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution.Presentation.Models
{
    public class Evaluation
    {
        public string e_type { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        public string etat { get; set; }
        public string nom { get; set; }
        public int type { get; set; }
        public DateTime DateDeb { get; set; }
        public DateTime DateFin { get; set; }
        public string objectif { get; set; }
        
    }
}