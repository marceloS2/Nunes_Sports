using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nunes_Sports.Models;


namespace Nunes_Sports.Context
{
    public class ProdutoContext: DbContext
    {
      public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
      {

      }
      public DbSet<Produto> Produtos {get; set;}
    }
}