namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public enum Etatcivil
    {
        Mari�e, c�libataire, Divorc�e

    }
    [Table("advyteam.employee")]
    public partial class employee
    {
        [Required]
        [StringLength(31)]
        public string Type_emp { get; set; }

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string adresse { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datenaissance { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public Etatcivil etatcivil { get; set; }

        [Column(TypeName = "bit")]
        public bool? isActif { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

      
        public int cin { get; set; }

        [StringLength(255)]
        public string sexe { get; set; }

        public int? contrat_reference { get; set; }
    }
}
