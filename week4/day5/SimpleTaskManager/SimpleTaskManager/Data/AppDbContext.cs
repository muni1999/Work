using Microsoft.EntityFrameworkCore;
using SimpleTaskManager.Models;
using System.Collections.Generic;

namespace SimpleTaskManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
