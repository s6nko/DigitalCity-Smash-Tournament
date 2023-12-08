using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST_DOMAIN.Entities;

namespace ST_DAL
{
    public class STContext : DbContext
    {
        public DbSet<Player> Members { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Team> Teams { get; set; }
        
        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ST_DB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
