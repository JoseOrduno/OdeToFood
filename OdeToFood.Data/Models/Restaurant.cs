﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        public string Name { get; set; }
        public CuisineType cuisine { get; set; }
    }


}
