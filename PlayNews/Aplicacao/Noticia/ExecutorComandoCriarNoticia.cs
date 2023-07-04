using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PlayNews.Aplicacao.Noticia
{
    public class ExecutorComandoCriarNoticia : IRequestHandler<ComandoCriarNoticia, ComandoCriarNoticiaResultado>
    {
        Task<ComandoCriarNoticiaResultado> IRequestHandler<ComandoCriarNoticia, ComandoCriarNoticiaResultado>.Handle(ComandoCriarNoticia request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new ComandoCriarNoticiaResultado());
        }
    }
}
