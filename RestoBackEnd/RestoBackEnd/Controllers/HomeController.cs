using Microsoft.AspNetCore.Mvc;
using RestoBackEnd.DAL;
using RestoBackEnd.ViewModels;
using System.Linq;

namespace RestoBackEnd.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();

            homeVM.SliderVM=_context.Slider.ToList();

            homeVM.PageIntro=_context.PageIntro.FirstOrDefault();

            homeVM.AboutVM=_context.About.FirstOrDefault();

            homeVM.AboutCardVM=_context.AboutCard.ToList();

            homeVM.Beef=_context.BeefMeal.FirstOrDefault();

            homeVM.Salmon=_context.SalmonMeal.FirstOrDefault();


            return View(homeVM);
        }
    }
}
