using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class GradeCalcModel
    {
        [Range(0,100, ErrorMessage = "Assignments must be a number between 0 and 100")]
        public double assignments { get; set; }
        [Range(0, 100, ErrorMessage ="Group Project must be a number between 0 and 100")]
        public double groupproj { get; set; }
        [Range(0, 100, ErrorMessage = "Quizzes must be a number between 0 and 100")]
        public double quizzes { get; set; }
        [Range(0, 100, ErrorMessage = "Exams must be a number between 0 and 100")]
        public double exams { get; set; }
        [Range(0, 100, ErrorMessage = "Intex must be a number between 0 and 100")]
        public double intex { get; set; }
    }
}
