using System;
using Xamarin.Forms;
using WMS.CustomControls;
using WMS.Utils;
using Xamarin.Forms.Platform.Android;
using WMS.Droid.CustomRenderer;
using Java.Lang;
using Android.Graphics;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(WMSEditor), typeof(WMSEditorRenderer))]
namespace WMS.Droid.CustomRenderer
{
    public class WMSEditorRenderer : EditorRenderer
    {
        public WMSEditorRenderer()
        {

        }

		protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
                var element = e.NewElement as WMSEditor;
				this.Control.Hint = element.Placeholder;

                int color = (int)Long.ParseLong(Utils.WMSTheme.EditorBackgroundColor.Replace("#", ""), 16);
				int r = (color >> 16) & 0xFF;
				int g = (color >> 8) & 0xFF;
                int b = (color >> 0) & 0xFF;

				Control.SetHintTextColor(new Android.Graphics.Color(r, g, b));

                color = (int)Long.ParseLong(Utils.WMSTheme.EditorPlaceHolderColor.Replace("#", ""), 16);
				r = (color >> 16) & 0xFF;
				g = (color >> 8) & 0xFF;
				b = (color >> 0) & 0xFF;
				Control.SetBackgroundColor(new Android.Graphics.Color(r, g, b));
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == WMSEditor.PlaceholderProperty.PropertyName)
			{
				var element = this.Element as WMSEditor;
				this.Control.Hint = element.Placeholder;
			}
		}
	}
}