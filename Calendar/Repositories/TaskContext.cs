using Calendar.Models;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Repositories {
    public class TaskContext : DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=calendar.db");
        }
        public DbSet<Task> Tasks { get; set; }
    }
}
