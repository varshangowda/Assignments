using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace new_crud.Models
{
    public class moviecontext:DbContext
    {
       public DbSet<movie> mov { get; set; }
    }
}