using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Patient.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Digital_Patient.Controllers
{
    [Authorize(Roles = "Doctor")]
    public class DoctorController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public DoctorController( UserManager<IdentityUser> userManager)
        {            
            _userManager = userManager;
        }

        [Authorize]
        public async Task<ActionResult> TaskPanelAsync()
        {
          var cookie1=   HttpContext.Request.Cookies[".AspNetCore.Identity.Application"];

            IdentityUser user = await _userManager.GetUserAsync(HttpContext.User);
            return View(new DoctorTaskPanelViewModel(user.Id,cookie1));
        }

    }
}
