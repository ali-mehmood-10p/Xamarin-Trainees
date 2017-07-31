using System;
using WMS.Interfaces;
using WMS.Droid.DependencyServices;
using Android.Content;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(WMSServices))]
namespace WMS.Droid.DependencyServices
{
    public class WMSServices : IWMSServices
    {
        public void InvokeCallService()
        {
            string url = "tel:03001234567";
			var uri = Android.Net.Uri.Parse(url);
			var intent = new Intent(Intent.ActionDial, uri);

            Forms.Context.StartActivity(intent);
        }

        public void InvokePaymentService()
        {
            
        }

        public void InvokeSMSService()
        {
            
        }
    }
}
