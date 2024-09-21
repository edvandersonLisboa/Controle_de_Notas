using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PagadorDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public IList<NotaFiscalDTO> Notafiscais { get; set; } = [];

        public static implicit operator PagadorDTO(PagadorEntity entity)
        {
            if (entity == null)
            {
                return null;
            }

            var dto = new PagadorEntity
            {
                Id = entity.Id,
                Name = entity.Name,


            };

            foreach (var item in entity.Notafiscais)
            {
                dto.Notafiscais.Add(item);
            }

            return dto;
        }
    }
}
