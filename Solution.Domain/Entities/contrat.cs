namespace Solution.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.contrat")]
    public partial class contrat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contrat()
        {
            employees = new HashSet<employee>();
        }

        [Key]
        public int reference { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datedebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datefin { get; set; }

        public float? salaire { get; set; }

        public int? typeContrat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee> employees { get; set; }
    }
}
