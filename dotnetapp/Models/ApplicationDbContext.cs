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
}
}