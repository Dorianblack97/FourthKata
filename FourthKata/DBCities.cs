using System;
using System.Collections.Generic;
using System.Text;

namespace FourthKata
{
    public class DBCities
    {
        public List<string> CitiesList { get; }
        public DBCities()
        {
            CitiesList = new List<string> { "Paris", "Budapest", "Skopje", "Rotterdam", 
                "Valencia", "Vancouver", "Amsterdam", "Vienna", "Sydney",
                "New York City", "London", "Bangkok", "Hong Kong", "Dubai", 
                "Rome", "Istanbul"};
        }
    }
}
