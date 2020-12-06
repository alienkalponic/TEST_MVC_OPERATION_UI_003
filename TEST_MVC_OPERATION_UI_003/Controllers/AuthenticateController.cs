using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Data;

using TEST_MVC_OPERATION_UI_003.App_Start;
using System.IO;
using System.Collections;
//using RestSharp;
using System.Net;
using System.Security.AccessControl;
using System.Text;

namespace TEST_MVC_OPERATION_UI_003.Controllers
{
    public class AuthenticateController : Controller
    {
        // GET: Authenticate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginPage()
        {
            return View();
        }
    }
}