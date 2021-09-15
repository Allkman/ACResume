using Microsoft.Extensions.DependencyInjection;

namespace ACResume.API.AutoMapper
{
    public static class AutoMapperServiceExtension
    {
        public static IServiceCollection ConfigureAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(MyResumeProfile));
            return services;
        }
    }
}
