using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailsM.Models
{
   public class User : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Email { get; set; }

    }
}
