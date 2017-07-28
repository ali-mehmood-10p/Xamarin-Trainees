using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.ComponentModel;
using WMS.CustomControls;

namespace WMS.Components
{
    public partial class WMSGroup : WMSGrid
    {
        public static readonly BindableProperty MainContentProperty = BindableProperty.Create("MainContent", typeof(ContentView), typeof(ContentView), null);
		public ContentView MainContent
		{
			get { return (ContentView)GetValue(MainContentProperty); }
			set
			{
				SetValue(MainContentProperty, value);
                ContentTemplate = value;
			}
		}

        public WMSGroup()
        {
            InitializeComponent();

            BindingContext = this;

            //MainContent = new WMSTypeOfScheme();
            //OnPropertyChanged("MainContent");
        }
    }
}
