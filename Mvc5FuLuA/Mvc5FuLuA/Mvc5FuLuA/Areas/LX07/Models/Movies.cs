using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Collections.Generic;

namespace Mvc5FuLuA.Areas.LX07.Models
{
    public class Movies : DbContext
    {
        public Movies()
            : base("name=Movies")
        {
        }
        public virtual DbSet<Movie> Movie { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(e => e.ID)
                .IsFixedLength();
        }
    }

    public class MoviesInit : DropCreateDatabaseIfModelChanges<Movies>
    {
        protected override void Seed(Movies context)
        {
            var t1 = new List<Movie>
            {
                new Movie{ ID="001", MovieType="动作", MovieName="第1滴血"},
                new Movie{ ID="002", MovieType="科幻", MovieName="星际迷航"},
                new Movie{ ID="003", MovieType="爱情", MovieName="北京爱情故事"},
                new Movie{ ID="004", MovieType="武侠", MovieName="南海保镖"}
            };
            t1.ForEach(v => context.Movie.Add(v));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}