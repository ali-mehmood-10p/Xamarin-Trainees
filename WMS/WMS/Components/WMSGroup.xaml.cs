using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.ComponentModel;
using WMS.CustomControls;

namespace WMS.Components
{
    public partial class WMSGroup : WMSGrid
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

		public WMSGroup()
        {
            InitializeComponent();

            BindingContext = this;
            vwHeader.BindingContext = this;
        }
    }
}
