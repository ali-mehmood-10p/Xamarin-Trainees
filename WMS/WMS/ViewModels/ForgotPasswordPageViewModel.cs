using System;
using System.Windows.Input;
using Xamarin.Forms;
using WMS.Utils;
using System.ComponentModel;
using WMS.Cache;

namespace WMS.ViewModels
{
    public class ForgotPasswordPageViewModel : BasePageViewModel, INotifyPropertyChanged
    {
		public string EmailAddress { get; set; }
		public string CNIC { get; set; }
		public string ErrorMessage { get; set; }

		public ICommand OnResetPassword_Clicked => new Command((obj) =>
		{
			if (HasValidDataInFields())
			{
				OnActionCompletionCallback.Execute(null);
			}
			else
			{
                OnActionFailedCallback.Execute(ErrorMessage);
			}
		});

		public ICommand OnCancel_Clicked => new Command((obj) =>
		{
            OnActionFailedCallback.Execute(WMSConstants.BUTTON_ACTION_CANCELLED_TEXT_IDENTIFIER);
		});

        Boolean HasValidDataInFields()
		{
			if (string.IsNullOrEmpty(EmailAddress))
			{
                ErrorMessage =  WMSErrorsCache.ERROR_STRING_MISSING_EMAIL_ADDRESS;
				return false;
			}

            if(!WMSFieldValidator.IsEmailAddressValid(EmailAddress))
            {
				ErrorMessage = WMSErrorsCache.ERROR_STRING_INVALID_EMAIL_ADDRESS;
				return false;
            }

			if (string.IsNullOrEmpty(CNIC))
			{
				ErrorMessage = WMSErrorsCache.ERROR_STRING_MISSING_CNIC;
				return false;
			}

            if (!WMSFieldValidator.IsCNICValid(CNIC))
			{
				ErrorMessage = WMSErrorsCache.ERROR_STRING_INVALID_CNIC;
				return false;
			}

			return true;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

    }
}
