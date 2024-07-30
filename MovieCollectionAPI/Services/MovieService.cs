using MongoDB.Driver;
using MovieCollectionAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieCollectionAPI.Services
{
    public class MovieService
    {
        private readonly IMongoCollection<Movie> _movies;

        public MovieService(IMongoDatabase database)
        {
            _movies = database.GetCollection<Movie>("movies");
        }

        public async Task<List<Movie>> GetAllMovies() =>
            await _movies.Find(movie => true).ToListAsync();

        public async Task<Movie> GetMovieById(string id) =>
            await _movies.Find(movie => movie.Id == id).FirstOrDefaultAsync();

        public async Task CreateMovie(Movie movie) =>
            await _movies.InsertOneAsync(movie);

        public async Task UpdateMovie(string id, Movie movieIn) =>
            await _movies.ReplaceOneAsync(movie => movie.Id == id, movieIn);

        public async Task DeleteMovie(string id) =>
            await _movies.DeleteOneAsync(movie => movie.Id == id);
    }
}
