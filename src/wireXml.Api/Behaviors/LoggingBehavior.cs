using Mediator;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace wireXml.Api.Behaviors;

public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull, IMessage
{
    const string RequestTemplate = "Handling {RequestName} {Request}";
    const string ResponseTemplate = "Handled: {RequestName} - Response {ResponseName}: {Response}";

    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;
    private readonly JsonSerializerOptions _serializerOptions = new() { ReferenceHandler = ReferenceHandler.IgnoreCycles };

    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger) =>
        _logger = logger;

    public async ValueTask<TResponse> Handle(
        TRequest request,
        CancellationToken ct,
        MessageHandlerDelegate<TRequest, TResponse> next)
    {
        _logger.LogInformation(RequestTemplate,
            typeof(TRequest).Name,
            JsonSerializer.Serialize(request, _serializerOptions));

        var response = await next(request, ct);

        _logger.LogInformation(ResponseTemplate,
            typeof(TRequest).Name,
            typeof(TResponse).Name,
            JsonSerializer.Serialize(response, _serializerOptions));

        return response;
    }
}
