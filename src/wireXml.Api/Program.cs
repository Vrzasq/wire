using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using wireXml.Api.Middleware.ApiKey;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}
app.UseSwagger();
app.UseSwaggerUI(config =>
{
    config.SwaggerEndpoint("/swagger/v1/swagger.json", "wireXml.Api");
    config.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<ApiKeyAuthorization>();
app.MapControllers();
app.UseHealthChecks("/hc");
app.Run();
