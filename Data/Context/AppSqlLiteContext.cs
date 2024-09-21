using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AppSqlLiteContext : DbContext
    {
        public DbSet<NotaFiscalEntity> NotaFiscais { get; set; }
        public DbSet<DocumentoEntity> Documentos { get; set; }
        public DbSet<StatusEntity> Status { get; set; }
        public DbSet<TipoDocumentoEntity> TipoDocumentos { get; set; }
        public DbSet<PagadorEntity> Pagadores { get; set; }


        public AppSqlLiteContext(DbContextOptions<AppSqlLiteContext> options)
      : base(options)
        {

        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
