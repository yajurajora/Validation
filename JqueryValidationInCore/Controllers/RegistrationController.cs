using JqueryValidationInCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryValidationInCore.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationUser _applicationUser;
        public RegistrationController(ApplicationUser applicationUser)
        {
            _applicationUser = applicationUser;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RegistrationModel registrationModel)
        {
            _applicationUser.Add(registrationModel);
            _applicationUser.SaveChanges();
            ViewBag.message = "The user " + registrationModel.userName + " is saved successfully";
            return View();
        }
    }
}
