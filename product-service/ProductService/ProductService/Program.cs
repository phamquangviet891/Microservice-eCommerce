using Microsoft.AspNetCore.Hosting;
using ProductService.DataModels;
using Microsoft.Extensions.Hosting;

namespace ProductService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();                  
                });
    }
}
