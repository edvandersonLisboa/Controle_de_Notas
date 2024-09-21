using Application.Queries.Base;
using Domain.DTOs;
using Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Queries.GetAllNotaFiscalQueries
{
    public class GetAllNotaFiscalQueryResult : QueryResultBase
    {

        public GetAllNotaFiscalQueryResult() { }
        public GetAllNotaFiscalQueryResult(IEnumerable<Error> errors) : base(errors) { }
        public List<NotaFiscalDTO> NotaFiscals { get; set; } = [];


    }
}
