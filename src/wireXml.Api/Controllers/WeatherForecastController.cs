using Mediator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace wireXml.Api.Controllers;

public record TestRequest : IRequest<IEnumerable<WeatherForecast>>;
public class TestRequestHandler : IRequestHandler<TestRequest, IEnumerable<WeatherForecast>>
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public ValueTask<IEnumerable<WeatherForecast>> Handle(TestRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException("asdiasudoausdoasd");
        return ValueTask.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            WhetherType = (WhetherType)Random.Shared.Next(0, 3)
        }));
    }
}


[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMediator _mediator;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        var response = await _mediator.Send(new TestRequest());
        return response;
    }

    [HttpPost]
    public int Post(WhetherType whetherType)
    {
        return (int)whetherType;
    }
}
