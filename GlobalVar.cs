using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library
{
    public static class GlobalVar
    {
        public static Dictionary<int, string> BookTitles = new Dictionary<int, string>() {
                                                                {1,"Moby Dick.txt"},
                                                                {2,"A Tale Of Two Cities.txt"},
                                                                {3,"The Hound Of The Baskervilles.txt"}
                                                                };
        
    }
}