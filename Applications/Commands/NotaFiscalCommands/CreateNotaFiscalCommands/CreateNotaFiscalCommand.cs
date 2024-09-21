using Domain.Entities;
using Flunt.Notifications;
using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Commands.NotaFiscalCommands.CreateNotaFiscalCommands
{
    public class CreateNotaFiscalCommand : Notifiable<Notification>, ICommand
    {

        public int Id { get; set; }
        public string NomeDoPagador { get; set; } = string.Empty;
        public string NumeroIdentificacao { get; set; } = string.Empty;
        public DateTime DataDeEmissao { get; set; }
        public DateTime DataDePagamento { get; set; }
        public decimal Valor { get; set; }
        public IEnumerable<DocumentoEntity>? Documentos { get; set; } = [];
        public int StatusId { get; set; }
        public StatusEntity? Status { get; set; }
        public void Validade()
        {
            throw new NotImplementedException();
        }
    }
}
