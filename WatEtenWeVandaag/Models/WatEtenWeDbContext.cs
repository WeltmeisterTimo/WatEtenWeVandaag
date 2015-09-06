using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WatEtenWeVandaag.Models
{
    public class WatEtenWeDbContext: DbContext
    {
        public DbSet<Ingredient> Ingredienten { get; set; }
    }
}