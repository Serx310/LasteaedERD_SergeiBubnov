using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LasteaedERD_SergeiBubnov_TARpe20.CFM.Models;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.DataContext
{
    class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-32CD23JD\SQLEXPRESS;Database=Kindergarten;Trusted_Connection=true;MultipleActiveResultSets=true");
        }
        
        public DbSet<Child> Child { get; set; }
        public DbSet<Absence> Absence { get; set; }
        public DbSet<Cook> Cook { get; set; }
        public DbSet<EatingHistory> EatingHistory { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupHistory> GroupHistory { get; set; }
        public DbSet<Kitchen> Kitchen { get; set; }
        public DbSet<ListOfEntering> ListOfEntering { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<WorkingHistory> WorkiHistory { get; set; }
    }
}
