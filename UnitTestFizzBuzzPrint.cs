using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzClassLibrary;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTestFizzBuzzPrint
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            int _testNum = 9;

            string _expected = "Fizz";

            FizzBuzzPrint _writer = new FizzBuzzPrint();


            //Act

            string _actual = _writer.FizzBuzzPrinter(_testNum);

            //Assert

            Assert.AreEqual(_expected, _actual, true);

        }
    }
}
