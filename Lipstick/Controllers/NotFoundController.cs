﻿using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class NotFoundController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
