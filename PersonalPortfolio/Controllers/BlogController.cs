using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using PersonalPortfolio.Models;
using Microsoft.AspNetCore.Identity;

namespace PersonalPortfolio.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public BlogController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var model = _db.Blogs.ToList();
            return View(model);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            _db.Blogs.Add(blog);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisBlog = _db.Blogs.FirstOrDefault(Blogs => Blogs.BlogId == id);
            return View(thisBlog);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisBlog = _db.Blogs.FirstOrDefault(Blogs => Blogs.BlogId == id);
            _db.Blogs.Remove(thisBlog);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}