using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using ValidationLibrary;

namespace ValidationLibraryTest
{
    /// <summary>
    /// Class to test validation methods
    /// </summary>
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]

        public void IsPresent_ValidValue()
        {
            string expected = "";                              // arrange
            var result = Validator.IsPresent("3.14", "Name");  // act
            Assert.AreEqual(expected, result);                 // assert
        }

        [TestMethod]
        public void IsPresent_InvalidValue()
        {
            string name = "Test field";                      // arrange
            var result = Validator.IsPresent("", name);      // act
            Assert.IsTrue(result.Contains(name));            // assert
        }

        [TestMethod]
        public void IsDecimal_ValidValue()
        {
            string expected = "";                              // arrange
            var result = Validator.IsDecimal("3.14", "Name");  // act
            Assert.AreEqual(expected, result);                 // assert
        }

        [TestMethod]
        public void IsDecimal_InvalidValue()
        {
            string name = "Test field";                      // arrange
            var result = Validator.IsDecimal("three", name); // act
            Assert.IsTrue(result.Contains(name));            // assert
        }

        [TestMethod]
        public void IsInt32_ValidValue()
        {
            string expected = "";                           // arrange
            var result = Validator.IsInt32("8", "Name");    // act
            Assert.AreEqual(expected, result);              // assert
        }
        [TestMethod]
        public void IsInt32_InvalidValue()
        {
            string name = "Test field";                     // arrange
            var result = Validator.IsInt32("eight", name);  // act
            Assert.IsTrue(result.Contains(name));           // assert
        }

    }
}
