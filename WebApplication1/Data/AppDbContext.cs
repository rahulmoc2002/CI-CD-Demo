using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.MyWebApiProject.Models;

namespace WebApplication1.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
    }

}
