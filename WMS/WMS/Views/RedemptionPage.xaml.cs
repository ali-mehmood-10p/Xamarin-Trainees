using System;
using System.Collections.Generic;

using Xamarin.Forms;
using WMS.Components;
using WMS.Utils;
using WMS.ViewModels;

namespace WMS.Views
{
    public partial class RedemptionPage : BaseContentPage
    {
        RedemptionViewModel viewModel;

        public RedemptionPage()
        {
            InitializeComponent();

            ConfigurePage();

            ConfigureBindings();

            ConfigureDefaultServices();

            viewModel.ReadHeaderData();
        }

        void ConfigurePage()
        {
			Title = "REQUEST FOR REDEMPTION";

            viewModel = new RedemptionViewModel()
            {
                OnAddSchemeCallback = new Command(AddSchemeCommandHandler),
			    OnRemoveSchemeCallback = new Command(RemoveSchemeCommandHandler) 
            };

			BindingContext = viewModel;
        }

        void ConfigureBindings()
        {
			vwHeader.BindingContext = viewModel;
			vwTypeOfScheme.BindingContext = viewModel;
			vwRedemptionDetails.BindingContext = viewModel;
			vwPaymentDetails.BindingContext = viewModel;
        }

        void ConfigureDefaultServices()
        {
			vwTypeOfScheme.SetDefaultTypeOfService();
			vwRedemptionDetails.SetDefaultRedemptionDetails();
			vwPaymentDetails.SetDefaultTypeOfService();
        }

        void AddSchemeCommandHandler()
        {
            
        }

		void RemoveSchemeCommandHandler()
		{

		}

        void btnProceed_Clicked(object sender, System.EventArgs e)
        {
            
        }

        void btnCancel_Clicked(object sender, System.EventArgs e)
		{
	 
		}
    }
}
