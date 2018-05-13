using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace PersonalPortfolio.Controllers
{
    public class ProjectsController : Controller
    {
		public IActionResult Index()
        {
            ViewData["Message"] = "Personal Portfolio";
            var allRepos = Repo.GetRepos();
            return View("Projects");
        }
    }
}
