using CarDealership.DatabaseFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    /// <summary>
    /// Abstract class for Car-like objects that implement ICar, Iisplayable,and IComparable
    /// </summary>
    public abstract class Car : IDisplayable, ICar, IComparable<Car> {
        
        public string Make => GetType().ToString().Split('.')[1]; // clever way to get the make of the car from the class name
        public string Model { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public Car() { }
        /// <summary>
        /// Subclasses of "Car" inherit this constructor in their constructor using the "base" keyword
        /// </summary>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        /// <param name="price"></param>
        public Car(string model, string color, int age, decimal price) {
            this.Model = model;
            this.Color = color;
            this.Age = age;
            this.Price = price;
        }
        /// <summary>
        /// Compares two cars based on their string representation
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Car other) {
            if (other == null) return 1;
            return this.ToString().CompareTo(other.ToString());
        }
        /// <summary>
        /// Returns a string representation of the car
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return $"Make: {Make}\nModel: {Model}\nColor: {Color}\nAge: {Age}\nPrice: {Price.ToString("c")}\n";
        }
        /// <summary>
        /// Returns a filtered string representation of the car based on the filter name and filter value
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public virtual string GetFilteredString(FilterName filterName = FilterName.Null, string filter = null) {
            if (filterName == FilterName.Make) { 
                if (Make == filter)
                    return $"Model: {Model}\nColor: {Color}\nAge: {Age}\nPrice: {Price.ToString("c")}\n";
            }
            else if (filterName == FilterName.Color) {
                if (Color == filter)
                    return $"Make: {Make}\nModel: {Model}\nAge: {Age}\nPrice: {Price.ToString("c")}\n";
            }

            return null;
        }
       
    }
}
