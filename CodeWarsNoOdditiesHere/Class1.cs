using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using NUnit.Compatibility;

namespace CodeWarsNoOdditiesHere
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void OneThroughFive()
        {
            Assert.AreEqual(new int[] { 2, 4 }, NoOddities.NoOdds(new int[] { 1, 2, 3, 4, 5 }));
        }
        //Write a small function that returns the values of an array that are not odd.

        //All values in the array will be integers.Return the good values in the order they are given.
    }
    public class NoOddities
    {
        public static int[] NoOdds(int[] values)
        {
            return Array.FindAll(values, x => x % 2 == 0);

            

        }
    }
}
