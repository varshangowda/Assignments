using MVC_Codebased_test1_b.Model;
using MVC_Codebased_test1_b.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DbContext = System.Data.Entity.DbContext;

namespace MVC_Codebased_test1_b { 
//{
//    public class movies
//    {
//    }
//}

public class MoviesDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal object Entry(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
