using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Digital_Patient.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult PatientStatistics()
        {
            return View();
        }

        public IActionResult DoctorStatistics()
        {
            return View();
        }

    }
}
