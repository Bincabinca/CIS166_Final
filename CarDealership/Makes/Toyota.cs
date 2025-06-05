using CarDealership.DatabaseFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    /// <summary>
    /// Toyota-Made Cars Subclass with unique member "Mileage"
    /// </summary>
    public class Toyota : Car, IUniqueMember<string> {
        public string Mileage { get; set; }
        public string Perk => Mileage;
        public Toyota() : base() { }


        public Toyota(string model, string color, int age, decimal price, string mileage) : base(model, color, age, price)
        {
            this.Mileage = mileage;
            
        }

        public override string ToString()
        {
            return base.ToString() + $"Mileage: {Mileage}\n";
        }

        public override string GetFilteredString(FilterName filterName = FilterName.Null, string filter = null)
        {
            string result = Filters.GetFiltered(this, filterName, filter);

            if (filterName == FilterName.Make || filterName == FilterName.Color)
            {
                if (result != null && result != "")
                    return result + $"Mileage: {Mileage}\n";
            }

            return result;
        }
    }
}
