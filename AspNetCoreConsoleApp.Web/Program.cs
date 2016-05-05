using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AspNetCoreConsoleApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set up hosting.
            var app = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseUrls("http://*:5000/")
                .UseStartup<Startup>()
                .Build();
            
            // Run that shit!!!
            app.Run();
        }
    }
}