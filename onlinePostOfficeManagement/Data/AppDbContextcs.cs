using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using onlinePostOfficeManagement.Models;


namespace onlinePostOfficeManagement.Data
{
    public class AppDbContext :IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}