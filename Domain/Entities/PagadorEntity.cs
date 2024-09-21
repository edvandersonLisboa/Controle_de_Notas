using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PagadorEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<NotaFiscalEntity> Notafiscais { get; set; } = [];
        public static implicit operator PagadorEntity(PagadorDTO dto)
        {
            if (dto == null)
            {
                return null;
            }

            var entity = new PagadorEntity
            {
                Id = dto.Id,
                Name = dto.Name,
               

            };

            foreach(var item in dto.Notafiscais)
            {
                entity.Notafiscais.Add(item);
            }

            return entity;
        }
    }
}
