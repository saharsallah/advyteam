namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("demandemission")]
    public partial class demandemission
    {
        public int id { get; set; }

        [Column(TypeName = "bit")]
        public bool? etat { get; set; }

        public int? employees_id { get; set; }

        public int? missions_id { get; set; }
    }
}
