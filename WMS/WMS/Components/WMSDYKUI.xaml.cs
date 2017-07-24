using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

namespace WMS.Components
{
    public partial class WMSDYKUI : BaseContentView
    {
		public static readonly BindableProperty LinkCommandWatchDemoProperty = BindableProperty.Create("LinkCommandWatchDemo", typeof(ICommand), typeof(ICommand), null);
		public ICommand LinkCommandWatchDemo
		{
			get { return (ICommand)GetValue(LinkCommandWatchDemoProperty); }
			set
			{
				SetValue(LinkCommandWatchDemoProperty, value);
                lblFAQs.ExternalCommand = this.LinkCommandWatchDemo;
			}
		}

		public static readonly BindableProperty LinkCommandDownloadWalkthroughProperty = BindableProperty.Create("LinkCommandDownloadWalkthrough", typeof(ICommand), typeof(ICommand), null);
		public ICommand LinkCommandDownloadWalkthrough
		{
			get 
            { 
                return (ICommand)GetValue(LinkCommandDownloadWalkthroughProperty); 
            }
			set
			{
				SetValue(LinkCommandDownloadWalkthroughProperty, value);
                lblWatchDemo.ExternalCommand = this.LinkCommandWatchDemo;
			}
		}

		public static readonly BindableProperty LinkCommandSeeFAQsProperty = BindableProperty.Create("LinkCommandSeeFAQs", typeof(ICommand), typeof(ICommand), null);
		public ICommand LinkCommandSeeFAQs
		{
			get 
            { 
                return (ICommand)GetValue(LinkCommandSeeFAQsProperty); 
            }
			set
			{
				SetValue(LinkCommandSeeFAQsProperty, value);
                lblDownloadWalkthroughs.ExternalCommand = this.LinkCommandWatchDemo;
			}
		}

		public WMSDYKUI()
        {
            InitializeComponent();
        }
    }
}
