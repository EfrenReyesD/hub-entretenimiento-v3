// C# - MovieService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

public class MovieService
{
    private readonly ApplicationDBContext _context;

    public MovieService(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<List<Movie>> GetMoviesAsync()
    {
        return await _context.Movies.ToListAsync();
    }
}
