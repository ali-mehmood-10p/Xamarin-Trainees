using System;
using Xamarin.Forms;
using WMS.CustomControls;
using Xamarin.Forms.Platform.Android;
using WMS.iOS.CustomRenderer;

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
                    Control.TextSize = Control.TextSize + 11.0f;
                }
			}
        }
    }
}
