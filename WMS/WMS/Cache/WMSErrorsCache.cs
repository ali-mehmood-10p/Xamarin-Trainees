using System;

using Xamarin.Forms;

namespace WMS.Cache
{
    public class WMSErrorsCache
    {
		#region "Login"

		public static string ERROR_STRING_MISSING_USER_NAME = "Username required";
		public static string ERROR_STRING_MISSING_PASSWORD = "Password required";
		public static string ERROR_STRING_INVALID_PASSWORD = "Password length must be in between 6-20 characters";

		#endregion

		#region "Forgot Password"
		
        public static string ERROR_STRING_MISSING_EMAIL_ADDRESS = "Please Enter Email Address";
        public static string ERROR_STRING_INVALID_EMAIL_ADDRESS = "Invalid email address";
        public static string ERROR_STRING_MISSING_CNIC = "Please Enter CNIC";
        public static string ERROR_STRING_INVALID_CNIC = "Invalid CNIC number, should be in a format xxxxx-xxxxxxx-x";

		#endregion

		#region "Make Appointment"

		public static string ERROR_STRING_MISSING_NAME = "Please Enter Name";
        public static string ERROR_STRING_MISSING_CONTACT_NO = "Please Enter Contact No";
		public static string ERROR_STRING_MISSING_COUNTRY = "Please Enter Country";
		public static string ERROR_STRING_MISSING_CITY = "Please Enter City";

		#endregion

		public WMSErrorsCache()
        {

        }
    }
}

