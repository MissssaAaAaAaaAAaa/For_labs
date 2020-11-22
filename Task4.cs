using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HW1
{
    class Task4
    {
        static public int NumberOfPairs(int [] input_array,int targetnumber=5)
        {
            int count = 0;
            List<int> list = input_array.ToList();
            foreach (int x in input_array)
            {
                count += list.Where(el => el + x == targetnumber).Count();
                list.Remove(x);
            }
            return count;
        }
    }
}
