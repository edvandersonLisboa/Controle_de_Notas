using Data.Context;
using Data.Repositories.Base;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class NotaFiscalRepository : Repository<NotaFiscalEntity>, INotaFiscalRepository
    {
        public NotaFiscalRepository(AppSqlLiteContext context) : base(context)
        {
        }

        public override async Task<List<NotaFiscalEntity>> GetAllLisAsync()
        {
            try
            {
                var result = await DbSet.Include(p => p.Documentos).Include(p => p.Status).Include(p => p.Pagador).ToListAsync();
                return result;
            }
            catch(Exception ex)
            {
                throw new  Exception(ex.Message);
            }
          


           
        }
    }
 
}
