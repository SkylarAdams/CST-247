using Activity4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity4.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        [HttpGet]
        public ActionResult Index()
        {
            //initialize list of users to display
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel("Mark Reha", "Mark@gmail.com", "911-234-2355"));
            users.Add(new UserModel("Skylar Adams", "Skylar@gmail.com", "912-124-7424"));
            users.Add(new UserModel("Trevor Moore", "Trevor@gmail.com", "913-233-5352"));
            users.Add(new UserModel("Jabril", "bearssuck@gmail.com", "914-346-4335"));

            //display users
            return View("Test", users);
        }
    }
}