namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.empcomp")]
    public partial class empcomp
    {
        public int id { get; set; }

        public int competenceId { get; set; }

        public int employeeId { get; set; }

        public float score { get; set; }
    }
}
