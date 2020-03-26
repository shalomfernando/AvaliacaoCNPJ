using AvaliacaoCNPJ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoCNPJ.Data
{
    public class CnpjWebMvcContext : DbContext
    {
        public CnpjWebMvcContext(DbContextOptions<CnpjWebMvcContext> options)
           : base(options)
        {
        }
        public DbSet<ApiObjeto> ApiObjeto { get; set; }
        public DbSet<Atividade_principal> Atividade_principal { get; set; }
        public DbSet<Atividades_secundarias> Atividades_secundarias { get; set; }
        public DbSet<Billing> Billing { get; set; }
        public DbSet<Qsa> Qsa { get; set; }

    }
}
