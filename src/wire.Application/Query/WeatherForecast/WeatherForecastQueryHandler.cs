using Mediator;

namespace wire.Application.Query.WeatherForecast;

public record WeatherForecastQueryHandler : IRequestHandler<WeatherForecastQuery, WeatherForecast[]>
{
    private static readonly string[] Summaries = 
        [ "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" ];

    public ValueTask<WeatherForecast[]> Handle(WeatherForecastQuery request, CancellationToken cancellationToken)
    {
        return ValueTask.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray());
    }
}
