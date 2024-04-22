using Entites.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;DataBase=worldofaestetics;
            Trusted_Connection=true");
        }
        public DbSet<Yorumlar> Yorumlar { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Randevu> Randevu { get; set; }  
        public DbSet<Calisan> Calisan  { get; set; }     
    }
}
