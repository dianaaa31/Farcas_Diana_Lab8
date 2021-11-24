using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Farcas_Diana_Lab8.Models;

namespace Farcas_Diana_Lab8.Data
{
    public class Farcas_Diana_Lab8Context : DbContext
    {
        public Farcas_Diana_Lab8Context (DbContextOptions<Farcas_Diana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Farcas_Diana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Farcas_Diana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Farcas_Diana_Lab8.Models.Category> Category { get; set; }
    }
}
