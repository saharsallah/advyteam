using Solution.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
    public class reclamation
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Objet { get; set; }
        public string Description { get; set; }
        public DateTime DateReclamation { get; set; }
        public DateTime? DateTraitement { get; set; }
        public bool Etat { get; set; }
        public int? EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual employee employee  { get; set; }
    }
}
