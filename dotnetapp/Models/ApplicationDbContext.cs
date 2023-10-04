using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // write your dbsets here... 
        // if required write OnModelCreating  
        public DbSet<Slot> Slots{get;set;}
        public DbSet<Booking> Bookings {get;set;} 
    }
}