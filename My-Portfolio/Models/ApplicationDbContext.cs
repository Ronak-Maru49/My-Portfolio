using Microsoft.EntityFrameworkCore;
using My_Admin_panel.Models;

namespace My_Admin_panel.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // This will create a table named 'Faqs'
        public DbSet<Faq> Faqs { get; set; }
    }
}