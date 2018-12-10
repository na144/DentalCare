using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DentalCare
{
    public class CheckDate
    {
        public bool checkDateFormat(string dateString)
        {
            Regex r = new Regex(@"\d{4}-\d{2}-\d{2}");

            if (r.IsMatch(dateString))
            {
                return true;
            }
            return false;

        }
    }
}
