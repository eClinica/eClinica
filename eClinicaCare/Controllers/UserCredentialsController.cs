using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eClinicaCare.Controllers
{
    public class UserCredentialsController : Controller
    {
        //
        // GET: /UserCredentials/

        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult SignupDoctorDetails()
        {
            return View();
        }
        

    }
}
