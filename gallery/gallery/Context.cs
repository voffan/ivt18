﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace gallery
{
    class Context : DbContext
    {
        public Context() : base("conStr") { }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Gallery> Galleries { get; set; }

        public DbSet<Journal> Journals { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Expo> Expos { get; set; }

        public DbSet<Place> Places { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
