using MediatR;
using System.Collections.Generic;
namespace MediatRTest.Queries
{
    public class GetForecastQuery : IRequest<IEnumerable<WeatherForecast>>
    {}
}