using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace HW1
{
    class Task1
    {
        static public List<object> GetIntegerFromList (List<object> input_list)
        {            
            return input_list.Where(el => el.GetType().Equals(typeof(int))).ToList();    
        }
    }
}
