using System.Collections.Generic;

namespace LinqIntro
{
    public class City
    {
        public string Name { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();
    }
}