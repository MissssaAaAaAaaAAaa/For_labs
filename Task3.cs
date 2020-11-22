using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HW1
{
    class Task3
    {
        static public int DigitalRoot(int input)
        {
            int res = (int)input.ToString().ToList().ConvertAll(el => char.GetNumericValue(el)).Sum();
            return res.ToString().Length<2 ? res:Task3.DigitalRoot(res);
        }
    }
}
