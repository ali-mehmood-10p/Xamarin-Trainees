using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using Xamarin.Forms;

namespace WMS.Components
{
    public partial class WMSEntryUI2 : BaseContentView
    {
		public static readonly BindableProperty PlaceHolderTextProperty = BindableProperty.Create("PlaceHolderText", typeof(string), typeof(string), null);
		public string PlaceHolderText
		{
			get { return (string)GetValue(PlaceHolderTextProperty); }
			set
			{
				SetValue(PlaceHolderTextProperty, value);
			}
		}

		public static readonly BindableProperty IsSecureTextEntryProperty = BindableProperty.Create("IsSecureTextEntry", typeof(bool), typeof(bool), false);
		public bool IsSecureTextEntry
		{
			get { return (bool)GetValue(IsSecureTextEntryProperty); }
			set
			{
				SetValue(IsSecureTextEntryProperty, value);
				txtEntry.IsPassword = value;
			}
		}

		public static readonly BindableProperty DescriptionFontSizeProperty = BindableProperty.Create("DescriptionFontSize", typeof(double), typeof(double), (double)0.0);
		public double DescriptionFontSize
		{
			get { return (double)GetValue(DescriptionFontSizeProperty); }
			set
			{
				SetValue(DescriptionFontSizeProperty, value);
				txtEntry.FontSize = value;
			}
		}

		public WMSEntryUI2()
        {
            InitializeComponent();
		}
    }
}
