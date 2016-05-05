using AspNetCoreConsoleApp.Contracts.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreConsoleApp.Repositories
{
    public class TestContext : DbContext
    {
        public TestContext() 
        {
            
        }
        
        public TestContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<User> Users {get;set;}
    }
}