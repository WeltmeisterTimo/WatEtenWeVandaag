using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatEtenWeVandaag.Models
{
    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int CategorieID { get; set; }
    }
}