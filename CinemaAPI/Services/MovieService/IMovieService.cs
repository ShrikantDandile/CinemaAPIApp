using CinemaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Services.MovieService
{
   public interface IMovieService
   {
      Task<ServiceResponse<List<Movie>>> GetAllMovies();
      Task<ServiceResponse<List<Movie>>> AddMovies(Movie movie);
   }
}
