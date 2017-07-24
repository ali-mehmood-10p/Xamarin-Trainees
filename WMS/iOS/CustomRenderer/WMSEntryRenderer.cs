using System;
using Xamarin.Forms;
using WMS.CustomControls;
using Xamarin.Forms.Platform.iOS;
using WMS.iOS.CustomRenderer;
using UIKit;
using Foundation;

[assembly: ExportRenderer(typeof(WMSEntry), typeof(WMSEntryRenderer))]
namespace WMS.iOS.CustomRenderer
{
    public class WMSEntryRenderer : EntryRenderer
    {
        public WMSEntryRenderer()
        {
            
        }

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
                // do whatever you want to the UITextField here!
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
                Control.AutocorrectionType = UIKit.UITextAutocorrectionType.No;

                if (Device.Idiom == TargetIdiom.Tablet)
                {
                    
				}
			}
		}
	}

}
