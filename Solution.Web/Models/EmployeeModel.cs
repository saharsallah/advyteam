using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution.Web.Models
{
    public class EmployeeModel
    {
        public int id { get; set; }

        public string Type_emp { get; set; }
        public string adresse { get; set; }
        public DateTime? datenaissance { get; set; }
        public string email { get; set; }
        public string etatcivil { get; set; }
        public bool? isActif { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string sexe { get; set; }
        public int? contrat_reference { get; set; }
        public bool? ferstlogin { get; set; }
        public string image { get; set; }
    }
}