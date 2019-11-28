namespace Solution.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.publication")]
    public partial class publication
    {
        public long id { get; set; }

        public DateTime? dateCreation { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "bit")]
        public bool? isActif { get; set; }

        public int? id_emp { get; set; }
    }
}
