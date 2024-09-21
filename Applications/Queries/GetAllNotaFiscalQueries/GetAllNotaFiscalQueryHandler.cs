using Applications.Services.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Shared.Handles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Queries.GetAllNotaFiscalQueries
{
    public class GetAllNotaFiscalQueryHandler  : IQueryHandler<GetAllNotaFiscalQuery, GetAllNotaFiscalQueryResult>
    {
        private readonly INotaFiscalRepository _INotafiscalRepository;

        public GetAllNotaFiscalQueryHandler(INotaFiscalRepository notafiscalRepository) 
        {
            _INotafiscalRepository = notafiscalRepository;
        }

        public async Task<GetAllNotaFiscalQueryResult> HandleAsync(GetAllNotaFiscalQuery command)
        {

            var notas = await _INotafiscalRepository.GetAllLisAsync();
            var result = new GetAllNotaFiscalQueryResult();
            foreach (var item in notas) {
                var nota = new NotaFiscalDTO();
                nota =  new NotaFiscalDTO
                {
                    Id = item.Id,
                    DataCobranca = item.DataCobranca,
                    DataDeEmissao = item.DataDeEmissao,
                    DataDePagamento = item.DataDePagamento,
                    NumeroIdentificacao = item.NumeroIdentificacao,
                    StatusId = item.StatusId,
                    Valor = item.Valor,
                   PagadorId = item.PagadorId,
                   Pagador = new PagadorDTO
                   {
                       Id = item.PagadorId,
                       Name = item.Pagador?.Name,
                   },
                    Status = new StatusDTO
                    {
                        Id = item.StatusId,
                        Name = item.Status?.Name,
                    },


                };
                var doc = new List<DocumentoDTO>();

                foreach (var item1 in item.Documentos)
                {
                    nota.Documentos.Add(new DocumentoDTO
                    {
                        Id = item1.Id,
                        base64 = item1.base64,
                        Nome = item1.Nome,
                        extensao = item1.extensao
                    });
                }
                result.NotaFiscals.Add(nota);


            }

            return result;
        }
    }
}
