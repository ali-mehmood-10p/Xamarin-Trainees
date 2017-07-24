using System;
using Xamarin.Forms;
using WMS.CustomControls;
using Xamarin.Forms.Platform.iOS;
using WMS.iOS.CustomRenderer;
using UIKit;

[assembly: ExportRenderer(typeof(WMSButton), typeof(WMSButtonRenderer))]
namespace WMS.iOS.CustomRenderer
{
    public class WMSButtonRenderer : ButtonRenderer
    {
        public WMSButtonRenderer()
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

			if (Control != null)
			{
                if (Device.Idiom == TargetIdiom.Tablet)
                {
                    // do whatever you want to the UITextField here!
                    Control.Font = UIFont.FromName(Control.Font.Name, Control.Font.PointSize + 11.0f);
                }
			}
        }
    }
}
