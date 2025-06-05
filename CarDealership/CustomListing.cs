using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    /// <summary>
    /// Custom Listing class over a type T that implements IComparable and IDisplayable
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomListing<T> where T: ICar,IComparable<T>,IDisplayable {
        public T Car { get; set; }
        public CustomListing() { }
        public CustomListing(T car, DateTime dateTime) {
            Car = car;
            CreationTime = dateTime;
        }
        public int compareTo<CustomListing>(CustomListing<T> other) {

            if (this.CreationTime > other.CreationTime)
                return 1;
            else if (CreationTime < other.CreationTime)
                return -1;
            else
                return 0;
        }
        public override string ToString() {
            return Car.ToString() + CreationTime.ToString() + "\n\n";
        }

        public string GetFilteredString(FilterName filterName = FilterName.Null, string filter = null) {
            string carFilteredString = Car.GetFilteredString(filterName, filter);
            if (carFilteredString != null && carFilteredString != "")
                return carFilteredString + CreationTime.ToString() + "\n\n";

            return null;
        }
        public DateTime CreationTime { get; set; }
    }
}
