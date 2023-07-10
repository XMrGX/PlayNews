using AutoMapper;
using MediatR;
using MrgGameNews;
using PlayNews.Aplicacao.Jogo;
using PlayNews.Aplicacao.Noticia;
using PlayNews.Dominio.Jogos;
using PlayNews.Dominio.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNews.Infraestrutura.Persistencia.Jogos
{
    public class ExecutorConsultaJogo : IRequestHandler<ConsultaJogo, List<ConsultaJogoResultado>>
    {
        private readonly PlayNewsContext dbContext;
        private readonly IMapper mapper;
        public ExecutorConsultaJogo(PlayNewsContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public Task<List<ConsultaJogoResultado>> Handle(ConsultaJogo request, CancellationToken cancellationToken)
        {
            var noticias = this.mapper.Map<List<ConsultaJogoResultado>>(this.dbContext.Set<Jogo>().ToList());
            return Task.FromResult(noticias);
        }
    }
}