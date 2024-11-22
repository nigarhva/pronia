using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proina.Domin.Entities;
using Pronia.DataAccess.Contexts;
using Pronia.Uİ.Models;
using System.Diagnostics;

namespace Pronia.Uİ.Controllers
{
    public class HomeController : Controller
    {
        private ProniaDbContext context { get;  }
        public HomeController(ProniaDbContext _context)
        {
            context= _context;
        }

        public async Task< IActionResult> Index()
        {
            var sliders = await context.Sliders.ToListAsync();
            return View(sliders);
        }

       
    }
}
