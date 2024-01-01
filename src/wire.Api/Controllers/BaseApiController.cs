using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace wire.Api.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class BaseApiController(IMediator mediator) : ControllerBase
{
    public IMediator Mediator { get; } = mediator;
}
