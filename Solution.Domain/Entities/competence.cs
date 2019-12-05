namespace Solution.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("competence")]
    public partial class competence
    {
        public int id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string nom { get; set; }
    }
}
