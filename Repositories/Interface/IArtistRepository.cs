using projectSpotifyBackend.Models;

namespace projectSpotifyBackend.Repositories.Interface;

public interface IArtistRepository
{
    Task<IEnumerable<Artist>> GetAllAsync();
    Task<Artist?> GetByIdAsync(int id);
    Task AddAsync(Artist artist);
}
