using Applications.Commands.Base;
using Domain.DTOs;
using Domain.Interfaces;
using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Commands.NotaFiscalCommands.CreateNotaFiscalCommands
{
    public class CreateNotaFiscalCommandHandler (INotaFiscalRepository _INotaFiscalRepository): CommandHandlerBase<CreateNotaFiscalCommand, NotaFiscalDTO>
    {
        public override async Task<ICommandResult<NotaFiscalDTO>> HandleAsync(CreateNotaFiscalCommand command)
        {
            //var notaFiscal = await _no
            throw new NotImplementedException();
        }
    }
}
