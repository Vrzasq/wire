using Microsoft.Extensions.DependencyInjection;
using xmlObjectProvider.Services.XlsxMapperService;
using xmlObjectProvider.Services.XlsxMapperService.XmlMappers.ZUSE;
using xmlObjectProvider.Services.XlsxMapperService.XmlMappers.ZUSEB;

namespace xmlObjectProvider;

public static class ServiceCollectionExtensions
{
    public static void AddXmlObjectProvider(this IServiceCollection services)
    {
        services.AddTransient<IXlsxToXmlMapper, XlsxToXmlMapper>();
        services.AddTransient<IXmlMapper, ZUSEMapper>();
        services.AddTransient<IXmlMapper, ZUSEBMapper>();
    }
}
