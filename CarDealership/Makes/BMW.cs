using CarDealership.DatabaseFiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    /// <summary>
    /// BMW-Made Cars Subclass with unique member "Engine"
    /// </summary>
    public class BMW : Car,IUniqueMember<string> {
        public string Engine { get; set; }
        public string Perk => Engine;
        public BMW() : base() { }

        public BMW(string model, string color, int age, decimal price, string engine) : base(model, color, age, price)
        {
            this.Engine = engine;
        }

        public override string ToString()
        {
            return base.ToString() + $"Engine: {Engine}\n";
        }

        public override string GetFilteredString(FilterName filterName = FilterName.Null, string filter = null)
        {
            string result = Filters.GetFiltered(this, filterName, filter);

            if (filterName == FilterName.Make || filterName == FilterName.Color)
            {
                if (result != null && result != "")
                    return result + $"Engine: {Engine}\n";
            }

            return result;
        }
    }
}
