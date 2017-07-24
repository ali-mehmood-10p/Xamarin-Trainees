using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Xamarin.Forms;

namespace WMS.Components
{
    public partial class WMSLogoUI2 : ContentView
    {
		PropertyInfo bindedPropertyInfo;

		public static readonly BindableProperty TitleTextProperty = BindableProperty.Create("TitleText", typeof(string), typeof(string), null);
		public string TitleText
		{
			get { return (string)GetValue(TitleTextProperty); }
			set
			{
				SetValue(TitleTextProperty, value);
				PostUpdatesToDataBinding(value);
			}
		}

		public static readonly BindableProperty DataBindingProperty = BindableProperty.Create("DataBinding", typeof(object), typeof(object), null);
		public object DataBinding
		{
			get { return GetValue(DataBindingProperty); }
			set
			{
				SetValue(DataBindingProperty, value);
			}
		}

		public static readonly BindableProperty DataBindingPropertyNameProperty = BindableProperty.Create("DataBindingPropertyName", typeof(string), typeof(string), null);
		public string DataBindingPropertyName
		{
			get { return (string)GetValue(DataBindingPropertyNameProperty); }
			set
			{
				SetValue(DataBindingPropertyNameProperty, value);
			}
		}

        public WMSLogoUI2()
        {
            InitializeComponent();
			BindingContext = this;
		}

		void PostUpdatesToDataBinding(object propertyValue)
		{
			if (DataBinding != null)
			{
				if (bindedPropertyInfo == null)
				{
					bindedPropertyInfo = DataBinding.GetType().GetRuntimeProperties().Where((c) => c.Name == DataBindingPropertyName).FirstOrDefault();
				}

				if (bindedPropertyInfo != null)
				{
					bindedPropertyInfo.SetValue(DataBinding, propertyValue);
				}
			}
		}
    }
}
