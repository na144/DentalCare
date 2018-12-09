using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DentalCare
{
    public class CheckIfValid
    {
        public bool checkPersonalNumber(string number)
        {
            Match match = Regex.Match(number, @"^\d\d\d\d\d\d\d\d-\d\d\d\d$");
            if (match.Success)
            {
                return true;
            }
            return false;
        }

    }
}
