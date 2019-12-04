namespace Solution.Data
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("advyteam.formation")]
    public partial class formation
    {
        public int id { get; set; }

        public DateTime? dateDebut { get; set; }

        public DateTime? dateFin { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string refnamepar { get; set; }

        [StringLength(255)]
        public string type { get; set; }
        [JsonIgnore]
        public int? participant_id { get; set; }

        public participant participant { get; set; }
    }
}
