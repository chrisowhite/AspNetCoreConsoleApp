using AspNetCoreConsoleApp.Contracts.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreConsoleApp.Repositories
{
    public class TestContext : DbContext
    {        
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
            
        }
        
        public DbSet<User> Users {get;set;}
    }
}