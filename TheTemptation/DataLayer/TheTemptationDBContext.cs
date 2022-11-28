using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class TheTemptationDBContext : DbContext
    {
        public TheTemptationDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<GameUser> GameUsers { get; set;}
        public DbSet<Draw> Draws { get; set;}
    }
    
}