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
                .UseStartup<Startup>()
                .Build();
                
            app.Run();
        }
    }
}