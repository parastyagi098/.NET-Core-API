using Microsoft.EntityFrameworkCore;
using Apidemo.Models;

namespace Apidemo.Data 
{
    public class ApidemoContext : DbContext
    {
        public ApidemoContext(DbContextOptions<ApidemoContext> opt) : base(opt)
        {

        }

        public DbSet<Api> Commands {get; set;}
    }
}