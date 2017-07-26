using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using System.ComponentModel;

namespace WMS.Components
{
    public partial class WMSHeaderUI : BaseContentView, INotifyPropertyChanged
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

        public static readonly BindableProperty YAlignDescriptionProperty = BindableProperty.Create("YAlignDescription", typeof(TextAlignment), typeof(TextAlignment), TextAlignment.Center);
		public TextAlignment YAlignDescription
		{
			get 
            {             
                return (TextAlignment)GetValue(YAlignDescriptionProperty); 
            }
			set
			{
				SetValue(YAlignDescriptionProperty, value);
                lblDescription.VerticalTextAlignment = value;
			}
		}

        public static readonly BindableProperty DescriptionMarginFactorProperty = BindableProperty.Create("DescriptionMarginFactor", typeof(double), typeof(double), (double)0.0);
        public double DescriptionMarginFactor
		{
			get
			{
				return (double)GetValue(DescriptionMarginFactorProperty);
			}
			set
			{
				SetValue(DescriptionMarginFactorProperty, value);
				lblDescription.Margin = new Thickness(0, 0, 0, this.Bounds.Size.Height * value);
			}
		}

        public void AdjustUIForSubHeader()
        {

		}

		public WMSHeaderUI()
		{
			InitializeComponent();
		}
    }
}
