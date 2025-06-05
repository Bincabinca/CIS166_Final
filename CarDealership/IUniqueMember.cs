using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    /// <summary>
    /// Interface for classes with a unique member of type T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IUniqueMember<T>
    {
        /// <summary>
        /// gets the value of the unique member of this subclass
        /// </summary>
        T Perk {get;}
    }
}
