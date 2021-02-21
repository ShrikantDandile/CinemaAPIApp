using CinemaAPI.Models;
using CinemaAPI.Services.MovieService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Controllers
{
   [Authorize]
   [Route("api/[controller]")]
   [ApiController]
   public class MoviesController : ControllerBase
   {
      private readonly IMovieService _movieService;

      public MoviesController(IMovieService  movieService)
      {
         _movieService = movieService;
      }
      

      [HttpGet]
      public async Task<IActionResult> GetAllMovies()
      {
         return Ok(await _movieService.GetAllMovies());
      }

      [HttpPost]
      public async Task<IActionResult> AddMovie([FromBody] Movie movie)
      {
         return Ok(await _movieService.AddMovies(movie));
      }

      //[HttpPut("{Id}")]
      //public IEnumerable<Movie> UpdateMovie(int id, [FromBody] Movie movie)
      //{
      //   var _movie = Movies.FirstOrDefault(x => x.Id == id);
      //   _movie.Name = movie.Name;
      //   _movie.Language = movie.Language;
      //   Movies[id] = movie;
      //   return Movies;
      //} 

      //[HttpDelete("{Id}")]
      //public IEnumerable<Movie> DeleteMovie(int id)
      //{
      //   var _movie = Movies.FirstOrDefault(x => x.Id == id);
      //   Movies.Remove(_movie);
      //   return Movies;
      //} 
   }
}
