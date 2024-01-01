namespace wire.Api.Middleware.ApiKey;

internal static class ServiceCollectionExtensions
{
    public static void AddApiKeyValidation(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<ApiKeyConfig>(configuration.GetRequiredSection(ApiKeyConfig.SectionName));
        services.AddSingleton<IApiKeyValidator, ApiKeyValidator>();
    }

    public static void UseApiKeyValidation(this IApplicationBuilder app)
    {
        app.UseMiddleware<ApiKeyAuthorization>();
    }
}
