namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.employee")]
    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            projets = new HashSet<projet>();
            timesheets = new HashSet<timesheet>();
        }

        [Required]
        [StringLength(31)]
        public string type_emp { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string adresse { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datenaissance { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public int? etatcivil { get; set; }

        [Column(TypeName = "bit")]
        public bool? isActif { get; set; }

        [Required]
        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [Required]
        [StringLength(255)]
        public string prenom { get; set; }

        [StringLength(255)]
        public string sexe { get; set; }

        public int? contrat_reference { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projet> projets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<timesheet> timesheets { get; set; }
    }
}
