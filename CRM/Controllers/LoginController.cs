using CRM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CRM.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Login";
            ViewBag.Introduction = "Vui long dang nhap he thong!";
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
            {
                ViewBag.WrongAccount = "Enter your account, Please!";
                return View();
            }
            else if(string.Equals(model.Email,"nguyenhoangtai2k@gmail.com") && string.Equals(model.Password, "123"))
            {
                return RedirectToAction("Index","Home");
            }
            ViewBag.WrongAccount = "Username or Password is wrong, Please, try again!";
            return View();

        }

        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult ResetPassword()
        //{
        //    return View();
        //}
    }
}
