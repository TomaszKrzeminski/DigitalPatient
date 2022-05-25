using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Digital_Patient.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;


        public StatisticsController(UserManager<IdentityUser> _userManager)
        {
            this._userManager=_userManager;
        }


        public async Task<IActionResult> PatientStatistics()
        {
            IdentityUser user = await _userManager.GetUserAsync(HttpContext.User);

            return View("PatientStatistics",user.Id);
        }

        public IActionResult DoctorStatistics()
        {
            return View();
        }

    }
}
