using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FourthKata
{
    public class CitiesSearcher : ICitiesSearcher
    {
        public List<string> CityList { get; set; }
        public CitiesSearcher(DBCities db)
        {            
            CityList = db.CitiesList;
        }
        public List<string> SearchCity(string search)
        {
            if(search == "*" ) return CityList;
            if(search.Length < 2) return new List<string>();
            return CityList.Where(x => x.ToUpperInvariant().Contains(search.ToUpperInvariant())).ToList();            
        }
    }
}
