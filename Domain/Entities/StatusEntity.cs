using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StatusEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //conversão inplicita de StatuDTO para StatuEntity
        public static implicit operator StatusEntity(StatusDTO dto)
        {
            if (dto == null)
            {
                return null;
            }
            var entity = new StatusEntity
            {
                Id = dto.Id,
                Name = dto.Name,
            };

            return entity;
        }
    }
}
