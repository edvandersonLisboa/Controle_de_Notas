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
    public class DocumentoRepository : Repository<DocumentoEntity>, IRepository<DocumentoEntity>
    {
        public DocumentoRepository(AppSqlLiteContext context) : base(context)
        {
        }
    }
}
