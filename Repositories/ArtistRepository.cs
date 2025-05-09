using Microsoft.EntityFrameworkCore;
using projectSpotifyBackend.Configuration;
using projectSpotifyBackend.Models;
using projectSpotifyBackend.Repositories.Interface;

namespace projectSpotifyBackend.Repositories;

public class ArtistRepository : IArtistRepository
{
    private readonly MusicDbContext _context;

    public ArtistRepository(MusicDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Artist>> GetAllAsync() =>
        await _context.Artists.ToListAsync();

    public async Task<Artist?> GetByIdAsync(int id) => await _context.Artists.FindAsync(id);

    public async Task AddAsync(Artist artist)
    {
        _context.Artists.Add(artist);
        await _context.SaveChangesAsync();
    }
}
