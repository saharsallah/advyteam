namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("note")]
    public partial class note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idNote { get; set; }

        public int? mark { get; set; }

        public int? test_idTest { get; set; }
    }
}
