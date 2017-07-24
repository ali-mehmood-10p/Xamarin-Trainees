using System;
using Xamarin.Forms;

namespace WMS.CustomControls
{
    public class WMSEditor : Editor
    {
		public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create("Placeholder", typeof(string), typeof(string), null);
		public string Placeholder
		{
			get { return (string)GetValue(PlaceholderProperty); }
			set
			{
				SetValue(PlaceholderProperty, value);
			}
		}

        public WMSEditor()
        {

        }
    }
}
