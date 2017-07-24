using System;
using Xamarin.Forms;
using WMS.CustomControls;
using Xamarin.Forms.Platform.Android;
using WMS.iOS.CustomRenderer;
using System.Runtime.CompilerServices;

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
                    Control.TextSize = Control.TextSize + 11.0f;
				}
			}
        }
 
    }
}
