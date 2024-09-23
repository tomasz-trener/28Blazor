﻿using Microsoft.EntityFrameworkCore;
using Shop.Shared.Models;

namespace Shop.API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


    }
}
