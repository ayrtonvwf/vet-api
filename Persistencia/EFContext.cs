using Microsoft.EntityFrameworkCore;
using Model;

namespace Persistencia
{
    public class EFContext: DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public DbSet<Consultation> Consultations { get; set; }
        
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<Prescription> Prescriptions { get; set; }
        
        public DbSet<Vet> Vets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(@"Server=localhost;Database=vet;Uid=root;Pwd=;");
        }
    }
}