using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIntro
{
    public class Building
    {
        public City City { get; set; }
        public string Address { get; set; }
        public int Stories { get; set; }
        public string Name { get; set; }
    }
}