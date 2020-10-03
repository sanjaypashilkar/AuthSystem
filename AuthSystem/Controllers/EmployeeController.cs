using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthSystem.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.Name = TempData["Name"] as string;
            ViewBag.Address = TempData["Address"] as string;
            TempData.Keep();
            return View();
        }
    }
}