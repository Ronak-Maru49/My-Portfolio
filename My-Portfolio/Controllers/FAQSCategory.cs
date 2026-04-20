using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Admin_panel.Data;
using My_Admin_panel.Models;

namespace My_Admin_panel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaqCategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FaqCategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FaqCategory
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var data = await _context.Faqs.ToListAsync();
            return Ok(data);
        }
    }
}