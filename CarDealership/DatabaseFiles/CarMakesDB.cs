using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.DatabaseFiles
{
    public class CarMakesDB
    {
        private const string Path = @"..\..\DataFiles\CarMakes.txt";

        public static List<string> Get()
        {
            List<string> s = System.IO.File.ReadAllText(Path).Split('|').ToList();
            s.RemoveAt(s.Count - 1);
            return s;
        }
    }
}
