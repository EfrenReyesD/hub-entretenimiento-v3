using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace backend.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class FavoritesController : ControllerBase
{
    private readonly ApplicationDBContext _context;

    public FavoritesController(ApplicationDBContext context)
    {
        _context = context;
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddFavorite([FromBody] FavoriteDto favoriteDto)
    {
        if (favoriteDto.movie_id == null)
        {
            return BadRequest("At least one of MovieId or SeriesId is required.");
        }

        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        // Verificar si el favorito ya existe
        var existingFavorite = await _context.Favorites
            .FirstOrDefaultAsync(f => f.user_id == userId &&
                                      f.movie_id == favoriteDto.movie_id);

        if (existingFavorite != null)
        {
            return Conflict("Favorite already exists.");
        }

        var favorite = new Favorite
        {
            user_id = userId,
            movie_id = favoriteDto.movie_id,
        };

        _context.Favorites.Add(favorite);
        await _context.SaveChangesAsync();

        return Ok(favorite);
    }
}

}