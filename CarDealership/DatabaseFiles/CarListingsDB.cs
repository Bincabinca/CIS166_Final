using CarDealership.DatabaseFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace CarDealership
{
    public static class CarListingsDB 
    {
        private const string CarsPath = @"..\..\DataFiles\InventoryItems.txt";
        private const string TimesPath = @"..\..\DataFiles\ListingTimes.txt";


        public static List<CustomListing<Car>> GetListings()
        {
            List<CustomListing<Car>> result = new List<CustomListing<Car>>();

            string[] cars = System.IO.File.ReadAllText(CarsPath).Split('|');
            string[] times = System.IO.File.ReadAllText(TimesPath).Split('|');

            int index = 0;
            Car c = null;
            foreach(var car in cars)
            {
                if (car != null && car != "")
                {
                    var lines = car.Split('\n');

                    switch (lines[0]) {
                        case nameof(BMW):
                        c = new BMW(lines[1], lines[2], Convert.ToInt32(lines[3]), Convert.ToDecimal(lines[4]), lines[5], lines[6]);
                        break;
                        case nameof(Toyota):
                        c = new Toyota(lines[1], lines[2], Convert.ToInt32(lines[3]), Convert.ToDecimal(lines[4]), lines[5], lines[6]);
                        break;
                        case nameof(Honda):
                        c = new Honda(lines[1], lines[2], Convert.ToInt32(lines[3]), Convert.ToDecimal(lines[4]), lines[5], lines[6]);
                        break;
                        default:
                            c = new Mercedes(lines[1], lines[2], Convert.ToInt32(lines[3]), Convert.ToDecimal(lines[4]), lines[5], lines[6]);
                        break;
                    }
                        

                    result.Insert(0, new CustomListing<Car>(c, DateTime.Parse(times[index]))); //Insert new listing at the top of the list
                    index++;
                }
            }

            return result;
        }

        public static string[] Get()
        {
            List<string> result = new List<string>();
            var listings = GetListings();
            foreach(var listing in listings)
            {
                var car = listing.Car;
                result.Add("\t" + listing.CreationTime + "\n"
                            + car.ToString() + "\n");
            }
            return result.ToArray();
        }
        public static void Save(BMW car)
        {
            CarColorsDB.Save(car.Color);

            string carsResult = System.IO.File.ReadAllText(CarsPath);
            carsResult += $"{car.Make}\n{car.Model}\n{car.Color}\n{car.Age}\n{car.Price}\n{car.Engine}\n{car.User}|";
            System.IO.File.WriteAllText(CarsPath, carsResult);

            string timesResult = System.IO.File.ReadAllText(TimesPath);
            timesResult += $"{DateTime.Now}|";
            System.IO.File.WriteAllText(TimesPath, timesResult);
        }

        public static void Save(Toyota car)
        {
            CarColorsDB.Save(car.Color);

            string carsResult = System.IO.File.ReadAllText(CarsPath);
            carsResult += $"{car.Make}\n{car.Model}\n{car.Color}\n{car.Age}\n{car.Price}\n{car.Mileage}\n{car.User}|";
            System.IO.File.WriteAllText(CarsPath, carsResult);

            string timesResult = System.IO.File.ReadAllText(TimesPath);
            timesResult += $"{DateTime.Now}|";
            System.IO.File.WriteAllText(TimesPath, timesResult);
        }

        public static void Save(Honda car)
        {
            CarColorsDB.Save(car.Color);

            string carsResult = System.IO.File.ReadAllText(CarsPath);
            carsResult += $"{car.Make}\n{car.Model}\n{car.Color}\n{car.Age}\n{car.Price}\n{car.SafetyRating}\n{car.User}|";
            System.IO.File.WriteAllText(CarsPath, carsResult);

            string timesResult = System.IO.File.ReadAllText(TimesPath);
            timesResult += $"{DateTime.Now}|";
            System.IO.File.WriteAllText(TimesPath, timesResult);
        }

        public static void Save(Mercedes car)
        {
            CarColorsDB.Save(car.Color);

            string carsResult = System.IO.File.ReadAllText(CarsPath);
            carsResult += $"{car.Make}\n{car.Model}\n{car.Color}\n{car.Age}\n{car.Price}\n{car.Horsepower}\n{car.User}|";
            System.IO.File.WriteAllText(CarsPath, carsResult);

            string timesResult = System.IO.File.ReadAllText(TimesPath);
            timesResult += $"{DateTime.Now}|";
            System.IO.File.WriteAllText(TimesPath, timesResult);
        }

        public static void Delete(BMW car, string dateTime)
        {
            string carsResult = System.IO.File.ReadAllText(CarsPath);
            carsResult = carsResult.Replace($"{car.Make}\n{car.Model}\n{car.Color}\n{car.Age}\n{car.Price}\n{car.Engine}|", "");
            System.IO.File.WriteAllText(CarsPath, carsResult);

            string timesResult = System.IO.File.ReadAllText(TimesPath);
            timesResult.Replace($"{dateTime}|", "");
            System.IO.File.WriteAllText(TimesPath, timesResult);
        }
        public static void Delete(Toyota car, string dateTime)
        {
            string carsResult = System.IO.File.ReadAllText(CarsPath);
            carsResult = carsResult.Replace($"{car.Make}\n{car.Model}\n{car.Color}\n{car.Age}\n{car.Price}\n{car.Mileage}|", "");
            System.IO.File.WriteAllText(CarsPath, carsResult);

            string timesResult = System.IO.File.ReadAllText(TimesPath);
            timesResult.Replace($"{dateTime}|", "");
            System.IO.File.WriteAllText(TimesPath, timesResult);
        }
        public static void Delete(Honda car, string dateTime)
        {
            string carsResult = System.IO.File.ReadAllText(CarsPath);
            carsResult = carsResult.Replace($"{car.Make}\n{car.Model}\n{car.Color}\n{car.Age}\n{car.Price}\n{car.SafetyRating}|", "");
            System.IO.File.WriteAllText(CarsPath, carsResult);

            string timesResult = System.IO.File.ReadAllText(TimesPath);
            timesResult.Replace($"{dateTime}|", "");
            System.IO.File.WriteAllText(TimesPath, timesResult);
        }
        public static void Delete(Mercedes car, string dateTime)
        {
            string carsResult = System.IO.File.ReadAllText(CarsPath);
            carsResult = carsResult.Replace($"{car.Make}\n{car.Model}\n{car.Color}\n{car.Age}\n{car.Price}\n{car.Horsepower}|", "");
            System.IO.File.WriteAllText(CarsPath, carsResult);

            string timesResult = System.IO.File.ReadAllText(TimesPath);
            timesResult.Replace($"{dateTime}|", "");
            System.IO.File.WriteAllText(TimesPath, timesResult);
        }
    }
}
