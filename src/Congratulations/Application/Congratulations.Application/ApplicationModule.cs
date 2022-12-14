using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Sev1.Congratulations.AppServices.Services.Category.Interfaces;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using Sev1.Congratulations.AppServices.Services.Category.Implementations;
using Sev1.Congratulations.AppServices.Services.Congratulation.Implementations;
using Sev1.Congratulations.AppServices.Services.Tag.Interfaces;
using Sev1.Congratulations.AppServices.Services.Region.Interfaces;
using Sev1.Congratulations.AppServices.Services.Tag.Implementations;
using Sev1.Congratulations.AppServices.Services.Region.Implementations;

namespace Sev1.Congratulations.AppServices
{
    public static class ApplicationModule
    {
        // Через IServiceCollection сервисы и добавляются в проект.
        public static IServiceCollection AddApplicationModule(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // AddScoped:
            //
            // This method creates a Scoped service.
            // A new instance of a Scoped service is created
            // once per request within the scope.
            // For example, in a web application it creates 1 instance
            // per each http request but uses the same instance
            // in the other calls within that same web request.
            services
                .AddScoped<ICategoryService, CategoryServiceV1>()
                .AddScoped<ICongratulationService, CongratulationServiceV1>()
                .AddScoped<ITagService, TagServiceV1>()
                .AddScoped<IRegionService, RegionServiceV1>();
            return services;
        }
    }
}