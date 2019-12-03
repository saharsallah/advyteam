namespace Solution.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("questiontest")]
    public partial class questiontest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idQuestion { get; set; }

        [StringLength(255)]
        public string Rep1 { get; set; }

        [StringLength(255)]
        public string Rep2 { get; set; }

        [StringLength(255)]
        public string Rep3 { get; set; }

        [StringLength(255)]
        public string Rep4 { get; set; }

        [StringLength(255)]
        public string ReponseCorrect { get; set; }

        [StringLength(255)]
        public string question1 { get; set; }

        public int? test_idTest { get; set; }
    }
}
