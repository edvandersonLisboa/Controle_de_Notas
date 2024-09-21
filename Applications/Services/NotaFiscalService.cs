using Applications.Queries.GetAllNotaFiscalQueries;
using Applications.Services.Interfaces;
using Domain.DTOs;
using Domain.Interfaces;
using Shared.Handles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public class NotaFiscalService : INotaFiscalService
    {
        private readonly IQueryHandler<GetAllNotaFiscalQuery, GetAllNotaFiscalQueryResult> _GetAllNotaFicalQueryHandler;

        public NotaFiscalService(IQueryHandler<GetAllNotaFiscalQuery, GetAllNotaFiscalQueryResult> getAllNotaFicalQueryHandler)
        {
            _GetAllNotaFicalQueryHandler = getAllNotaFicalQueryHandler;
        }

        public async Task<List<NotaFiscalDTO>> GetAll()
        {
            var result =await  _GetAllNotaFicalQueryHandler.HandleAsync(new GetAllNotaFiscalQuery());
            return result.NotaFiscals;
        }
    }
}
