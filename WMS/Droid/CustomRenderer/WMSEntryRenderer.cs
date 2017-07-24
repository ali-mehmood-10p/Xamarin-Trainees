using System;
using Xamarin.Forms;
using WMS.CustomControls;
using WMS.Utils;
using Xamarin.Forms.Platform.Android;
using WMS.Droid.CustomRenderer;
using Java.Lang;
using Android.Graphics;

[assembly: ExportRenderer(typeof(WMSEntry), typeof(WMSEntryRenderer))]
namespace WMS.Droid.CustomRenderer
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
                int color = (int)Long.ParseLong(Utils.WMSTheme.ThemeGreyColor.Replace("#", ""), 16);
				int r = (color >> 16) & 0xFF;
				int g = (color >> 8) & 0xFF;
				int b = (color >> 0) & 0xFF;

                Control.SetHintTextColor(new Android.Graphics.Color(r, g, b));
                Control.SetBackground(null);
			}
		}
    } 
}
