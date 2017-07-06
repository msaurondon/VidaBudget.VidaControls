using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VidaControls
{
    public class Validator
    {
        internal void ValidateString(string StringToValidate)
        {

        }

        internal bool ValidateDecimal(string DecimalToValidate, bool IsOptional = false)
        {
            bool matched = Regex.IsMatch(DecimalToValidate, @"^-?(?:0|[1-9]\d{0,2}(?:,?\d{3})*)(?:\.\d+)?$");
            if (string.IsNullOrEmpty(DecimalToValidate) && IsOptional == true)
            {
                return true;
            }
            return matched;
        }



        internal bool ValidateInteger(string IntegerToValidate)
        {
            bool matched = Regex.IsMatch(IntegerToValidate, @"[0-9]|[0-9]{2}");
            return matched;
        }
    }
}
