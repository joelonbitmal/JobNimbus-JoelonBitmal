using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace JobNimbus.Library
{
    public class Validator
    {
        public bool ValidateString(string input)
        {
            bool oFound = false;
            bool isValid = false;

            if (!input.Contains("{") && !input.Contains("}"))
                return true;

            foreach (var c in input.ToCharArray())
            {
                if(c == '}' && !oFound)
                {
                    isValid = false;
                    break;
                }

                if(c == '{' && !oFound)
                {
                    oFound = true;
                    continue;
                }

                if(c == '}' && oFound)
                {
                    oFound = false;
                    isValid = true;
                }
                else if (c == '{' && oFound)
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
}
