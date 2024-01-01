using Mediator;
using Microsoft.AspNetCore.Mvc;
using wire.Application.Query.WeatherForecast;

namespace wire.Api.Controllers;

public class WeatherForecastController(IMediator mediator) : BaseApiController(mediator)
{
    [HttpGet]
    public async ValueTask<WeatherForecast[]> Get()
    {
        return await Mediator.Send(new WeatherForecastQuery());
    }
}
