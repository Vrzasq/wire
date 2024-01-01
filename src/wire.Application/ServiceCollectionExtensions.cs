using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using wire.Application.Behaviors;

namespace wire.Application;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services,
        IConfiguration configuration)
    {
        if (services is null)
            throw new ArgumentNullException(nameof(services));
        if (configuration is null)
            throw new ArgumentNullException(nameof(configuration));

        services.AddLoggingBehavior();

        services.AddMediator(options =>
        {
            options.ServiceLifetime = ServiceLifetime.Scoped;
        });
    }


}
