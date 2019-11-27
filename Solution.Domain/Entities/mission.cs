namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mission")]
    public partial class mission
    {
        [Column("Mission")]
        [Required]
        [StringLength(31)]
        public string Mission1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? duree { get; set; }

        [Column(TypeName = "tinyblob")]
        public byte[] emp { get; set; }

        [Column(TypeName = "bit")]
        public bool? etat { get; set; }

        [StringLength(255)]
        public string libelle { get; set; }
    }
}
