using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.DatabaseFiles
{
    public class CarColorsDB
    {
        private const string Path = @"..\..\DataFiles\CarColors.txt";

        public static List<string> Get()
        {
            var s = System.IO.File.ReadAllText(Path).Trim().Split('|').ToList();
            s.RemoveAt(s.Count - 1);
            return s;
        }

        public static void Save(string color)
        {
            string result = System.IO.File.ReadAllText(Path);
            if(!result.Contains(color))
                result += $"{color}|";
            System.IO.File.WriteAllText(Path, result);
        }

        /// <summary>
        ///  attempts to remove a color for the selected listing from the database
        ///  and returns a boolean telling the main form whether or not 
        ///  to remove a color from the dropdown list
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static bool Remove(string color) {

            var colors = Get();
            List<string> listingcolors = new List<string>();

            // check how many listings
            // have this color
            int counter = 0;
            bool removeThisTime = false;

            foreach (CustomListing<Car> l in CarListingsDB.GetListings()) {
                if (l.Car.Color == color) {
                    counter += 1;
                }
                listingcolors.Add(l.Car.Color);
            }


            if (counter == 1) {
                colors.Remove(color);
                removeThisTime = true;
            } // else: don't remove it!

            string result = "";
            foreach (var c in colors) {
                if (c == null || c == "" || $"{c}|" == "|") { }
                else {
                    result += $"{c}|";
                }
                
            }
            System.IO.File.WriteAllText(Path, result);
            
            return removeThisTime;
        }
    }
}
