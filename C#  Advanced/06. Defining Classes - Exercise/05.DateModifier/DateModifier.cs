using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public static class DateModifier
    {
      public static int  GetDateModifier(string fristDateStr,string secondDateStr)
        {
            DateTime fristDate = DateTime.Parse(fristDateStr);
            DateTime secondDate = DateTime.Parse(secondDateStr);

            TimeSpan differernce = fristDate - secondDate;

            return differernce.Days;
        }
    }
}
