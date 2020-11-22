using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW1
{
    class Task2Test
    {

        [TestCase("sTreSS", 'T')]
        [TestCase("", "")]
        [TestCase("ssaa", "")]
        public void First_non_repeating_letter_Test(string input_str, char output_char)
        {
            var res = Task2.First_non_repeating_letter(input_str);
            Assert.AreEqual(res, output_char);
        }
    }
}
