using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlayNews.Aplicacao.Detonado;

namespace mrg_game_news.Controllers
{
    public class DetonadoController : Controller
    {
        private readonly IMediator mediator;

        public DetonadoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public List<ConsultaDetonadoResultado> BuscarDetonados(ConsultaDetonado consulta)
        {
            return this.mediator.Send(consulta).Result;
        }
    }
}
