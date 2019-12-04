using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution.Web.Models
{
    public class Quiz
    {
        public int id { get; set; }
        public string question { get; set; }
        public string rep1 { get; set; }
        public string rep2 { get; set; }
        public string rep3 { get; set; }
        public string correctAnswer { get; set; }
        public string quizType { get; set; }
    }
}