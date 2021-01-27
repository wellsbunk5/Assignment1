using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class GradeCalcModel
    {
        [Required]
        public int assignments { get; set; }
        public int groupproj { get; set; }
        public int quizzes { get; set; }
        public int exams { get; set; }
        public int intex { get; set; }
    }
}
