using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlayNews.Aplicacao.Noticia;

namespace mrg_game_news.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly IMediator mediator;

        public NoticiaController(IMediator mediator) 
        {
            this.mediator = mediator;
        }

        public List<ConsultaNoticiaResultado> BuscarNoticias(ConsultaNoticia consulta)
        {
            return this.mediator.Send(consulta).Result;
        }
    }
}
