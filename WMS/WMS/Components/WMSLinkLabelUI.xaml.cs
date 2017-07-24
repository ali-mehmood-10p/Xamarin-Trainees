using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

using Xamarin.Forms;
using System.Windows.Input;

namespace WMS.Components
{
    public partial class WMSLinkLabelUI : BaseContentView
	{
		public static readonly BindableProperty DescriptionFontSizeProperty = BindableProperty.Create("DescriptionFontSize", typeof(double), typeof(double), (double)0.0);
		public double DescriptionFontSize
		{
			get { return (double)GetValue(DescriptionFontSizeProperty); }
			set
			{
				SetValue(DescriptionFontSizeProperty, value);
				lblDescription.FontSize = value;
			}
		}
        		
        void LinkLabel_Clicked(object sender, System.EventArgs e)
        {
            if(ExternalCommand != null)
            {
                ExternalCommand.Execute(null);
            }
        }

        public WMSLinkLabelUI()
		{
			InitializeComponent();
		}
	}
}
