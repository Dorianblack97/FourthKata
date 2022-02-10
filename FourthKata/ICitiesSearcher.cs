using System;
using System.Collections.Generic;
using System.Text;

namespace FourthKata
{
    public interface ICitiesSearcher
    {
        List<string> SearchCity(string search);        
    }
}
