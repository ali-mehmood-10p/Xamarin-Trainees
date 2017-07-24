using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using WMS.Cache;
using WMS.Utils;
using WMS.Interfaces;

namespace WMS.ViewModels
{
    public class LoginPageViewModel : BasePageViewModel, INotifyPropertyChanged
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }

        public ICommand OnLogin_Clicked => new Command((obj) =>
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

        Boolean HasValidDataInFields()
        {
            if (string.IsNullOrEmpty(UserName))
            {
                ErrorMessage = WMSErrorsCache.ERROR_STRING_MISSING_USER_NAME;
                return false;
            }

            if (string.IsNullOrEmpty(Password))
            {
                ErrorMessage = WMSErrorsCache.ERROR_STRING_MISSING_PASSWORD;
                return false;
            }

            if (!WMSFieldValidator.IsPasswordValid(Password))
            {
                ErrorMessage = WMSErrorsCache.ERROR_STRING_INVALID_PASSWORD;
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
