using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    /// <summary>
    /// Honda-Made Cars Subclass with unique member "SafetyRating"
    /// </summary>
    public class Honda : Car, IUniqueMember<string> 
    {
        public string SafetyRating {  get; set; } 
        public string Perk => SafetyRating;

        public Honda() : base() { }

        public Honda(string model, string color, int age, decimal price, string SafetyRating, string user) : base(model, color, age, price, user)
        {
            this.SafetyRating = SafetyRating; //Initialize SafetyRating field after car class constructor is called
        }

        public override string ToString() //Override ToString() method to include Honda perk
        {
            return base.ToString() + $"Safety Rating: {SafetyRating}\n";
        }

        //Override GetFilteredString() method to include Honda perk
        public override string GetFilteredString(FilterName filterName = FilterName.Null, string filter = null)
        {
            string result = Filters.GetFiltered(this, filterName, filter);

            if (filterName == FilterName.Make || filterName == FilterName.Color)
            {
                if (result != null && result != "")
                    return result + $"Safety Rating: {SafetyRating}\n";
            }

            return result;
        }
    }
}
