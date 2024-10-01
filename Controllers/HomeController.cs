using Microsoft.AspNetCore.Mvc;
using ReservationHub.Data;
using ReservationHub.Models;
using System.Diagnostics;

namespace ReservationHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Camp")]
        public IActionResult Camp()
        {
            return View();
        }
        
        [Route("City")]
        public IActionResult City()
        {
            return View();
        }
        
        [Route("Insurance")]
        public IActionResult Insurance()
        {
            return View();
        }
        
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
     
    }
}
