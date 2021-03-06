﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCVmvc.Models;

namespace MyCVmvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult CV()
        {
            ViewData["Message"] = "My CV";
            return View();
        }

        public IActionResult DeveloperSkills()
        {
            ViewData["Message"] = "My Developer Skills";
            return View();
        }

        public IActionResult DevOpsSkills()
        {
            ViewData["Message"] = "My DevOps Skills";
            return View();
        }

        public IActionResult Experience()
        {
            ViewData["Message"] = "My Experience";
            return View();
        }

        public IActionResult Certificates()
        {
            ViewData["Message"] = "My Certificates";
            return View();
        }

        public IActionResult Hobbies()
        {
            ViewData["Message"] = "My Hobbies";
            return View();
        }

        public IActionResult Contacts()
        {
            ViewData["Message"] = "My Contacts";
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
