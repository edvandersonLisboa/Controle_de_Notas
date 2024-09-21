
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class DocumentoDTO
    {
        public int Id { get; set; }
        public int NotaFiscalId { get; set; }
        public NotaFiscalDTO? NotaFiscal { get; set; }
        public string? Nome { get; set; }
        public string? extensao { get; set; }
        public string? base64 { get; set; }
        public int TipoId { get; set; }
        public TipoDocumentoDTO? Tipo { get; set; }


        // conversão inplicita de DocumentoEntity para DocumentoDTO
        public static implicit operator DocumentoDTO(DocumentoEntity Entity)
        {
            if (Entity == null)
            {
                return null;
            }

            var dto = new DocumentoDTO
            {
                Id = Entity.Id,
                NotaFiscalId = Entity.NotaFiscalId,
                NotaFiscal = Entity.NotaFiscal == null ? null : Entity.NotaFiscal,
                Nome  = Entity.Nome,
                extensao = Entity.extensao,
                base64 = Entity.base64,
                TipoId = Entity.TipoId,
                Tipo = Entity.Tipo == null ? null : Entity.Tipo,

            };

            return dto;
        }
    }
}
