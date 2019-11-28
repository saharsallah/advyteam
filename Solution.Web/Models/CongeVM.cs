using Solution.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution.Web.Models
{
    public class CongeVM
    {

        public int id { get; set; }

        public DateTime? dateDebut { get; set; }

        public DateTime? dateFin { get; set; }

        public int? typeConge { get; set; }

        public bool? valider { get; set; }

        public int? employe_id { get; set; }

        public virtual employee employee { get; set; }
    }
}