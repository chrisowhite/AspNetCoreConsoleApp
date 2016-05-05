using AspNetCoreConsoleApp.Contracts.Repositories;
using AspNetCoreConsoleApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AspNetCoreConsoleApp.Contracts.Entities;

namespace AspNetCoreConsoleApp.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Setup in-memory database provider for TestContext. DbContext is dumb, and you HAVE to specify a provider.
            // Mind blown...
            services.AddDbContext<TestContext>(options => {
               options.UseInMemoryDatabase();
            });
            
            // MVC!!!
            services.AddMvc();
            
            // Map repository dependency.
            services.AddTransient<IRepository, Repository>();
        }
        
        public void Configure(IApplicationBuilder app)
        {
            // Exception page would be nice for testing stuff.
            app.UseDeveloperExceptionPage();
            
            // Default route config, because lazy.
            app.UseMvcWithDefaultRoute();
            
            // Add some data to my in-memory database.
            using (var context = app.ApplicationServices.GetService<TestContext>())
            {
                context.Users.Add(new User
                {
                    UserId = 1,
                    Username = "cdub",
                    FirstName = "Chris",
                    LastName = "White"
                });
                
                context.SaveChanges();
            }
        }
    }
}