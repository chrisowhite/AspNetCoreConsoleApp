using System.Collections.Generic;
using AspNetCoreConsoleApp.Contracts.Entities;
using AspNetCoreConsoleApp.Contracts.Repositories;

namespace AspNetCoreConsoleApp.Repositories
{
    public class Repository : IRepository
    {
        public IEnumerable<User> GetUsers() 
        {
            return null;
        }
    }
}