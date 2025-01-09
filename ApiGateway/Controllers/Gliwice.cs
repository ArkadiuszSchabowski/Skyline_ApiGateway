using ApiGateway.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Gliwice : ControllerBase
    {
        [HttpGet]
        public ActionResult<MovieDto> DummyMoviesGliwice()
        {
            var movies = new List<MovieDto> {
                new MovieDto {Id = 1, Title = "Gladiator"},
                new MovieDto {Id = 2, Title = "Shrek"},
                new MovieDto {Id = 3, Title = "Wilk z Wall Street"},
                new MovieDto {Id = 4, Title = "Incepcja"},
                new MovieDto {Id = 5, Title = "Matrix"},
                new MovieDto {Id = 6, Title = "Król Lew"},
                new MovieDto {Id = 7, Title = "Forrest Gump"},
                new MovieDto {Id = 8, Title = "Ojciec chrzestny"},
                new MovieDto {Id = 9, Title = "Skazani na Shawshank"},
                new MovieDto {Id = 10, Title = "Władca Pierścieni: Drużyna Pierścienia"}
            };
            return Ok(movies);
        }
    }

}

