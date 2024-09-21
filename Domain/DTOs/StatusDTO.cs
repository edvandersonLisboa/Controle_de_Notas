using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class StatusDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //conversão inplicita de StatuEntity para StatuDTO
        public static implicit operator StatusDTO(StatusEntity entity)
        {
            if(entity == null)
            {
                return null;
            }

            var dto = new StatusDTO
            {
                Id = entity.Id,
                Name = entity.Name,
            };

            return dto;
        }
    }
}
