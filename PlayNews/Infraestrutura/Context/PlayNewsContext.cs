using Microsoft.EntityFrameworkCore;
using PlayNews.Dominio.Jogos;
using PlayNews.Dominio.Noticias;
using PlayNews.Dominio.Usuarios;

namespace MrgGameNews
{
    public class PlayNewsContext : DbContext
    {
        public PlayNewsContext(DbContextOptions<PlayNewsContext> options)
        : base(options)
        {
        }

        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
