﻿using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailsM.Models
{
    class Glasses : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
