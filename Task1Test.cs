using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW1
{
    class Task1Test
    {
        [TestCase(new object[] {1, 2, "a", "b" }, new object[]  { 1,2})]
        [TestCase(new object[] { 1, 2, "a", "b", 0, 15 }, new object[] { 1, 2,0,15 })]
        [TestCase(new object[] { 1, 2, "a", "b", "aasf", "1", "123", 231 }, new object[]  { 1, 2, 231 })]
        
        public void GetIntegerFromListTest (object[] input_list, object[] output_list)
        {
            var res = Task1.GetIntegerFromList(input_list.ToList());
            Assert.AreEqual(res, output_list.ToList());
        }
    }
}

