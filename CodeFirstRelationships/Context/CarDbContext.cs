using CodeFirstRelationships.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationships.Context
{
    public class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<LicensePlate> LicensePlates { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<CarEngineer> CarEngineers { get; set; } // Bu entity'i kendimiz oluşturduysak Context sınıfı içine yazılması gerekli. Ancak Default Convention ile otomatik oluşturuyorsa buraya yazmamıza gerek yok.
        public DbSet<Department> Departments { get; set; }
        public DbSet<Part> Parts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = IMEHMETC;Database = CodeFirstRelationshipsDb;User Id = sa;Password = 123;TrustServerCertificate = true");
        }
    }
}
