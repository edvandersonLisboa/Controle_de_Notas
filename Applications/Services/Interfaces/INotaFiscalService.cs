using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services.Interfaces
{
    public interface INotaFiscalService
    {
        public Task<List<NotaFiscalDTO>> GetAll();
    }
}
