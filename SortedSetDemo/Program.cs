using System;
using System.Collections.Generic;

namespace SortedSetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //sorted sets protects against duplicate values aswell
            var bigCities = new SortedSet<string>
                            //customer comparer implementation
                            (new UncasedStringComparer())
            { "New York", "Manchester", "Sheffield", "Paris" };

            bigCities.Add("SHEFFIELD");
            bigCities.Add("Beijing");

            foreach (string city in bigCities)
                Console.WriteLine(city);
        }
    }


    //customer comparer for SortedSet must implement IComparer not IEquality
    class UncasedStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y,
                StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
