using System;
using Xamarin.Forms;
using WMS.CustomControls;
using WMS.Utils;
using Xamarin.Forms.Platform.iOS;
using WMS.iOS.CustomRenderer;
using System.ComponentModel;
using UIKit;
using CoreGraphics;

[assembly: ExportRenderer(typeof(WMSEditor), typeof(WMSEditorRenderer))]
namespace WMS.iOS.CustomRenderer
{
	public class WMSEditorRenderer : EditorRenderer
	{
        UILabel placeHolder;

		public WMSEditorRenderer()
		{

		}

		protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
			{
                if (placeHolder == null)
                {
                    placeHolder = new UILabel();
                    placeHolder.Text = (e.NewElement as WMSEditor).Placeholder;
                    placeHolder.SizeToFit();
                    placeHolder.Frame = new CGRect(10, 10, placeHolder.Frame.Size.Width, placeHolder.Frame.Size.Height);
                    placeHolder.TextColor = UIColor.FromRGB(149, 149, 149);
                    placeHolder.BackgroundColor = UIColor.Clear;
                    placeHolder.Font = Control.Font;

                    Control.BackgroundColor = UIColor.FromRGB(233, 233, 233);
                    Control.AddSubview(placeHolder);
                }
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == "Text")
			{
				placeHolder.Hidden = Control.Text.Length > 0;
			}
        }
	}
}
