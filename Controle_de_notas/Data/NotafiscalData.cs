using Domain.DTOs;
using Domain.Entities;

namespace Controle_de_notas.Data
{
    public class NotafiscalData
    {
        public int Id { get; set; }
        public string NomeDoPagador { get; set; } = string.Empty;
        public string NumeroIdentificacao { get; set; } = string.Empty;
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public DateTime? DataCobranca { get; set; } 
        public decimal Valor { get; set; }
        public DocumentoDTO? Boleto { get; set; }
        public DocumentoDTO? NotaFiscal { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; } = string.Empty;

        //conversão inplicita de NotaFiscalEntity para NotaFiscalDTO
      


    }
}
