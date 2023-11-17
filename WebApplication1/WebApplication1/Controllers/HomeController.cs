using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.DataAccesLayer;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext _context;

        public HomeController(AppDBContext appContext)
        {
            _context = appContext;
        }

        public IActionResult Index()
        {
            HomeViewModels viewModels = new HomeViewModels();
            viewModels.Sliders = _context.Sliders.ToList();
            viewModels.Services = _context.Services.ToList();
            viewModels.TeamMembers = _context.TeamMembers.ToList();

            return View(viewModels);
        }
    }
}
