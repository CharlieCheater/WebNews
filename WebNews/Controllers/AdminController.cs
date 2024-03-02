using Microsoft.AspNetCore.Mvc;
using WebNews.Domain;
using WebNews.Models;

namespace WebNews.Controllers
{
    public class AdminController : Controller
    {
        private readonly MainContext _context;
        public AdminController(MainContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(CreatePostViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            _context.Publications.Add(new Publication
            {
                Title = viewModel.Title,
                Author = viewModel.Author,
                Description = viewModel.Description
            });
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
