using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trommeregaard.API.Models;

namespace Trommeregaard.API.Data
{
    public class TrommeregaardAPIContext : DbContext
    {
        public TrommeregaardAPIContext (DbContextOptions<TrommeregaardAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Trommeregaard.API.Models.Cow> Cow { get; set; } = default!;
    }
}
