using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    /// <summary>
    /// Interface for Car-like objects that have a Make, Model, Color, Age, and Price
    /// </summary>
    public interface ICar {
        string GetFilteredString(FilterName filterName = FilterName.Null, string filter = null);
        /// <summary>
        /// The manufacturing brand of the car (E.g. BMW, Honda, etc.)
        /// </summary>
        string Make { get;}
        /// <summary>
        ///  the model of the car (E.g. Accord, Civic, etc.)
        /// </summary>
        string Model { get; set; }
        /// <summary>
        /// the color of the car (E.g. Red, Blue, etc.)
        /// </summary>
        string Color { get; set; }
        /// <summary>
        /// the age of the car in years (E.g. 1, 2, etc.)
        /// </summary>
        int Age { get; set; }
        /// <summary>
        ///  the price of the car in US Dollars (E.g. 20000.00, 30000, etc.)
        /// </summary>
        decimal Price { get; set; }
    }
}
