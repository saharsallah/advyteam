﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
   public class notefrai
    {
        [Key]
        public int id { get; set; }

       
        public bool Remboursable { get; set; }

       
        public string libelle { get; set; }

        public double montant { get; set; }

        public double tauxderembourssement { get; set; }

        public bool Bonus { get; set; }
       
        public int? MissionId { get; set; }
        [ForeignKey("MissionId")]
        public virtual mission Mission { get; set; }
    }
}

