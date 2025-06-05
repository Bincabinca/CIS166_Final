using CarDealership.DatabaseFiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarDealership
{
    public class Filters
    {
        private static List<string> Colors = CarColorsDB.Get();
        private static List<string> Makes = CarMakesDB.Get();
        private static List<string> Prices = CarPriceRangesDB.GetRanges();
        private static List<string> Ages = CarAgeRangesDB.GetRanges();

        private static void LoadFilters()
        {
            Colors = CarColorsDB.Get();
            Makes = CarMakesDB.Get();
            Prices = CarPriceRangesDB.GetRanges();
            Ages = CarAgeRangesDB.GetRanges();
        }

        public static string[] Get()
        {

            string dividerDecoration= "=🚙=🚗=🚚=🛻=";
            LoadFilters();

            List<string> result = new List<string>();
            result.Add("Select a filter....");
            //Add colors to filters
            foreach (var color in Colors)
            {
                result.Add(color);
            }

            //Add Makes to filters
            result.Add(dividerDecoration);
            foreach (var make in Makes)
            {
                result.Add(make);
            }

            //Add Prices to filters
            result.Add(dividerDecoration);
            foreach (var price in Prices)
            {
                result.Add(price.ToString());
            }

            //Add Ages to filters
            result.Add(dividerDecoration);
            foreach (var age in Ages)
            {
                result.Add(age.ToString());
            }

            return result.ToArray();
        }

        public static string GetFiltered(Car car, FilterName filterName = FilterName.Null, string filter = null)
        {
            string result = "";

            if (filterName != FilterName.Null && filter != null)
            {
                if (filterName == FilterName.Make)
                {
                    if (car.Make == filter)
                        return $"Model: {car.Model}\nColor: {car.Color}\nAge: {car.Age}\nPrice: {car.Price.ToString("c")}\n";
                }
                else if (filterName == FilterName.Color)
                {
                    if (car.Color == filter)
                        return $"Make: {car.Make}\nModel: {car.Model}\nAge: {car.Age}\nPrice: {car.Price.ToString("c")}\n";
                }
                else if (filterName == FilterName.Age)
                {
                    var ages = CarAgeRangesDB.Get();
                    int lowerLimit = ages[filter][0];
                    int upperLimit = ages[filter][1];

                    int age = car.Age;
                    if (age >= lowerLimit && age < upperLimit)  //Only include if within range
                    {
                        result += car.ToString();
                    }
                }
                else if (filterName == FilterName.Price)
                {

                    var prices = CarPriceRangesDB.Get();
                    decimal lowerLimit = prices[filter][0];
                    decimal upperLimit = prices[filter][1];

                    decimal price = car.Price;
                    if (price >= lowerLimit && price < upperLimit)  //Only include if within range
                    {
                        result += car.ToString();
                    }

                }
            }

            return result;
        }
    }

    public enum FilterName
    {
        Color,
        Make,
        Age,
        Price,
        Null
    }
}
