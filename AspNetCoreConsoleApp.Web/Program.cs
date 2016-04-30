using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AspNetCoreConsoleApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:5000/")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseEnvironment("Development")
                .UseStartup<Startup>()
                .Build();
                
            app.Run();
        }
    }
}