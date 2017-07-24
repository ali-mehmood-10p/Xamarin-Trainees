using System;
using System.Collections.Generic;
using System.Windows.Input;
using WMS.ViewModels;
using Xamarin.Forms;
using WMS.Utils;
using WMS.Pages;
using WMS.Interfaces;
using System.Runtime.InteropServices.WindowsRuntime;
using Xamarin.Forms.PlatformConfiguration;

namespace WMS.Pages
{
    public partial class LoginPage : BaseContentPage, IWMSPageFonts, IWMSPageBinding
    {
        LoginPageViewModel viewModel;

        public LoginPage()
        {
            InitializeComponent();

            ConfigureFonts();
            ConfigurePageBinding();

            RegisterCheckBoxCallBacks();
        }

        public void ConfigurePageBinding()
        {
            viewModel = new LoginPageViewModel()
            {
                OnActionCompletionCallback = new Command(ValidationSuccessful),
                OnActionFailedCallback = new Command(ValidationFailed)
            };

            BindingContext = viewModel;

            txtID.ExternalDataBinding = viewModel;
            txtPassword.ExternalDataBinding = viewModel;
        }

        public void ConfigureFonts()
        {
            if (Device.Idiom == TargetIdiom.Phone)
            {
                chkRememberMe.DescriptionFontSize = 14;
                LogoView.DescriptionFontSize = 50;

                btnForgotPassword.FontSize = 17;
                btnNotACustomer.FontSize = 14;
            }
            else
            {
                chkRememberMe.DescriptionFontSize = 22;
                LogoView.DescriptionFontSize = 80;
                lblSignIn.FontSize = 22;

                if(Device.RuntimePlatform == Device.iOS)
                {
					btnMakeAppointment.FontSize = 26;
					btnLogin.FontSize = 26;                    
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
					btnLogin.FontSize = 22;
					btnMakeAppointment.FontSize = 22;                    
                }

                btnForgotPassword.FontSize = 22;
                btnNotACustomer.FontSize = 22;
                txtID.DescriptionFontSize = 30;
                txtPassword.DescriptionFontSize = 30;
			}
		}

        void RegisterCheckBoxCallBacks()
        {
            chkRememberMe.CheckBoxCommand = new Command((obj) =>
            {

            });
        }

        void NotACustomer_Clicked(object sender, System.EventArgs e)
        {

        }

        void ForgotPassword_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ForgotPasswordPage());
        }

        void MakeAnAppointment_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new MakeAppointmentPage());
        }

        void ValidationSuccessful()
        {
            DisplayAlert("Info", "Login successful", "OK").ContinueWith((args) =>
            {

            });
        }

        void ValidationFailed(object errorMessage)
        {
            if (errorMessage != null && errorMessage is string)
            {
                DisplayAlert("Error", errorMessage as string, "Ok");
            }
        }
    }
}
