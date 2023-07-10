using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlayNews.Aplicacao.Noticia;

namespace mrg_game_news.Controllers
{
    public class AnaliseController : Controller
    {
        private readonly IMediator mediator;

        public AnaliseController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public List<ConsultaAnaliseResultado> BuscarAnalises(ConsultaAnalise consulta)
        {
            return this.mediator.Send(consulta).Result;
        }
    }
}