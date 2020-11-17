﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrgXDimension.Models;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using OrgXDimension.ViewModel;
using OrgXDimension.Migrations;
using OrgXDimension.Data.Migrations;
using OrgXDimension.Data;
namespace OrgXDimension.Controllers
{
    public class HomeController : Controller
    {
        //private OrgXDimensionContext db = new OrgXDimensionContext();
        public IActionResult Index()
        {
            //DashboardViewModel dashboard = new DashboardViewModel();

            //dashboard.job_count = db.JobRole.Count();
            //dashboard.gender_count = db.Gender.Count();
            //dashboard.mary_count = db.MaritalStatus.Count();
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
