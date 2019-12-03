namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("attestationtest")]
    public partial class attestationtest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTest { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        public int? auto_idTest { get; set; }

        public int? emp_id { get; set; }
    }
}
