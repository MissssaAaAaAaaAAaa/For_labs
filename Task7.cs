using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HW1
{
    class Task7
    {

        static public string Ipv4Convertor(long input)
        {
            string s = Convert.ToString(input, 2);
            int check = 32-s.Length;
            for (int i = 0; i < check; i++) s=string.Concat("0", s);
            return string.Concat(Convert.ToInt32(s.Substring(0, 8), 2),".", Convert.ToInt32(s.Substring(8,8), 2),".", Convert.ToInt32(s.Substring(16, 8), 2),".", Convert.ToInt32(s.Substring(24, 8), 2));
        }

    }
}
