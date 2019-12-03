namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.notefrais")]
    public partial class notefrai
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "bit")]
        public bool? Remboursable { get; set; }

        [StringLength(255)]
        public string libelle { get; set; }

        public double? montant { get; set; }

        public double? tauxderembourssement { get; set; }

        public int? m_id { get; set; }
    }
}
