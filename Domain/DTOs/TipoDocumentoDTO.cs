
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class TipoDocumentoDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;

        //conversão inplicita de TipoDocumentoEntity para TipoDocumentoDTO
        public static implicit operator TipoDocumentoDTO(TipoDocumentoEntity entity)
        {
            if (entity == null)
            {
                return null;
            }
            var dto = new TipoDocumentoDTO
            {
                Id = entity.Id,
                Descricao = entity.Descricao,
            };

            return dto;
        }
    }
}
