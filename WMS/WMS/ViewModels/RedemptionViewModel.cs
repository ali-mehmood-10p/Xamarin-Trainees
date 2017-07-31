using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using WMS.Interfaces;

namespace WMS.ViewModels
{
    public class RedemptionViewModel : INotifyPropertyChanged, IScheme
    {
        string accountID = "";
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

        string timeString = "";
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

        List<string> sourceCollection;
        public List<string> SourceCollection
        {
            get
            {
                return sourceCollection;
            }
            set
            {
                sourceCollection = value;
                OnPropertyChanged("SourceCollection");
            }
        }

        string city = "";
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }

		string cutOffTime = "";
		public string CutOffTime
		{
			get
			{
				return cutOffTime;
			}
			set
			{
				cutOffTime = value;
				OnPropertyChanged("CutOffTime");
			}
		}

		string totalUnit = "";
		public string TotalUnit
		{
			get
			{
				return totalUnit;
			}
			set
			{
				totalUnit = value;
				OnPropertyChanged("TotalUnit");
			}
		}

		string investmentAmount = "";
		public string InvestmentAmount
		{
			get
			{
				return investmentAmount;
			}
			set
			{
				investmentAmount = value;
				OnPropertyChanged("InvestmentAmount");
			}
		}

		public ICommand OnAddSchemeCallback { get; set; }
		public ICommand AddSchemeCommand => new Command((obj) =>
											{
                                                // Validate if needed and fire callback
												if (OnAddSchemeCallback != null)
												{
													OnAddSchemeCallback.Execute(null);
												}
											});

		public ICommand OnRemoveSchemeCallback { get; set; }
		public ICommand RemoveScemeCommand => new Command((obj) =>
                                            {
												// Validate if needed and fire callback
												if (OnRemoveSchemeCallback != null)
                                                {
                                                    OnRemoveSchemeCallback.Execute(null);
                                                }
                                            });

        public RedemptionViewModel()
        {
            PrepareSchemeDataSource();
        }

        public void ReadHeaderData()
        {
            AccountID = "00012345-6";
            TimeString = "12:55:59 PM";

            CutOffTime = "50 seconds";
            TotalUnit = "100";
            InvestmentAmount = "$500";
        }

        void PrepareSchemeDataSource()
        {
			SourceCollection = new List<string>();
			SourceCollection.AddRange(new string[] { "Scheme-001", "Scheme-002", "Scheme-003", "Scheme-004" });
        }

		public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
