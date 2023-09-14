using Calendar.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Calendar.DataAccess
{
    public class CalendarDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=GVY788; Database=eventsDB; Integrated Security=true;");
        }
        public DbSet<Etkinlik> Events { get; set; }

        public DbSet<User> Users { get; set; }

        public object User { get; set; }
        public object Etkinlik { get; set; }
    }
}
