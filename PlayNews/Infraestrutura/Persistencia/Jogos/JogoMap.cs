using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayNews.Dominio.Jogos;
using System.Reflection.Emit;
using PlayNews.Dominio.Categorias;

namespace PlayNews.Dominio.Noticias
{
    public class JogoMap : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.Property(p => p.Id);

            builder.Property(p => p.Nome);

            builder.Property(p => p.Ano);

            builder
            .HasMany(a => a.Categorias)
            .WithMany(d => d.Jogos)
            .UsingEntity<Dictionary<string, object>>(
                "AlunoDisciplina",
                j => j.HasOne<Categoria>().WithMany().HasForeignKey("Id"),
                j => j.HasOne<Jogo>().WithMany().HasForeignKey("Id")
            );
        }
    }
}