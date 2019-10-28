using System;
using System.Collections.Generic;
using System.Text;
using OdeToFood.core;

namespace odeTToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll(); 
    }
}
