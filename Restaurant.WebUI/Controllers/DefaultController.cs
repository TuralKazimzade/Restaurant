﻿using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
