using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.common
{
    public class StringUtil
    {
        public static string Zero2Text(double d)
        {
            if (d == 0d)
            {
                return "";
            }
            return Convert.ToString(d);
        }

        public static string Zero2Text(int d)
        {
            if (d == 0)
            {
                return "";
            }
            return Convert.ToString(d);
        }

        public static bool IsEmpty(string str)
        {
            return str == null || str.Trim().Equals(string.Empty);
        }

        public static bool IsEquals(string s1, string s2)
        {
            if (s1 == null || s2 == null)
            {
                return false;
            }
            if (s1 == s2)
            {
                return true;
            }
            return s1.Equals(s1);
        }
    }
}
