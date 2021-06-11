using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RelatoriosWeb.Models;

namespace RelatoriosWeb.Data
{
    public class RelatoriosWebContext : DbContext
    {
        public RelatoriosWebContext(DbContextOptions<RelatoriosWebContext> options)
            : base(options)
        {
        }
        
        public DbSet<RelatoriosWeb.Models.Painel> painel { get; set; }
        public DbSet<RelatoriosWeb.Models.Usuario> Usuario { get; set; }
        public DbSet<RelatoriosWeb.Models.Painel_Nfe> painel_nfe { get; set; }
        public DbSet<RelatoriosWeb.Models.Painel_Empresas> painel_empresas { get; set; }


    }
}
