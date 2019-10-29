using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
            new Restaurant { id = 1, Name = "Tacos", cuisine = CuisineType.Mexican },
            new Restaurant { id = 1, Name = "Potato Rides", cuisine = CuisineType.French },
            new Restaurant { id = 1, Name = "Pizza", cuisine = CuisineType.Italian }
            };
        }
        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
