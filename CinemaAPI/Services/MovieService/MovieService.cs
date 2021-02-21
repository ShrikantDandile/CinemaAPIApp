using CinemaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Services.MovieService
{
   public class MovieService : IMovieService
   {
      private static List<Movie> Movies = new List<Movie>()
      {
         new Movie(){Id=1, Name="Mission Impossiable1", Language="Eng" },
         new Movie(){Id=2, Name="Mission Impossiable2", Language="Eng" },
         new Movie(){Id=3, Name="Mission Impossiable3", Language="Eng" },
      };

      public async Task<ServiceResponse<List<Movie>>> AddMovies(Movie movie)
      {
         ServiceResponse<List<Movie>> serviceResponse = new ServiceResponse<List<Movie>>();
         Movies.Add(movie);
         serviceResponse.Data = Movies;
         serviceResponse.Message = "Movie Added Successfully!";
         return serviceResponse;
      }

      public async Task<ServiceResponse<List<Movie>>> GetAllMovies()
      {
         ServiceResponse<List<Movie>> serviceResponse = new ServiceResponse<List<Movie>>();
         serviceResponse.Data = Movies;
         serviceResponse.Message = Movies.Count + " Movie records found!";
         return serviceResponse;
      }
   }
}
