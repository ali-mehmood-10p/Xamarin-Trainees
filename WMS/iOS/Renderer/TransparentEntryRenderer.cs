using System;
using WMS;
using WMS.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TransparentEntry), typeof(TransparentEntryRenderer))]

namespace WMS.iOS
{
    
    public class TransparentEntryRenderer : EntryRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				// do whatever you want to the UITextField here!
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
			}
		}
    }
}
