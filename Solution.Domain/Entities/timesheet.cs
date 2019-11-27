namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("timesheet")]
    public partial class timesheet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateDebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? deadline { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public long? heureEstime { get; set; }

        public long? heurePasse { get; set; }

        public long? minutePasse { get; set; }

        [StringLength(255)]
        public string timesheetEtat { get; set; }

        public int idDeveloppeur { get; set; }

        public int idProjet { get; set; }

        [StringLength(255)]
        public string titre { get; set; }
    }
}
