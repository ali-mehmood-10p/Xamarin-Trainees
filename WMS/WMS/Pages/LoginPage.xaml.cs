using System;
using System.Collections.Generic;
using System.Windows.Input;
using WMS.ViewModels;
using Xamarin.Forms;
using WMS.Utils;
using WMS.Pages;
using WMS.Interfaces;
using System.Runtime.InteropServices.WindowsRuntime;

namespace WMS.Pages
{
    public partial class LoginPage : BaseContentPage
    {
        LoginPageViewModel viewModel;

        public LoginPage()
        {
            InitializeComponent();

            ConfigurePageBinding();
            RegisterCheckBoxCallBacks();
        }

        void ConfigurePageBinding()
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
            if(errorMessage != null && errorMessage is string)
            {
                DisplayAlert("Error", errorMessage as string, "Ok");  
            }
		}
    }
}
