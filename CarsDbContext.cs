using Microsoft.EntityFrameworkCore;
using Database_2;
public class CarsDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=..\..\..\cars.db");
    }
    public DbSet<Car> Cars { get; set; }

}


//namespace Database_2
//{
   
//}
