using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solution.Web.Models
{

    public enum EvaluationTypeVM
    {
        AnnualEvaluation,
        Evaluation360,
        MiTermEvaluation
    }
    public class ModelEvaluation { 


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int id { get; set; }
    [StringLength(255)]
    public string description { get; set; }

    [StringLength(255)]
    public string nom { get; set; }

    public EvaluationTypeVM type { get; set; }

    [DataType(DataType.Date)]
    public DateTime? dateEcheance { get; set; }

    [StringLength(255)]
    public string objectif { get; set; }

    public IEnumerable<SelectListItem> employes { get; set; }
    [Display(Name = "employee")]
    public int? emp_id { get; set; }

    public int? file_id { get; set; }

}
}