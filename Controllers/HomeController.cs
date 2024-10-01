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

     
    }
}
