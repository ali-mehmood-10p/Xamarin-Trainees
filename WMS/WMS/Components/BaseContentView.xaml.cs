using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;
using WMS.Interfaces;
using System.Linq;
using Xamarin.Forms;

namespace WMS.Components
{
	public partial class BaseContentView : ContentView, IWMSExternalNotifyPropertyChange
	{
		protected PropertyInfo bindedPropertyInfo;

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

		public static readonly BindableProperty ExternalDataBindingProperty = BindableProperty.Create("ExternalDataBinding", typeof(object), typeof(object), null);
		public object ExternalDataBinding
		{
			get { return GetValue(ExternalDataBindingProperty); }
			set
			{
				SetValue(ExternalDataBindingProperty, value);
			}
		}

		public static readonly BindableProperty ExternalDataBindingPropertyNameProperty = BindableProperty.Create("ExternalDataBindingPropertyName", typeof(string), typeof(string), null);
		public string ExternalDataBindingPropertyName
		{
			get { return (string)GetValue(ExternalDataBindingPropertyNameProperty); }
			set
			{
				SetValue(ExternalDataBindingPropertyNameProperty, value);
			}
		}

		public static readonly BindableProperty ExternalCommandProperty = BindableProperty.Create("ExternalLinkCommand", typeof(ICommand), typeof(ICommand), null);
		public ICommand ExternalCommand
		{
			get { return (ICommand)GetValue(ExternalCommandProperty); }
			set
			{
				SetValue(ExternalCommandProperty, value);
			}
		}

		public BaseContentView()
		{
			InitializeComponent();
			BindingContext = this;
		}

		public virtual void PostUpdatesToDataBinding(object propertyValue)
		{
			if (ExternalDataBinding != null)
			{
				if (bindedPropertyInfo == null)
				{
					bindedPropertyInfo = ExternalDataBinding.GetType().GetRuntimeProperties().Where((c) => c.Name == ExternalDataBindingPropertyName).FirstOrDefault();
				}

				if (bindedPropertyInfo != null)
				{
					bindedPropertyInfo.SetValue(ExternalDataBinding, propertyValue);
				}
			}
		}
	}
}
