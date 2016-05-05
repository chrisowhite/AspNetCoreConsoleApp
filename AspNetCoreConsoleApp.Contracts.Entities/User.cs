using System.ComponentModel.DataAnnotations;

namespace AspNetCoreConsoleApp.Contracts.Entities
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        public string Username {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
    }
}