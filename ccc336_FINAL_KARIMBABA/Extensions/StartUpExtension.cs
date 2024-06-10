using Microsoft.EntityFrameworkCore;
using FINAL_DAL.Models;
namespace ccc336_FINAL_KARIMBABA.Extensions
{
    public static class StartUpExtention
    {
        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {

            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext<AirplaneSystemContext>(options => options.UseSqlServer(ConnectionString));
            return service;
        }
    }
}
