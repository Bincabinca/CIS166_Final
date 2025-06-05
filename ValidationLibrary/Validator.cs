using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ValidationLibrary;

namespace ValidationLibrary
{
        /// <summary>
        /// Provides static methods for validation data
        /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Checks whether the user entered a value.
        /// </summary>
        /// <param name="value">The value to be validated.</param>
        /// <param name="name">A name that identifies the value
        /// to be validated.</param>
        /// <returns>An error message if the user didn't enter
        /// a value.</returns>
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }

        /// <summary>
        /// Checks whether the user entered an integer value.
        /// </summary>
        /// <param name="value">The value to be validated.</param>
        /// <param name="name">A name that identifies the value
        /// to be validated.</param>
        /// <returns>An error message if the user didn't enter
        /// an integer value.</returns>
        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid int value.\n";
            }
            return msg;
        }
        /// <summary>
        /// Checks whether the user entered a decimal value.
        /// </summary>
        /// <param name="value">The value to be validated.</param>
        /// <param name="name">A name that identifies the value
        /// to be validated.</param>
        /// <returns>An error message if the user didn't enter
        /// a decimal value.</returns>
        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value.\n";
            }
            return msg;
        }
    }
}
