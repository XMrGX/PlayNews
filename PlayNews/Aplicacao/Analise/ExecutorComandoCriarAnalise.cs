using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PlayNews.Aplicacao.Noticia
{
    public class ExecutorComandoCriarAnalise : IRequestHandler<ComandoCriarAnalise, ComandoCriarAnaliseResultado>
    {
        Task<ComandoCriarAnaliseResultado> IRequestHandler<ComandoCriarAnalise, ComandoCriarAnaliseResultado>.Handle(ComandoCriarAnalise request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new ComandoCriarAnaliseResultado());
        }
    }
}
