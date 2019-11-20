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
                56,
                72,
                91
            };

            List<int> numbersAbove50 = numbers.Where(num =>
            {
                return num > 50;
            }).ToList();

            List<int> evenNumbers = numbers.Where(num =>
            {
                bool isEven = num % 2 == 0;
                return isEven;
            }).ToList();

            //Where using a single line fat arrow function.
            // Same as JS, this has an implicit return
            List<int> numbersLessThan50 = numbers.Where(num => num < 50).ToList();

            // Select is like a map in JS
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

            // Better example for Where and Select

            List<Building> shortBuildings = nashville.Buildings.Where(building =>
            {
                bool isShort = building.Stories < 10;
                return isShort;
            }).ToList();

            List<string> nashvilleAddresses = nashville.Buildings
                .Select(building => building.Address).ToList();

            int sum = numbers.Sum();
            double average = numbers.Average();
            numbers.Sort();

            //Order By
            List<Building> orderedByStories = nashville.Buildings
                .OrderBy(building => building.Stories)
                .ToList();

            // Chain Linq methods
            double averageHeight = nashville.Buildings
                .Select(building => building.Stories)
                .Average();
        }
    }
}