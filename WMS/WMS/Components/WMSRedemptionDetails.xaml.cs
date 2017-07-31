using System;
using System.Collections.Generic;
using Xamarin.Forms;
using WMS.Utils;

namespace WMS.Components
{
    public enum TypeOfWithdrawal
	{
		WithdrawalTypeAmount,
		WithdrawalTypePercentage,
		WithdrawalTypeUnits
	}

    public partial class WMSRedemptionDetails : BaseContentView
    {
        WMSRadioButtonsGroupManager rdGroupManager;
        TypeOfWithdrawal typeOfWithdrawal;

		public WMSRedemptionDetails()
        {
            InitializeComponent();

			rdGroupManager = new WMSRadioButtonsGroupManager();
            ConfigureTypeOfWithdrawal();
        }

		public void SetDefaultRedemptionDetails()
		{
			rdGroupManager.Add(rdUnits);
			rdGroupManager.Add(rdAmount);
			rdGroupManager.Add(rdPercentage);

			rdGroupManager.SelectRadioButton(rdAmount);
		}

		void ConfigureTypeOfWithdrawal()
		{
			rdUnits.ExternalCommand = new Command(() =>
			{
				rdGroupManager.SelectRadioButton(rdUnits);
                typeOfWithdrawal = TypeOfWithdrawal.WithdrawalTypeUnits;
			});

			rdAmount.ExternalCommand = new Command(() =>
			{
				rdGroupManager.SelectRadioButton(rdAmount);
                typeOfWithdrawal = TypeOfWithdrawal.WithdrawalTypeAmount;
			});

			rdPercentage.ExternalCommand = new Command(() =>
			{
				rdGroupManager.SelectRadioButton(rdPercentage);
                typeOfWithdrawal = TypeOfWithdrawal.WithdrawalTypePercentage;
			});
		}

		public TypeOfWithdrawal GetSelectedTypeOfWithdrawal()
		{
			return typeOfWithdrawal;
		}
    }
}
