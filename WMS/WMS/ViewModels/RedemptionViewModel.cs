using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace WMS.ViewModels
{
    public class RedemptionViewModel : INotifyPropertyChanged
    {
        string accountID = "";
        string timeString = "";

        public string AccountID
        {
            get
            {
                return accountID;
            }
            set
            {
                accountID = value;
                OnPropertyChanged("AccountID");
            }
        }
        public string TimeString
        {
            get
            {
                return timeString;
            }
            set
            {
                timeString = value;
				OnPropertyChanged("TimeString");
            }
        }

        public RedemptionViewModel()
        {

        }

        public void ReadHeaderData()
        {
            AccountID = "00012345-6";
            TimeString = "12:55:59 PM";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
