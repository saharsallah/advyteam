namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.commentaire")]
    public partial class commentaire
    {
        [Required]
        [StringLength(31)]
        public string type_com { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string comment { get; set; }

        public int? projet_id { get; set; }

        public int? evaluation_id { get; set; }

        public int? timesheet_id { get; set; }
    }
}
