namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.typeformation")]
    public partial class typeformation
    {
        public int id { get; set; }

        [StringLength(255)]
        public string type { get; set; }
    }
}
