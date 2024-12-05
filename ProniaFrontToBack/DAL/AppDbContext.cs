﻿using Microsoft.EntityFrameworkCore;
using ProniaFrontToBack.Models;

namespace ProniaFrontToBack.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<TagProduct> TagProducts { get; set; }
 
    }
}
