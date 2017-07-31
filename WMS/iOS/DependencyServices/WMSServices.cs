using System;
using UIKit;
using WMS.Interfaces;
using WMS.iOS.DependencyServices;
using Xamarin.Forms.Platform.iOS;
using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(WMSServices))]
namespace WMS.iOS.DependencyServices
{
    public class WMSServices : IWMSServices
    {
        public void InvokeCallService()
        {
            string url = "tel:\\03001234567";
            NSUrl phoneUrl = new NSUrl(url);
			if (!UIApplication.SharedApplication.OpenUrl(phoneUrl))
			{
                var alert = UIAlertController.Create("Not supported", "Scheme 'tel:' is not supported on this device", UIAlertControllerStyle.Alert);
				alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));

				UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, animated: true, completionHandler: null);
			};
        }

        public void InvokePaymentService()
        {
            
        }

        public void InvokeSMSService()
        {
            
        }
    }
}
