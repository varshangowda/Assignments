using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


//namespace MVC_Codebased_test1_b.Model
//{


//public class MoviesDbContext : DbContext
//{
//    public DbSet<Movie> Movies { get; set; }


public class MoviesDbContext 
    {
    public object Movies { get; internal set; }

    //public  Movies { get; set; }
    }
