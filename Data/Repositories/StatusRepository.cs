using Data.Context;
using Data.Repositories.Base;
using Domain.Entities;
using Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class StatusRepository : Repository<StatusEntity>, IRepository<StatusEntity>
    {
        public StatusRepository(AppSqlLiteContext context) : base(context)
        {
        }
    }
}
