namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.participant")]
    public partial class participant
    {
        public int id { get; set; }

        [StringLength(255)]
        public string Refname { get; set; }

        [StringLength(255)]
        public string adresse { get; set; }

        public int cin { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public int idEmp { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string sexe { get; set; }

        [StringLength(255)]
        public string type { get; set; }
    }
}
