using Microsoft.EntityFrameworkCore;
using WebApplication3529.ModelClass;

namespace WebApplication3529.Contextclass
{
    public class RajiniAyurvedaContext : DbContext
    {
        public RajiniAyurvedaContext(DbContextOptions<RajiniAyurvedaContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        //(localdb)\MSSQLLocalDB  RajiniAyurveda
    }
}
