using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HW1
{
    class Task5
    {
        static string MeetingHelper(ref string s)
        {
            string end = s.Substring(s.IndexOf(':')+1);
            s = string.Concat("(", s.Replace(end, s.Substring(0, s.IndexOf(':'))).Replace(s.Substring(0, s.IndexOf(':')+1), string.Concat(end, ", ")), ")");
            return s;
        }
        static public string Meeting(string s)
        {
            if (s.Contains(":"))
            {
                List<string> s1= new List<string> { };
                s.ToUpper().Split(";").ToList().OrderBy(el => el.Substring(el.IndexOf(':') + 1)).ThenBy(el => el.Substring(0, el.IndexOf(':'))).ToList().ForEach(el => s1.Add(MeetingHelper(ref el)));
                return string.Join("", s1);
            }
            else return "";
        }
    }
}
