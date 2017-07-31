using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace WMS.Components
{
    public partial class WMSGroupHeader : BaseContentView
    {
		public static readonly BindableProperty HeaderTitleProperty = BindableProperty.Create("HeaderTitle", typeof(string), typeof(string), null);
		public string HeaderTitle
		{
			get 
            { 
                return (string)GetValue(HeaderTitleProperty); 
            }
			set
			{
				SetValue(HeaderTitleProperty, value);
			}
		}

        public WMSGroupHeader()
        {
            InitializeComponent();
        }
    }
}
