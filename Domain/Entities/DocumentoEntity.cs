using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DocumentoEntity
    {
        public int Id { get; set; }
        public int NotaFiscalId { get; set; }
        public NotaFiscalEntity? NotaFiscal { get; set; }
        public string? Nome { get; set; }
        public string? extensao { get; set; }
        public string? base64 { get; set; }
        public int TipoId { get; set; }
        public TipoDocumentoEntity? Tipo { get; set; }

        //conversão inplicita de DocumentoDTO para DocumentoEntity
        public static implicit operator DocumentoEntity(DocumentoDTO dto)
        {
            if (dto == null)
            {
                return null;
            }

            var entity = new DocumentoEntity
            {
                Id = dto.Id,
                NotaFiscalId = dto.NotaFiscalId,
                NotaFiscal = dto.NotaFiscal == null ? null : dto.NotaFiscal,
                Nome = dto.Nome,
                extensao = dto.extensao,
                base64 = dto.base64,
                TipoId = dto.TipoId,
                Tipo = dto.Tipo == null ? null : dto.Tipo,

            };

            return entity;
        }
    }
}
