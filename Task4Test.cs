using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    class Task4Test
    {
        [TestCase(new int[] {1,4,2,2,3,0,5,6},4)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] {1,1,2,2,7},0)]
        [TestCase(new int[] {1, 11, 2, 10,3,9,4,8},4,12)]

        public void NumberOfPairsTest(int[] input_array, int output, int turgetnumber=5)
        {
            var res = Task4.NumberOfPairs(input_array,turgetnumber);
            Assert.AreEqual(res, output);
        }

    }
}


