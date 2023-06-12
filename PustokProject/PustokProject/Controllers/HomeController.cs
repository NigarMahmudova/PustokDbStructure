using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokProject.DAL;
using PustokProject.ViewModels;

namespace PustokProject.Controllers
{
    public class HomeController : Controller
    {
        readonly PustokDbContext _context;
        public HomeController(PustokDbContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            PustokVM model = new PustokVM()
            {
                HomeSlider = _context.HomeSlider.Include(hs => hs.Button).ToList(),
                Buttons = _context.Buttons.ToList(),
                Features= _context.Features.ToList()
            };
            return View(model);
        }
    }
}
