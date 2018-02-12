using Activity3.Models;
using Activity3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        //[HttpPost]
        //public String Login(UserModel model)
        //{
        //    return @"Here " + model.Username + " and " + model.Password;
        //}

        [HttpPost]
        public ActionResult Login (UserModel model)
        {

            //Validate form POST
            if (!ModelState.IsValid)
                return View("Login");

            //Use the Security Service to authenticate the user
            SecurityService service = new SecurityService();
            if (service.Authenticate(model))
                return View("LoginPassed");
            else
                return View("LoginFailed", model);

        }



    }
}