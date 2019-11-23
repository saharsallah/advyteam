namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.objectifs")]
    public partial class objectif
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string obj1 { get; set; }

        [StringLength(255)]
        public string obj2 { get; set; }

        [StringLength(255)]
        public string obj3 { get; set; }

        public int? filee_id { get; set; }
    }
}
