using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailsM.Models
{
    class Cocktail : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double AlcoholPercentage { get; set; }
        public int CategoryId { get; set; }
        public int GlassId { get; set; }
    }
}
