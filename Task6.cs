using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace HW1
{
    class Task6
    {
        static public int NextBigger(int input)
        {
            string input_str = input.ToString();
            if (string.Join("", input_str.OrderByDescending(v => v).ToList()) == input_str) return -1;
            else
            {
                char[] arr = input_str.ToArray();
                for (int i = arr.Length-1;i>=0;i--)
                 {
                    if (arr[i] > arr[i - 1])
                    {
                        char temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        return Convert.ToInt32(string.Join("", arr)) ;
                        //return Convert.ToInt32(input_str.Replace(input_str[i].ToString(), string.Concat(" ", input_str[i - 1])).Replace(string.Concat(input_str[i - 1], " "), temp.ToString()));
                    }
                 }
            }
            return 0;
        }
    }
}
