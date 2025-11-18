using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace LystfiskerPortalen.Backend.Data
{
    public class LystfiskerPortalenIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        // Special constructor that makes it possible to configure the database for different environments.
        // Constructor that accepts DbContextOptions and passes it to the base class constructor 
        // to configure the DbContext. 
        // This allows for dependency injection and configuration of the DbContext from outside.
        // The options parameter contains configuration information such as the database provider,
        // connection string, and other settings.
        public LystfiskerPortalenIdentityDbContext(DbContextOptions<LystfiskerPortalenIdentityDbContext> options)
            : base(options)
        {

        }
    }
}
