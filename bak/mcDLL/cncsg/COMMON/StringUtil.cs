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
    }
}
