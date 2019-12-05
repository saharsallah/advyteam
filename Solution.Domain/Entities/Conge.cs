namespace Solution.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("conge")]
    public partial class conge
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "int")]
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateDebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateFin { get; set; }

        public int? typeConge { get; set; }

        [Column(TypeName = "bit")]
        public bool? valider { get; set; }

        public int? employe_id { get; set; }

        public virtual employee employee { get; set; }
    }
}
