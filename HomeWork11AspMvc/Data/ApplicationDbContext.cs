using HomeWork11AspMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork11AspMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
