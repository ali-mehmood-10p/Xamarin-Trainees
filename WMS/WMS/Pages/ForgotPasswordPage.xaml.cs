using System;
using System.Collections.Generic;
using WMS.Pages;

using Xamarin.Forms;
using WMS.ViewModels;
using WMS.Utils;

namespace WMS.Pages
{
    public partial class ForgotPasswordPage : BaseContentPage
    {
        ForgotPasswordPageViewModel viewModel;

        public ForgotPasswordPage()
        {
            InitializeComponent();
            ConfigurePageBinding();
        }

        void ConfigurePageBinding()
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
