using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace LystfiskerPortalen.Backend.Data
{
    public class LystfiskerPortalenIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public LystfiskerPortalenIdentityDbContext(DbContextOptions<LystfiskerPortalenIdentityDbContext> options)
            : base(options)
        {

        }
    }
}
