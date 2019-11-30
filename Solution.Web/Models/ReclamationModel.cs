using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution.Web.Models
{
    public class ReclamationModel
    {
        public int Id { get; set; }
        public string Objet { get; set; }
        public string Description { get; set; }
        public DateTime DateReclamation { get; set; }
        public DateTime DateTraitement { get; set; }
        public bool Etat { get; set; }
        
    }
}