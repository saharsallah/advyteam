namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("autotest")]
    public partial class autotest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTest { get; set; }

        public DateTime? DateTest { get; set; }

        [StringLength(255)]
        public string StatusTest { get; set; }

        [StringLength(255)]
        public string TestName { get; set; }

        public int? TypeTest { get; set; }

        public int? score { get; set; }

        public int? attes_idTest { get; set; }

        public int? emp_id { get; set; }

        public int? note_idNote { get; set; }
    }
}
