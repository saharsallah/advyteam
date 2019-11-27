namespace Solution.Data
{
    using Solution.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.employee")]
    public partial class employee
    {
        [Required]
        [StringLength(31)]
        public string Type_emp { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string adresse { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datenaissance { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string etatcivil { get; set; }

        [Column(TypeName = "bit")]
        public bool? ferstlogin { get; set; }

        [StringLength(16777215)]
        public string image { get; set; }

        [Column(TypeName = "bit")]
        public bool? isActif { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        [StringLength(255)]
        public string sexe { get; set; }

        public int? contrat_reference { get; set; }
        virtual public ICollection<reclamation> Reclamations { get; set; }

    }
}
