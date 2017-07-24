using System;
using System.ComponentModel;
using System.Collections.Generic;

using Xamarin.Forms;
using WMS.Services;
using System.Windows.Input;
using WMS.Interfaces;
using WMS.Cache;

namespace WMS.ViewModels
{
    public class MakeAppointmentPageViewModel : BasePageViewModel, INotifyPropertyChanged
    {
        public List<string> HearAboutUsCollection { get; set; }

        public string Name { get; set; }
		public string ContactNo { get; set; }
		public string EmaillAddress { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public string ErrorMessage { get; set; }

        MakeAppointmentDataAdapter dataAdapater;

        public ICommand OnSubmit_Clicked => new Command((obj) =>
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

        bool HasValidDataInFields()
        {
			if (string.IsNullOrEmpty(Name))
			{
				ErrorMessage = WMSErrorsCache.ERROR_STRING_MISSING_NAME;
				return false;
			}

            if (string.IsNullOrEmpty(ContactNo))
			{
				ErrorMessage = WMSErrorsCache.ERROR_STRING_MISSING_CONTACT_NO;
				return false;
			}

            if (string.IsNullOrEmpty(EmaillAddress))
			{
				ErrorMessage = WMSErrorsCache.ERROR_STRING_MISSING_EMAIL_ADDRESS;
				return false;
			}

            if (string.IsNullOrEmpty(Country))
			{
				ErrorMessage = WMSErrorsCache.ERROR_STRING_MISSING_COUNTRY;
				return false;
			}

			if (string.IsNullOrEmpty(City))
			{
				ErrorMessage = WMSErrorsCache.ERROR_STRING_MISSING_CITY;
				return false;
			}

            return true;
        }

        public MakeAppointmentPageViewModel()
        {
			HearAboutUsCollection = new List<string>();

            ConfigureData();
        }

        void ConfigureData()
        {
			dataAdapater = new MakeAppointmentDataAdapter();
			HearAboutUsCollection.AddRange(dataAdapater.FillHearAboutUsData().ToArray());
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

