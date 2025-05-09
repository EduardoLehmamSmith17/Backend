-- Artistas
INSERT INTO Artists (Name, Gender, Image) VALUES
('Henrique & Juliano', 'Sertanejo', './assets/images/artista-henrique-juliano.jpg'),
('Zé Neto & Cristiano', 'Sertanejo', './assets/images/artista-ze-neto.jpg'),
('Ícaro e Gilmar', 'Sertanejo', './assets/images/artista-icaro-gilmar.jpg'),
('Panda', 'Sertanejo', './assets/images/artista-panda.jpg'),
('MC Ig', 'Funk', './assets/images/artista-mc-ig.jpg');

-- Albuns
INSERT INTO Albums (Name, Artist, Image) VALUES
('O Cé Explica Tudo (Ao Vivo)', 'Henrique & Juliano', './assets/images/album-ceu-explica.jpg'),
('Nada como um dia após o outro', 'Racionais', './assets/images/album-vida-loka.jpg'),
('Cê Tá Doido (Ao Vivo)', 'Panda - Humberto & Ronaldo - Ícaro e Gilmar', './assets/images/album-ce-ta-doido.jpg'),
('Caju', 'Liniker', './assets/images/album-caju.jpg'),
('Feliz no simples', 'MC Ig', './assets/images/album-feliz-no-simples.jpg');

-- Songs (trending + highlights + sleep)
INSERT INTO Songs (Name, Artist, Image) VALUES
-- Trending
('Tá rico os menino do gueto', 'MC Ig', './assets/images/music-ta-rico.jpg'),
('Amando, Bebendo e Sofrendo', 'Henrique & Juliano', './assets/images/album-ceu-explica.jpg'),
('Vida Loka (Parte 2)', 'Racionais', './assets/images/album-vida-loka.jpg'),
('Intimidade', 'Liniker', './assets/images/album-caju.jpg'),
('Baqueado', 'Panda', './assets/images/music-baqueado.jpg'),

-- Highlights
('Mundo: seu relatório semanal das faixas mais tocadas no momento.', 'Top músicas – Mundo', './assets/images/top-musicas-mundo.jpg'),
('Brasil: seu relatório semanal das faixas mais tocadas no momento.', 'Top músicas – Brasil', './assets/images/top-musicas-brasil.jpg'),
('Mundo: seu relatório diário das faixas mais tocadas no momento.', 'Top 50 - Mundo', './assets/images/top-50.jpg'),
('Brasil: seu relatório diário das faixas mais tocadas no momento.', 'Top 50 - Brasil', './assets/images/top-50-brasil.jpg'),
('Mundo: seu relatório diário das faixas que viralizaram.', 'Mundo', './assets/images/viral-50.jpg'),

-- Sweet Dreams
('A trilha perfeita pra embalar seu sono / Música perfecta para dormir', '...', './assets/images/hora-dormir.jpg'),
('Uma chuva calma e tranquila para te fazer companhia.', '...', './assets/images/chuva-leve.jpg'),
('Buscando um sono profundo? Essa playlist te ajuda a dormir melhor.', '...', './assets/images/sono-profundo.jpg'),
('Os maiores hits do pop em versão acústica para ninar. ', '...', './assets/images/pop-dormir.jpg'),
('Adormecer ao som relaxante da chuva.', '...', './assets/images/chuva-dormir.jpg');

-- Genres
INSERT INTO Genres (Name, Percentage) VALUES
('Sertanejo', 60),
('Funk', 25),
('Rap', 10),
('MPB', 3),
('Pop', 2);

-- TopArtists
INSERT INTO TopArtists (Name, Plays) VALUES
('Henrique & Juliano', 150),
('MC Ig', 120),
('Panda', 95),
('Ícaro e Gilmar', 75),
('Zé Neto & Cristiano', 65);

-- Discoveries
INSERT INTO Discoveries (Name, Days) VALUES
('Liniker', 5),
('Racionais', 12),
('Humberto & Ronaldo', 20);

-- ListeningStats
INSERT INTO ListeningStats (Daily, Weekly, Monthly) VALUES
('2.5 horas', '18 horas', '76 horas');
