using Microsoft.OpenApi.Models;
using Serilog.Events;
using Serilog;
using System.Text.Json.Serialization;
using wireXml.Api.Middleware.ApiKey;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateBootstrapLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, services, configuration) => configuration
    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
    .ReadFrom.Configuration(context.Configuration)
    .ReadFrom.Services(services)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File(
        path: "logs/wire.api-.log",
        outputTemplate: "{Timestamp:HH:mm:ss.ff zzzz} [{Level:u3}] [{RequestId}] {Message:lj}{NewLine}{Exception}",
        rollingInterval: RollingInterval.Day)
    );

builder.Services.AddControllers()
    .AddXmlSerializerFormatters()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("apiKey", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.ApiKey,
        In = ParameterLocation.Header,
        Name = ApiKeyAuthorization.ApiKeyHeader,
        Scheme = "apikey"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "apiKey",
                    Type = ReferenceType.SecurityScheme
                },
                In = ParameterLocation.Header
            },
            Array.Empty<string>()
        }
    });
});

builder.Services.AddHealthChecks();
builder.Services.AddMediator();
builder.Services.Configure<ApiKeyConfig>(builder.Configuration.GetRequiredSection(ApiKeyConfig.SectionName));
builder.Services.AddSingleton<IApiKeyValidator, ApiKeyValidator>();

var app = builder.Build();
app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI(config =>
    {
        config.SwaggerEndpoint("/swagger/v1/swagger.json", "wireXml.Api");
        config.RoutePrefix = string.Empty;
    });
}

app.UseSwagger();
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<ApiKeyAuthorization>();
app.MapControllers();
app.UseHealthChecks("/hc");
app.Run();
