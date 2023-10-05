using Microsoft.AspNetCore.Mvc;
using MediatR;
using MediatRTest.Queries;
namespace MediatRTest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMediator _mediator;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                     IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get()
    {
        var request = new GetForecastQuery();
        var result = await _mediator.Send(request);
        return Ok(result);
    }
}
