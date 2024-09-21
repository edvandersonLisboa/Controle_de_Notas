using Domain.DTOs;
using Domain.Entities;
using Flunt.Notifications;
using Shared.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Queries.GetAllNotaFiscalQueries
{
    public class GetAllNotaFiscalQuery : Notifiable<Notification>, IQueryRequest
    {
        //public int Id { get; set; }
        //public string NomeDoPagador { get; set; } = string.Empty;
        //public string NumeroIdentificacao { get; set; } = string.Empty;
        //public DateTime DataDeEmissao { get; set; }
        //public DateTime DataDePagamento { get; set; }
        //public decimal Valor { get; set; }
        //public IEnumerable<DocumentoDTO>? Documentos { get; set; } = [];
        //public int StatusId { get; set; }
        public void Valide()
        {
            throw new NotImplementedException();
        }
    }
}
