using System;
using Xamarin.Forms;
using WMS.CustomControls;
using Xamarin.Forms.Platform.iOS;
using WMS.iOS.CustomRenderer;
using System.Runtime.CompilerServices;
using UIKit;

[assembly: ExportRenderer(typeof(WMSLabel), typeof(WMSLabelRenderer))]
namespace WMS.iOS.CustomRenderer
{
    public class WMSLabelRenderer : LabelRenderer
    {
        public WMSLabelRenderer()
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

			if (Control != null)
			{
				if (Device.Idiom == TargetIdiom.Tablet)
				{
                    // do whatever you want to the UITextField here!
                    Control.AdjustsFontSizeToFitWidth = true;
                    Control.MinimumScaleFactor = 0.5f;
				}
			}
        }
 
    }
}
