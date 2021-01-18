﻿using Microsoft.EntityFrameworkCore;
using ProjetoWebMvc.Models;

namespace ProjetoWebMvc.Data
{
    public class ProjetoWebMvcContext : DbContext
    {
        public ProjetoWebMvcContext (DbContextOptions<ProjetoWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
