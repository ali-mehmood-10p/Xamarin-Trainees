using System;
using System.Collections.Generic;
using Xamarin.Forms;
using WMS.Utils;

namespace WMS.Components
{
    public enum TypeOfService
    {
        MutualFunds,
        InvestmentPlans,
        MutualFundsAndInvestmentPlans
    }

    public partial class WMSTypeOfScheme : BaseContentView
    {
		WMSRadioButtonsGroupManager rdGroupManager;
        TypeOfService typeOfService;

        public WMSTypeOfScheme()
        {
            InitializeComponent(); 

            rdGroupManager = new WMSRadioButtonsGroupManager();
            ConfigureTypeOfService();
        }

		public void SetDefaultTypeOfService()
		{
			rdGroupManager.Add(rdMutualFunds);
			rdGroupManager.Add(rdInvestmentPlans);
			rdGroupManager.Add(rdMutalAndInvestments);

			rdGroupManager.SelectRadioButton(rdMutualFunds);
		}

        void ConfigureTypeOfService()
        {
            rdMutualFunds.ExternalCommand = new Command(() =>
            {
                rdGroupManager.SelectRadioButton(rdMutualFunds);
                typeOfService = TypeOfService.MutualFunds;
            });

			rdInvestmentPlans.ExternalCommand = new Command(() =>
			{
				rdGroupManager.SelectRadioButton(rdInvestmentPlans);
				typeOfService = TypeOfService.InvestmentPlans;
			});

			rdMutalAndInvestments.ExternalCommand = new Command(() =>
			{
				rdGroupManager.SelectRadioButton(rdMutalAndInvestments);
				typeOfService = TypeOfService.MutualFundsAndInvestmentPlans;
			});
        }

        public TypeOfService GetSelectedTypeOfService()
        {
            return typeOfService;
        }
    }
}
