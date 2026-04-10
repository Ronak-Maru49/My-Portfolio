 // Faq model namespace
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Admin_panel.Data;
using System.Linq;

namespace FAQManagement.Controllers
{
    public class DisplayController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DisplayController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Display
        [HttpGet]
        public IActionResult Index()
        {
            var faqs = _context.Faqs.ToList(); // fetch all FAQs
            return View(faqs);                 // pass to Razor view
        }
    }
}