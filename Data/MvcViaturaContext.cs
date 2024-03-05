using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcViatura.Models;

namespace MvcViatura.Data
{
    public class MvcViaturaContext : DbContext
    {
        public MvcViaturaContext (DbContextOptions<MvcViaturaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcViatura.Models.Viatura> Viatura { get; set; } = default!;
        public DbSet<MvcViatura.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<MvcViatura.Models.Funcionario> Funcionario { get; set; } = default!;
    }
}
