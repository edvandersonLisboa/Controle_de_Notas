using Applications.Services;
using Applications.Services.Interfaces;
using Controle_de_notas.Data;
using Domain.DTOs;

namespace Controle_de_notas.Controller
{
    public class NotaFiscalController
    {

        private readonly INotaFiscalService _notaFiscalService;

        public NotaFiscalController(INotaFiscalService notaFiscalService)
        {
            _notaFiscalService = notaFiscalService;
        }


        public  async  Task<IEnumerable<NotafiscalData>> GetAllNotafiscal()
        {

            var notafiscalDTO = await _notaFiscalService.GetAll();
            var notafiscalData = new List<NotafiscalData>();
            foreach (var item in notafiscalDTO)
            {

                var nota = new NotafiscalData
                {
                    Id = item.Id,
                    NomeDoPagador = item.Pagador.Name,
                    NumeroIdentificacao = item.NumeroIdentificacao,
                    DataEmissao =item.DataDeEmissao,
                    DataPagamento = item.DataDePagamento,
                    DataCobranca = item.DataCobranca,
                    Valor = item.Valor,
                    StatusId = item.StatusId,
                    Status = item.Status.Name,
                };
                nota.Boleto = item.Documentos.FirstOrDefault(p => p.TipoId == 1);
                nota.NotaFiscal = item.Documentos.FirstOrDefault(p => p.TipoId == 2);
                    

                notafiscalData.Add(nota);
            }
              

            return notafiscalData;
        }
    }
}
