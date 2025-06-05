using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    /// <summary>
    /// Mercedes-Made Cars Subclass with unique member "Horsepower"
    /// </summary>
    public class Mercedes : Car,IUniqueMember<string> //Declaration for a new subclass of Car
    {
        public string Horsepower { get; set; }
        public string Perk => Horsepower; 

        public Mercedes() : base() { }

        public Mercedes(string model, string color, int age, decimal price, string horsepower) : base(model, color, age, price)
        {
            this.Horsepower = horsepower; //Initialize Horsepower field after car class constructor is called
        }

        public override string ToString() //Override ToString() method to include Mercedes perk
        {
            return base.ToString() + $"Horsepower: {Horsepower}\n";
        }

        //Override GetFilteredString() method to include Mercedes perk
        public override string GetFilteredString(FilterName filterName = FilterName.Null, string filter = null)
        {
            string result = Filters.GetFiltered(this, filterName, filter);

            if (filterName == FilterName.Make || filterName == FilterName.Color)
            {
                if (result != null && result != "")
                    return result + $"Horsepower: {Horsepower}\n";
            }

            return result;
        }
    }
}
