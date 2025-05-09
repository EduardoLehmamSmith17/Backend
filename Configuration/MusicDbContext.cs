using Microsoft.EntityFrameworkCore;
using projectSpotifyBackend.Models;

namespace projectSpotifyBackend.Configuration;

public class MusicDbContext : DbContext
{
    public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options) { }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<TopArtist> TopArtists { get; set; }
    public DbSet<Discovery> Discoveries { get; set; }
    public DbSet<ListeningStats> ListeningStats { get; set; }
}