using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Webapi_Praxio.Models
{
    public class NotaFiscal :DbContext
    {
        public NotaFiscal(DbContextOptions<NotaFiscal> options)
            : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
