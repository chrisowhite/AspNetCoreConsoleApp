using System.Collections.Generic;
using AspNetCoreConsoleApp.Contracts.Entities;

namespace AspNetCoreConsoleApp.Contracts.Repositories
{
    public interface IRepository
    {
        IEnumerable<User> GetUsers();
    }
}
