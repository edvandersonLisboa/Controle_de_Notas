using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class NotaFiscalDTO
    {
        public int Id { get; set; }
        public int PagadorId { get; set; }
        public PagadorDTO? Pagador { get; set; }
        public string NumeroIdentificacao { get; set; } = string.Empty;
        public DateTime? DataDeEmissao { get; set; }
        public DateTime? DataDePagamento { get; set; }
        public DateTime? DataCobranca { get; set; }
        public decimal Valor { get; set; }

        public List<DocumentoDTO>? Documentos { get; set; } = [];

        public int StatusId { get; set; }
        public StatusDTO? Status { get; set; }

        //conversão inplicita de NotaFiscalEntity para NotaFiscalDTO
        public static implicit operator NotaFiscalDTO(NotaFiscalEntity entity)
        {
            if (entity == null)
            {
                return null;
            }

            var dto = new NotaFiscalDTO
            {
                Id = entity.Id,
                Pagador = entity.Pagador,
                NumeroIdentificacao = entity.NumeroIdentificacao,
                DataDeEmissao = entity.DataDeEmissao,
                DataDePagamento = entity.DataDePagamento,
                DataCobranca = entity.DataCobranca,
                Valor = entity.Valor,
                StatusId = entity.StatusId,
                Status = entity.Status,
                
            };
            foreach (var item in entity.Documentos)
            {
                dto.Documentos.Add(item);
            }

            return dto;
        }
    }
}
