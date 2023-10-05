using MediatR;
using MediatRTest.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MediatRTest.Handlers;
public class GetForecastHandler : IRequestHandler<GetForecastQuery, IEnumerable<WeatherForecast>>
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


    public async Task<IEnumerable<WeatherForecast>> Handle(GetForecastQuery request, CancellationToken token)
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        });
    }
}