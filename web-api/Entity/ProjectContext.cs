using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProjectContext:DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<CoronaVaccine> vaccines { get; set; }
        public DbSet<CoronaDetails> details { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-QM3UF42;Database=project-h;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true\r\n");
        }
    }
}
