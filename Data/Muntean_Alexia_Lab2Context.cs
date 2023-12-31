﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muntean_Alexia_Lab2.Models;

namespace Muntean_Alexia_Lab2.Data
{
    public class Muntean_Alexia_Lab2Context : DbContext
    {
        public Muntean_Alexia_Lab2Context (DbContextOptions<Muntean_Alexia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Muntean_Alexia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Muntean_Alexia_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Muntean_Alexia_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Muntean_Alexia_Lab2.Models.Author>? Author { get; set; }
    }
}
