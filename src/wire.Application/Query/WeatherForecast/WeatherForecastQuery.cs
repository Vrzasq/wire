using Mediator;

namespace wire.Application.Query.WeatherForecast;

public record WeatherForecastQuery : IRequest<WeatherForecast[]>;
