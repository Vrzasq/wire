using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using xmlObjectProvider;

namespace wireXml;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var host = CreateHostBuilder().Build();

        Application.Run(host.Services.GetRequiredService<MainWindow>());
    }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => {
                services.AddTransient<MainWindow>();
                services.AddXmlObjectProvider();
            });
    }
}