using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                10,
                11,
                34,
                99,
                45,
                15,
                56
            };
            //Where (like Filter in JS)
            //we need a ToList because it doesn't retun a list... it returns an i inumerable. We use a list so we have to use a .ToList.
            List<int> numbersAbove50 = numbers.Where(num =>
            {
                return num > 50;
            }).ToList();

            //if there's any number like 15 /2 has a remainder of 1. So we know it's odd. So if we divide 10 by 2 then the remainder is 0.
            List<int> evenNumbers = numbers.Where(num =>
            {
                bool isEven = num % 2 == 0;
                //return a boolean with this statement
                return isEven;
            }).ToList();

            //Single line doesn't require the {}. When using a single line fat arrow function (implicit return)
            List<int> numbersLessThan50 = numbers.Where(num => num < 50).ToList();

            //Equivalent of MAP in JS with C. We use SELECT to map.
            //Map string of numbers and have it say "this number is ___". A list of strings
            List<string> messages = numbers.Select(num =>
            {
                return $"The number is {num}";
            }).ToList();

            City nashville = new City()
            {
                Name = "Nashville"
            };

            nashville.Buildings.Add(new Building()
            {
                Name = "NSS Building",
                Stories = 5,
                Address = "301 Plus Park Blvd"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "TPAC",
                Stories = 23,
                Address = "505 Deaderick Street"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "1505",
                Stories = 6,
                Address = "1505 Demonbreun Street"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "The Frist",
                Stories = 3,
                Address = "919 Broadway"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "The Batman Building",
                Stories = 33,
                Address = "333 Commerce Street"
            });

            //Another example for Where and Select

            List<Building> shortBuildings = nashville.Buildings.Where(building =>
            {
                bool isShort = building.Stories < 10;
                return isShort;
            }).ToList();

            List<string> nashvilleAddresses = nashville.Buildings
            .Select(building => building.Address).ToList();

            //Aggregation method. Numbers is a list of numbers, but we want to sum them all up in an interger.
            //Sum will do that method.
            int sum = numbers.Sum();
            //Average
            double average = numbers.Average();
            //Order By (like sort in JS, but this is better)
            numbers.Sort();
            //Sort by number of stories
            List<Building> orderedByStories = nashville.Buildings
            .OrderBy(building => building.Stories).ToList();

            //Chain Linq methods
            //Get average number of stories in buildings
            double averageHeight = nashville.Buildings
            .Select(building => building.Stories)
            .Average();

            //Distinct will get rid of duplicates
            //SelectMany is for nested lists
            //Reverse will revese order
            //GroupBy see exercise
            //Skip handy in web development in pagination. Ex, see all the pages on amazon with the results of Sci Fiction books (goes to page 1, then at bottom page 2 3 4 5)
            //Take handy in web development in pagination. Skip the first 10 (on page 1) and take the next 10 for page 2
        }

    }
}
