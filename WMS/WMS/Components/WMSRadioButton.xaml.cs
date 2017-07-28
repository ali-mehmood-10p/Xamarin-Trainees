using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace WMS.Components
{
	public partial class WMSRadioButton : BaseContentView
	{
		public RadioButtonState state { get; set; }

		public static readonly BindableProperty SelectedImageNameProperty = BindableProperty.Create("SelectedImageName", typeof(string), typeof(string), null);
		public string SelectedImageName
		{
			get { return (string)GetValue(SelectedImageNameProperty); }
			set
			{
				SetValue(SelectedImageNameProperty, value);
			}
		}

		public static readonly BindableProperty UnSelectedImageNameProperty = BindableProperty.Create("UnSelectedImageName", typeof(string), typeof(string), null);
		public string UnSelectedImageName
		{
			get { return (string)GetValue(UnSelectedImageNameProperty); }
			set
			{
				SetValue(UnSelectedImageNameProperty, value);
			}
		}

		public static readonly BindableProperty GroupIDProperty = BindableProperty.Create("GroupID", typeof(string), typeof(string), null);
		public string GroupID
		{
			get { return (string)GetValue(GroupIDProperty); }
			set
			{
				SetValue(GroupIDProperty, value);
			}
		}

		void RadioButton_Clicked(object sender, System.EventArgs e)
		{
			if (ExternalCommand != null)
			{
				ExternalCommand.Execute(null);
			}
		}

		public void SetStateTo(RadioButtonState state)
		{
			if (state == RadioButtonState.RadioButtonStateSelected)
			{
				if (SelectedImageName != null)
				{
					imageRadio.Source = SelectedImageName;
				}
			}
			else
			{
				if (UnSelectedImageName != null)
				{
					imageRadio.Source = UnSelectedImageName;
				}
			}

			this.state = state;
		}

		public WMSRadioButton()
		{
			InitializeComponent();
		}
	}

	public enum RadioButtonState
	{
		RadioButtonStateUnSelected,
		RadioButtonStateSelected
	}
}
