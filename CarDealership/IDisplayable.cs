using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    /// <summary>
    /// Interface for classes that can be displayed as a string
    /// </summary>
    public interface IDisplayable
    {
        /// <summary>
        /// IDisplayable Override of ToString() allowing for custom string representation
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}
