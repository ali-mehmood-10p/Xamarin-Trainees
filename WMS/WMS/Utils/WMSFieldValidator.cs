using System;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace WMS.Utils
{
    public class WMSFieldValidator
    {
        public WMSFieldValidator()
        {
            
        }

        public static bool IsEmailAddressValid(string emailAddress)
        {
            if(string.IsNullOrEmpty(emailAddress)) 
            {
                return false;
            }

			string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
		   + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
		   + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

			Regex re = new Regex(validEmailPattern, RegexOptions.IgnoreCase);
            return  re.IsMatch(emailAddress);
        }

		public static bool IsCNICValid(string CNIC)
		{
			if (string.IsNullOrEmpty(CNIC))
			{
				return false;
			}

			string validCNICPattern = @"^\d{5}\-\d{7}\-\d$";

			Regex re = new Regex(validCNICPattern, RegexOptions.IgnoreCase);
			return re.IsMatch(CNIC);
		}

        public static bool IsPasswordValid(string Password)
        {
            return (Password.Length >= 6 && Password.Length <= 20);
        }
    }
}
