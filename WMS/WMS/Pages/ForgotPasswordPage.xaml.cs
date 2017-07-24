using System;
using System.Collections.Generic;
using WMS.Pages;

using Xamarin.Forms;
using WMS.ViewModels;
using WMS.Utils;
using WMS.Interfaces;

namespace WMS.Pages
{
    public partial class ForgotPasswordPage : BaseContentPage, IWMSPageFonts, IWMSPageBinding
    {
        ForgotPasswordPageViewModel viewModel;

        public ForgotPasswordPage()
        {
            InitializeComponent();

			ConfigureFonts();
			ConfigurePageBinding();
        }

        public void ConfigurePageBinding()
        {
            viewModel = new ForgotPasswordPageViewModel()
            {
                OnActionCompletionCallback = new Command(OnResetCompletion),
                OnActionFailedCallback = new Command(OnCancelled)
            };
            BindingContext = viewModel;

            txtEmail.ExternalDataBinding = viewModel;
            txtCNIC.ExternalDataBinding = viewModel;
        }

        public void ConfigureFonts()
		{
			if (Device.Idiom == TargetIdiom.Phone)
			{
				LogoView.DescriptionFontSize = 50;
                lblPageDescription.FontSize = 16;
                btnReset.FontSize = 20;
                btnCancel.FontSize = 20;
			}
			else
			{
				LogoView.DescriptionFontSize = 80;
                lblPageDescription.FontSize = 22;

				if (Device.RuntimePlatform == Device.iOS)
				{
					btnReset.FontSize = 26;
					btnCancel.FontSize = 26;
				}
				else if (Device.RuntimePlatform == Device.Android)
				{
					btnReset.FontSize = 22;
					btnCancel.FontSize = 22;
				}

                txtCNIC.DescriptionFontSize = 30;
                txtEmail.DescriptionFontSize = 30;
			}
		}

		void OnResetCompletion()
        {
            DisplayAlert("Info", "Password reset link has been sent to your given email address", "OK").ContinueWith((args) =>
            {
                this.Navigation.RemovePage(this);
            });
        }

        void OnCancelled(object errorMessage)
        {
            if (errorMessage != null && errorMessage is string)
            {
                if (WMSConstants.BUTTON_ACTION_CANCELLED_TEXT_IDENTIFIER == errorMessage as string)
                {
                    this.Navigation.RemovePage(this);
                }
                else
                {
                    DisplayAlert("Error", errorMessage as string, "OK").ContinueWith((args) =>
                    {

                    });
                }
            }
        }
    }
}
