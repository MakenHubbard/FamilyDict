using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyDict
{
    class Program
    {
        public static string key { get; private set; }
        public static string brother { get; private set; }

        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,string>> myFamily = new Dictionary<string, Dictionary<string,string>>();

            // add my siblings to the Dictionary myFamily
            myFamily.Add("brother" , new Dictionary<string, string>()
            {
                {"name", "Eli" },
                {"age", "36" }
            });

            foreach (var KeyValuePair in myFamily)
            {
                var infoDict = KeyValuePair.Value;

                foreach (var innerKeyValuePair in infoDict)
                {
                    Console.WriteLine($"My {KeyValuePair.Key} {innerKeyValuePair.Key} is {innerKeyValuePair.Value}");
                }
            }

            Console.ReadLine();
        }
    }
}
