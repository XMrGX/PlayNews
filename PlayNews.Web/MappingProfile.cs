using AutoMapper;
using PlayNews.Aplicacao.Noticia;
using PlayNews.Dominio.Noticias;

namespace mrg_game_news
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Noticia, ConsultaNoticiaResultado>();
            CreateMap<ConsultaNoticiaResultado, Noticia>()
                .ForMember(dest => dest.DataPublicacao, opt => opt.MapFrom(src => src.DataPublicacao.ToLocalTime()))
                .ForPath(dest => dest.Jogo.Nome, opt => opt.MapFrom(src => src.NomeJogo))
                .ForPath(dest => dest.Usuario.Nome, opt => opt.MapFrom(src => src.NomeUsuario))
            .ReverseMap(); ;
        }
    }
}
