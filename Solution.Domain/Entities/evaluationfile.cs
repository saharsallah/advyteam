namespace Solution.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.evaluationfile")]
    public partial class evaluationfile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int noteEmploye { get; set; }

        public int noteManager { get; set; }

        [StringLength(255)]
        public string objec { get; set; }

        [StringLength(255)]
        public string result { get; set; }
    }
}
