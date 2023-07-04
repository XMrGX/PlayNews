using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PlayNews.Aplicacao.Detonado
{
    public class ExecutorComandoCriarDetonado : IRequestHandler<ComandoCriarDetonado, ComandoCriarDetonadoResultado>
    {
        Task<ComandoCriarDetonadoResultado> IRequestHandler<ComandoCriarDetonado, ComandoCriarDetonadoResultado>.Handle(ComandoCriarDetonado request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new ComandoCriarDetonadoResultado());
        }
    }
}
