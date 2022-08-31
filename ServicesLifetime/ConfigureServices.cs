using ServicesLifetime.Abstract;
using ServicesLifetime.Concrete;

namespace DependencyInjectionLifetimes
{
    public static class ConfigureServices
    {
        public static void ConfigureLifetimes(this IServiceCollection services)
        {
            services.AddTransient<ITransientService, TransientService>();
            services.AddScoped<IScopedService, ScopedService>();
            services.AddSingleton<ISingletonService, SingletonService>();
        }
    }
}