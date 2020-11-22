using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;


namespace HW1
{
    class Task7Test
    {
        [TestCase(32, "0.0.0.32")]
        [TestCase(0, "0.0.0.0")]
        [TestCase(2149583361,"128.32.10.1")]

        public void Ipv4ConvertorTest(long input, string output)
        {
            var res = Task7.Ipv4Convertor(input);
            Assert.AreEqual(res, output);
        }
    }
}
