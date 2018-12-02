using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Semesterprojekt.API;

namespace Semesterprojekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
