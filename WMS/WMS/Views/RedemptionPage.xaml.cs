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
        WMSRadioButtonsGroupManager rdGroupManager;
        RedemptionViewModel viewModel;

        public RedemptionPage()
        {
            InitializeComponent();

            ConfigurePage();

            viewModel.ReadHeaderData();

        }

        void ConfigurePage()
        {
			Title = "REQUEST FOR REDEMPTION";

            viewModel = new RedemptionViewModel();

			BindingContext = viewModel;
            vwHeader.BindingContext = viewModel;

			rdGroupManager = new WMSRadioButtonsGroupManager();

            vwTypeOfScheme.SetDefaultTypeOfService();
            vwRedemptionDetails.SetDefaultRedemptionDetails();
        }

    }
}
