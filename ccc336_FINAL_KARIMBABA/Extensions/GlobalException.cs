using ccc336_FINAL_KARIMBABA.Filters;

namespace ccc336_FINAL_KARIMBABA.Extenstions
{
    public static class GlobalException
    {
        public static IServiceCollection GlobalExceptions(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });
            return services;
        }
    }
}
