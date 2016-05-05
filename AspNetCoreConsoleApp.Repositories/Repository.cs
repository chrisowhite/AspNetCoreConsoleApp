using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreConsoleApp.Contracts.Entities;
using AspNetCoreConsoleApp.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreConsoleApp.Repositories
{
    public class Repository : IRepository
    {
        private readonly IServiceProvider serviceProvider;
        
        public Repository(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        
        public IEnumerable<User> GetUsers() 
        {
            using (var context = serviceProvider.GetService<TestContext>())
            {
                return context.Users.ToList();
            }
        }
    }
}