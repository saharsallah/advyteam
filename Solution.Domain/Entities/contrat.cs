namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("contrat")]
    public partial class contrat
    {
        [Key]
        public int reference { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datedebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datefin { get; set; }

        public float? salaire { get; set; }

        [StringLength(255)]
        public string typeContrat { get; set; }
    }
}
