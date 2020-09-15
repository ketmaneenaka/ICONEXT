using Microsoft.EntityFrameworkCore;
using ICONEXT.Models;


namespace ICONEXT.Data
{
    public class ICONEXTContext : DbContext
    {
        public ICONEXTContext(DbContextOptions options)
                  : base(options)
        {
        }

        public DbSet<employee> employee { get; set; }
    }
}