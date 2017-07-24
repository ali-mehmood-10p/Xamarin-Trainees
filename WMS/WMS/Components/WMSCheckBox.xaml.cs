using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace WMS.Components
{
    public partial class WMSCheckBox : BaseContentView
    {
        public CheckBoxState state { get; set; }

		public static readonly BindableProperty CheckedImageNameProperty = BindableProperty.Create("CheckedImageName", typeof(string), typeof(string), null);
		public string CheckedImageName
		{
			get { return (string)GetValue(CheckedImageNameProperty); }
			set
			{
				SetValue(CheckedImageNameProperty, value);
			}
		}

		public static readonly BindableProperty UnCheckedImageNameProperty = BindableProperty.Create("UnCheckedImageName", typeof(string), typeof(string), null);
		public string UnCheckedImageName
		{
			get { return (string)GetValue(UnCheckedImageNameProperty); }
			set
			{
				SetValue(UnCheckedImageNameProperty, value);
			}
		}

		public static readonly BindableProperty CheckBoxCommandProperty = BindableProperty.Create("CheckBoxCommand", typeof(ICommand), typeof(ICommand), null);
		public ICommand CheckBoxCommand
		{
			get { return (ICommand)GetValue(CheckBoxCommandProperty); }
			set
			{
				SetValue(CheckBoxCommandProperty, value);
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

		void CheckBox_Clicked(object sender, System.EventArgs e)
		{
			if (CheckBoxCommand != null)
			{
                CheckBoxStateChanged();
				CheckBoxCommand.Execute(null);
			}
		}

		public void CheckBoxStateChanged()
		{
            ToggleState();
            UpdateState();
		}

        void ToggleState()
        {
			if (state == CheckBoxState.CheckBoxStateChecked)
			{
                state = CheckBoxState.CheckBoxStateUnChecked;
			}
			else
			{
				state = CheckBoxState.CheckBoxStateChecked;
			}
        }

        void UpdateState()
        {
			if (state == CheckBoxState.CheckBoxStateChecked)
			{
				if (CheckedImageName != null)
				{
					chkBox.Source = CheckedImageName;
				}
			}
			else
			{
				if (UnCheckedImageName != null)
				{
					chkBox.Source = UnCheckedImageName;
				}
			}
        }

		public WMSCheckBox()
        {
            InitializeComponent();
		}
	}

	public enum CheckBoxState
	{
		CheckBoxStateUnChecked,
		CheckBoxStateChecked
	}
}
