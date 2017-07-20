using System;
using WMS;
using WMS.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TransparentEntry), typeof(TransparentEntryRenderer))]
namespace WMS.Droid
{
    public class TransparentEntryRenderer : EntryRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
                // do whatever you want to the UITextField here!
                Control.SetBackgroundResource(Android.Resource.Color.Transparent);
			}
		}
    }
}
