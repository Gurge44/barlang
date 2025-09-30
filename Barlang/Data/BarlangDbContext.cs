﻿using Microsoft.EntityFrameworkCore;

namespace Barlang.Data
{
    public class BarlangDbContext : DbContext
    {
        public BarlangDbContext(DbContextOptions<BarlangDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Barlang> Barlangok { get; set; }
    }
}
