using MoviesAPI.Data;

namespace MoviesAPI.Services;

public class MoviesService
{
    private AppDbContext _context;

    public MoviesService(AppDbContext context)
    {
        _context = context;
    }

    public void AddMovie(MoviesVM movies)
    {
        var newMovie = new Movies()
        {
            Name = movies.Name,
            Year = movies.Year,
            Genre = movies.Genre,
        };
        _context.Movies.Add(newMovie);
        _context.SaveChanges();
    }
}