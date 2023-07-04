using PlayNews.Dominio.Jogos;
using PlayNews.Dominio.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNews.Dominio.Detonados
{
    public class Detonado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public bool Manchete { get; set; }
        public bool Ativo { get; set; }
        public string Corpo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public Jogo Jogo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
