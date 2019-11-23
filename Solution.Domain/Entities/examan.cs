namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.examen")]
    public partial class examan
    {
        public int id { get; set; }

        [StringLength(255)]
        public string catExam { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(255)]
        public string formation { get; set; }

        public int idFor { get; set; }

        public int idPar { get; set; }

        [StringLength(255)]
        public string nomExamen { get; set; }

        public int? note { get; set; }

        [StringLength(255)]
        public string participant { get; set; }

        [StringLength(255)]
        public string typeExam { get; set; }
    }
}
