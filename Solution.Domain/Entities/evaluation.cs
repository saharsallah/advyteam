namespace Solution.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public enum EvaluationType {
        AnnualEvaluation,
        Evaluation360,
        MiTermEvaluation
    }

    [Table("evaluation")]
    public partial class evaluation
    {
        
        [Required]
        [StringLength(31)]
        public string e_type { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "bit")]
        public bool? etat { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        public EvaluationType type { get; set; }

        public DateTime? dateEcheance { get; set; }

        [StringLength(255)]
        public string objectif { get; set; }

        public DateTime? rendezVous { get; set; }

        public DateTime? dateDeb { get; set; }

        public DateTime? dateFin { get; set; }

        public int? emp_id { get; set; }

        public int? file_id { get; set; }
    }
}
