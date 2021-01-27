using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        // this is the default action in the home controller
        public IActionResult Index()
        {
            return View();
        }

        // do this get action when they click on grade calculator
        [HttpGet("GradeCalculator")]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        // do this action when they click on the submit button
        [HttpPost("GradeCalculator")]
        public IActionResult GradeCalculator(GradeCalcModel model)
        {
            return View();
        }
    }
}
