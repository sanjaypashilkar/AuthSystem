
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AuthSystem.Business;
using AuthSystem.ViewModels;

namespace AuthSystem.Controllers
{
    public class HomeController : Controller
    {
        EmployeeBL employeeBusiness = new EmployeeBL();

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        
        [ValidateAntiForgeryToken]
        public ActionResult Login(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                bool IsValidUser = employeeBusiness.IsUserValid(
                    new Models.Employee
                    {
                        Password = emp.Password,
                        UserName = emp.UserName
                    }
                    );
                if (IsValidUser)
                {
                    TempData["Name"] = "Tim Ryan";
                    TempData["Address"] = "London,UK";
                    FormsAuthentication.SetAuthCookie(emp.UserName, false);
                    return RedirectToAction("Index", "Employee");
                }
                ViewBag.ErrorMessage = "Provided username or password is incorrect";
            }

            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Home");
        }


    }
}