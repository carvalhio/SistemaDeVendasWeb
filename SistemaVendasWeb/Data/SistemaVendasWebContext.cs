﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaVendasWeb.Models
{
    public class SistemaVendasWebContext : DbContext
    {
        public SistemaVendasWebContext (DbContextOptions<SistemaVendasWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet <Seller> Seller { get; set; }
        public DbSet <SalesRecord> SalesRecord { get; set; }
    }
}
