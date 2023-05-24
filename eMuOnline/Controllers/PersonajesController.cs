using eMuOnline.Data;
using Microsoft.AspNetCore.Mvc;

namespace eMuOnline.Controllers
{
    public class PersonajesController : Controller
    {
        private readonly AppDbContext _context;

        public PersonajesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Personajes.ToList();
            return View();
        }
    }
}
