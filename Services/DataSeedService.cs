using projectSpotifyBackend.Configuration;
using projectSpotifyBackend.Models;
using projectSpotifyBackend.Services.Interface;

namespace projectSpotifyBackend.Services;

public class DataSeedService : IDataSeedService
{
    private readonly MusicDbContext _context;

    public DataSeedService(MusicDbContext context)
    {
        _context = context;
    }

    public async Task SeedDataAsync()
    {
        if (_context.Artists.Any() || _context.Albums.Any() || _context.Songs.Any())
        {
            return;
        }

        var artists = new List<Artist>
        {
            new Artist { Name = "Henrique & Juliano", Gender = "Sertanejo", Image = "./assets/images/artista-henrique-juliano.jpg" },
            new Artist { Name = "Zé Neto & Cristiano", Gender = "Sertanejo", Image = "./assets/images/artista-ze-neto.jpg" },
            new Artist { Name = "Ícaro e Gilmar", Gender = "Sertanejo", Image = "./assets/images/artista-icaro-gilmar.jpg" },
            new Artist { Name = "Panda", Gender = "Sertanejo", Image = "./assets/images/artista-panda.jpg" },
            new Artist { Name = "MC Ig", Gender = "Funk", Image = "./assets/images/artista-mc-ig.jpg" }
        };
        _context.Artists.AddRange(artists);

        var albums = new List<Album>
        {
            new Album { Name = "O Cé Explica Tudo (Ao Vivo)", Artist = "Henrique & Juliano", Image = "./assets/images/album-ceu-explica.jpg" },
            new Album { Name = "Nada como um dia após o outro", Artist = "Racionais", Image = "./assets/images/album-vida-loka.jpg" },
            new Album { Name = "Cê Tá Doido (Ao Vivo)", Artist = "Panda - Humberto & Ronaldo - Ícaro e Gilmar", Image = "./assets/images/album-ce-ta-doido.jpg" },
            new Album { Name = "Caju", Artist = "Liniker", Image = "./assets/images/album-caju.jpg" },
            new Album { Name = "Feliz no simples", Artist = "MC Ig", Image = "./assets/images/album-feliz-no-simples.jpg" }
        };
        _context.Albums.AddRange(albums);

        var trendingSongs = new List<Song>
        {
            new Song { Name = "Tá rico os menino do gueto", Artist = "MC Ig", Image = "./assets/images/music-ta-rico.jpg" },
            new Song { Name = "Amando, Bebendo e Sofrendo", Artist = "Henrique & Juliano", Image = "./assets/images/album-ceu-explica.jpg" },
            new Song { Name = "Vida Loka (Parte 2)", Artist = "Racionais", Image = "./assets/images/album-vida-loka.jpg" },
            new Song { Name = "Intimidade", Artist = "Liniker", Image = "./assets/images/album-caju.jpg" },
            new Song { Name = "Baqueado", Artist = "Panda", Image = "./assets/images/music-baqueado.jpg" }
        };
        _context.Songs.AddRange(trendingSongs);

        var highlightStop = new List<Song>
        {
            new Song { Name = "Mundo: seu relatório semanal das faixas mais tocadas no momento.", Artist = "Top músicas – Mundo", Image = "./assets/images/top-musicas-mundo.jpg" },
            new Song { Name = "Brasil: seu relatório semanal das faixas mais tocadas no momento.", Artist = "Top músicas – Brasil", Image = "./assets/images/top-musicas-brasil.jpg" },
            new Song { Name = "Mundo: seu relatório diário das faixas mais tocadas no momento.", Artist = "Top 50 - Mundo", Image = "./assets/images/top-50.jpg" },
            new Song { Name = "Brasil: seu relatório diário das faixas mais tocadas no momento.", Artist = "Top 50 - Brasil", Image = "./assets/images/top-50-brasil.jpg" },
            new Song { Name = "Mundo: seu relatório diário das faixas que viralizaram.", Artist = "Mundo", Image = "./assets/images/viral-50.jpg" }
        };
        _context.Songs.AddRange(highlightStop);

        var sweetDreams = new List<Song>
        {
            new Song { Name = "A trilha perfeita pra embalar seu sono / Música perfecta para dormir", Artist = "...", Image = "./assets/images/hora-dormir.jpg" },
            new Song { Name = "Uma chuva calma e tranquila para te fazer companhia.", Artist = "...", Image = "./assets/images/chuva-leve.jpg" },
            new Song { Name = "Buscando um sono profundo? Essa playlist te ajuda a dormir melhor.", Artist = "...", Image = "./assets/images/sono-profundo.jpg" },
            new Song { Name = "Os maiores hits do pop em versão acústica para ninar. ", Artist = "...", Image = "./assets/images/pop-dormir.jpg" },
            new Song { Name = "Adormecer ao som relaxante da chuva.", Artist = "...", Image = "./assets/images/chuva-dormir.jpg" }
        };
        _context.Songs.AddRange(sweetDreams);

        var genres = new List<Genre>
        {
            new Genre { Name = "Sertanejo", Percentage = 60 },
            new Genre { Name = "Funk", Percentage = 25 },
            new Genre { Name = "Rap", Percentage = 10 },
            new Genre { Name = "MPB", Percentage = 3 },
            new Genre { Name = "Pop", Percentage = 2 }
        };
        _context.Genres.AddRange(genres);

        var topArtists = new List<TopArtist>
        {
            new TopArtist { Name = "Henrique & Juliano", Plays = 150 },
            new TopArtist { Name = "MC Ig", Plays = 120 },
            new TopArtist { Name = "Panda", Plays = 95 },
            new TopArtist { Name = "Ícaro e Gilmar", Plays = 75 },
            new TopArtist { Name = "Zé Neto & Cristiano", Plays = 65 }
        };
        _context.TopArtists.AddRange(topArtists);

        var discoveries = new List<Discovery>
        {
            new Discovery { Name = "Liniker", Days = 5 },
            new Discovery { Name = "Racionais", Days = 12 },
            new Discovery { Name = "Humberto & Ronaldo", Days = 20 }
        };
        _context.Discoveries.AddRange(discoveries);

        var listeningStats = new ListeningStats
        {
            Daily = "2.5 horas",
            Weekly = "18 horas",
            Monthly = "76 horas"
        };
        _context.ListeningStats.Add(listeningStats);

        await _context.SaveChangesAsync();
    }
}