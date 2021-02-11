﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        //nereye bağlanacağı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-J3FG52P2;Database=Project;Trusted_Connection=true");
        }
        //veri tabanını projedeki classlarla bağla
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarColor> Colors { get; set; }
        public DbSet<CarBrand> Brands { get; set; }
    }
}