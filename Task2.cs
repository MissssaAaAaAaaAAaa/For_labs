using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace HW1
{
    class Task2
    {
        static public char First_non_repeating_letter(string input_str)
        {
            return input_str.Where(el => input_str.Length.Equals(input_str.ToLower().Replace(el.ToString().ToLower(), "").Length + 1)).FirstOrDefault();
        }
    }
}
