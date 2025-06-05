using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace CarDealership.DatabaseFiles
{
    public class CarPriceRangesDB
    {
        private const string Path = @"..\..\DataFiles\CarPriceRanges.txt";

        public static Dictionary<string, List<decimal>> Get()
        {
            var result = new Dictionary<string, List<decimal>>();

            var cars = System.IO.File.ReadAllText(Path).Split('|');
            string key = "";
            decimal lowerLimit = 0;
            decimal upperLimit = 0;
            foreach(var car in cars)
            {
                var lines = car.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];

                    if (i == 0)
                        key = line.Trim();
                    else if (i == 1)
                        lowerLimit = Convert.ToDecimal(line);
                    else if (i == 2)
                    {
                        upperLimit = Convert.ToDecimal(line);
                        result.Add(key, new List<decimal> { lowerLimit, upperLimit });
                    }

                }
            }
            return result;
        }

        public static List<string> GetRanges()
        {
            var result = Get();
            return result.Keys.ToList();
        }
    }
}
