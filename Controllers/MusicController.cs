using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectSpotifyBackend.Configuration;
using projectSpotifyBackend.Models;

namespace projectSpotifyBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MusicController : ControllerBase
{
    private readonly MusicDbContext _context;

    public MusicController(MusicDbContext context)
    {
        _context = context;
    }

    [HttpGet("artists")]
    public async Task<ActionResult<IEnumerable<Artist>>> GetArtists()
    {
        var artists = await _context.Artists.ToListAsync();
        return Ok(artists);
    }

    [HttpGet("artist/{id}")]
    public async Task<ActionResult<Artist>> GetArtist(int id)
    {
        var artist = await _context.Artists.FindAsync(id);
        if (artist == null) return NotFound();
        return artist;
    }

    [HttpPost("artist")]
    public async Task<ActionResult<Artist>> CreateArtist(Artist artist)
    {
        _context.Artists.Add(artist);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetArtist), new { id = artist.Id }, artist);
    }

    [HttpPut("artist/{id}")]
    public async Task<IActionResult> UpdateArtist(int id, Artist updatedArtist)
    {
        var artist = await _context.Artists.FindAsync(id);
        if (artist == null) return NotFound();

        artist.Name = updatedArtist.Name;
        artist.Gender = updatedArtist.Gender;
        artist.Image = updatedArtist.Image;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("artist/{id}")]
    public async Task<IActionResult> DeleteArtist(int id)
    {
        var artist = await _context.Artists.FindAsync(id);
        if (artist == null) return NotFound();

        _context.Artists.Remove(artist);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpGet("albums")]
    public async Task<ActionResult<IEnumerable<Album>>> GetAlbums()
    {
        var albums = await _context.Albums.ToListAsync();
        return Ok(albums);
    }

    [HttpGet("songs/trending")]
    public async Task<ActionResult<IEnumerable<Song>>> GetTrendingSongs()
    {
        var songs = await _context.Songs.Take(5).ToListAsync();
        return Ok(songs);
    }

    [HttpGet("songs/highlightstop")]
    public async Task<ActionResult<IEnumerable<Song>>> GetHighlightStop()
    {
        var songs = await _context.Songs.Skip(5).Take(5).ToListAsync();
        return Ok(songs);
    }

    [HttpGet("songs/sweetdreams")]
    public async Task<ActionResult<IEnumerable<Song>>> GetSweetDreams()
    {
        var songs = await _context.Songs.Skip(10).Take(5).ToListAsync();
        return Ok(songs);
    }

    [HttpGet("stats/genres")]
    public async Task<ActionResult<IEnumerable<Genre>>> GetGenres()
    {
        var genres = await _context.Genres.ToListAsync();
        return Ok(genres);
    }

    [HttpGet("stats/topartists")]
    public async Task<ActionResult<IEnumerable<TopArtist>>> GetTopArtists()
    {
        var topArtists = await _context.TopArtists.ToListAsync();
        return Ok(topArtists);
    }

    [HttpGet("stats/discoveries")]
    public async Task<ActionResult<IEnumerable<Discovery>>> GetDiscoveries()
    {
        var discoveries = await _context.Discoveries.ToListAsync();
        return Ok(discoveries);
    }

    [HttpGet("stats/listeningtime")]
    public async Task<ActionResult<ListeningStats>> GetListeningTime()
    {
        var listeningStats = await _context.ListeningStats.FirstOrDefaultAsync();
        if (listeningStats == null) return NotFound();
        return listeningStats;
    }
}