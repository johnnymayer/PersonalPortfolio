﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolio.Models;


namespace PersonalPortfolio.Controllers
{
    public class ProjectsController : Controller
    {
		public IActionResult Index()
		{
			return View();
		}
	}
}
