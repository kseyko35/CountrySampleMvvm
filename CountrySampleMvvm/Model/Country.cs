using System;
using System.Collections.Generic;

namespace CountrySampleMvvm.Model
{
    public class Country
    {
        public string cName { get; set; }
        public string cImgUrl { get; set; }
        public string cDescription{ get; set; }
        public string cLocation { get; set; } 
        public IList<City> cCity { get; set; }


    }
}
