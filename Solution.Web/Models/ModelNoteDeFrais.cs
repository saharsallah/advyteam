using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solution.Web.Models
{
    public class ModelNoteDeFrais
    {
        public int id { get; set; }


        public bool Remboursable { get; set; }


        public string libelle { get; set; }

        public double montant { get; set; }

        public double tauxderembourssement { get; set; }


        public int? MissionId { get; set; }
        [Display(Name="MissionId")]
        public IEnumerable<SelectListItem> Missions { get; set; }

    }
}