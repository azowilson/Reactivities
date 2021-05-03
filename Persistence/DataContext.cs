using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }


        // represents table in the database, 
        //and the table called Activities with the <Activity> props.
        public DbSet<Activity> Activities { get; set; } 
        
    }
}