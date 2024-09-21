using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoDocumentoEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;

        //conversão inplicita de TipoDocumentoDTO para TipoDocumentoEntity
        public static implicit operator TipoDocumentoEntity(TipoDocumentoDTO dto)
        {
            if (dto == null)
            {
                return null;
            }
            var entity = new TipoDocumentoDTO
            {
                Id = dto.Id,
                Descricao = dto.Descricao,
            };

            return entity;
        }
    }
}
