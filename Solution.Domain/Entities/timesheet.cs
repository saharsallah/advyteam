namespace Solution.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("timesheet")]
    public partial class timesheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public timesheet()
        {
            commentaires = new HashSet<commentaire>();
            taches = new HashSet<tache>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateDebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? deadline { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public long? heureEstime { get; set; }

        public long? heurePasse { get; set; }

        public long? minutePasse { get; set; }

        [StringLength(255)]
        public string timesheetEtat { get; set; }

        public int idDeveloppeur { get; set; }

        public int idProjet { get; set; }

        [StringLength(255)]
        public string titre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire> commentaires { get; set; }

        public virtual employee employee { get; set; }

        public virtual projet projet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tache> taches { get; set; }
    }
}
