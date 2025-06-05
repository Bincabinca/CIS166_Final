using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace CarDealership.DatabaseFiles
{
    public class CarAgeRangesDB
    {
        private const string Path = @"..\..\DataFiles\CarAgeRanges.txt";

        public static Dictionary<string, List<int>> Get()
        {
            var result = new Dictionary<string, List<int>>();

            var cars = System.IO.File.ReadAllText(Path).Split('|');
            string key = "";
            int lowerLimit = 0;
            int upperLimit = 0;
            foreach (var car in cars)
            {
                var lines = car.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];

                    if (i == 0)
                        key = line.Trim();
                    else if (i == 1)
                        lowerLimit = Convert.ToInt32(line);
                    else if (i == 2)
                    {
                        upperLimit = Convert.ToInt32(line); 
                        result.Add(key, new List<int> { lowerLimit, upperLimit });
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
