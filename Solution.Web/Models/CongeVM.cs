using Solution.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Solution.Web.Models
{
    public class CongeVM
    {
        [Key]
        public int id { get; set; }

        public DateTime? dateDebut { get; set; }

        public DateTime? dateFin { get; set; }

        public int? typeConge { get; set; }

        public bool? valider { get; set; }

        public int? employe_id { get; set; }

    }
}