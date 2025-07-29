namespace Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddOpenApi();

            return services;
        }
    }
}
