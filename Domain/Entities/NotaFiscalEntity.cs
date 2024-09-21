
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NotaFiscalEntity
    {
        public int Id { get; set; }
        public int PagadorId { get; set; }
        public PagadorEntity? Pagador { get; set; }
        public string NumeroIdentificacao { get; set; } = string.Empty;
        public DateTime? DataDeEmissao { get; set; }
        public DateTime?  DataDePagamento { get; set; }
        public DateTime? DataCobranca { get; set; }
        public decimal Valor { get; set; }
        public List<DocumentoEntity>?    Documentos { get; set; } = [];

        public int StatusId { get; set; }
        public StatusEntity? Status { get; set; }

        //conversão inplicita de NotaFiscalDTO para NotaFiscalEntity
        public static implicit operator NotaFiscalEntity(NotaFiscalDTO dto)
        {
            if (dto == null)
            {
                return null;
            }

            var entity = new NotaFiscalEntity
            {
                Id = dto.Id,
                Pagador = dto.Pagador,
                NumeroIdentificacao = dto.NumeroIdentificacao,
                DataDeEmissao = dto.DataDeEmissao,
                DataCobranca = dto.DataCobranca,
                DataDePagamento = dto.DataDePagamento,
                Valor = dto.Valor,
                StatusId = dto.StatusId,
                Status = dto.Status,

            };
            foreach (var item in dto.Documentos)
            {
                entity.Documentos.Add(item);
            }
            return entity;
        }


    }
}
