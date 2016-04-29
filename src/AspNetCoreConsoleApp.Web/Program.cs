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
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();
                
            app.Run();
        }
    }
}