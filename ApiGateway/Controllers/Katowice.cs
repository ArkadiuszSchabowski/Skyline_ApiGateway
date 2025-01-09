using ApiGateway.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Katowice : ControllerBase
    {
        [HttpGet]
        public ActionResult<MovieDto> DummyMoviesKatowice()
        {
            var movies = new List<MovieDto>{
                new MovieDto {Id = 1, Title = "Avatar"},
                new MovieDto {Id = 2, Title = "Gwiezdne Wojny: Nowa nadzieja"},
                new MovieDto {Id = 3, Title = "Piraci z Karaibów: Klątwa Czarnej Perły"},
                new MovieDto {Id = 4, Title = "Hobbit: Niezwykła podróż"},
                new MovieDto {Id = 5, Title = "Czarna Pantera"},
                new MovieDto {Id = 6, Title = "Joker"},
                new MovieDto {Id = 7, Title = "Titanic"},
                new MovieDto {Id = 8, Title = "Łowca androidów"},
                new MovieDto {Id = 9, Title = "Toy Story"},
                new MovieDto {Id = 10, Title = "Mad Max: Na drodze gniewu"}
            };
            return Ok(movies);
        }
    }
}
