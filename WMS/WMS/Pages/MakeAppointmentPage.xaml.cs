using System;
using System.Collections.Generic;
using WMS.Pages;
using WMS.ViewModels;
using Xamarin.Forms;
using WMS.Utils;
using WMS.Interfaces;
using System.Threading.Tasks;

namespace WMS.Pages
{
    public partial class MakeAppointmentPage : BaseContentPage, IWMSPageFonts, IWMSPageBinding
    {
        MakeAppointmentPageViewModel viewModel;
        WMSRadioButtonsGroupManager radioButtonsManager;

        public MakeAppointmentPage()
        {
            InitializeComponent();

			ConfigurePageBinding();
            ConfigureFonts();
			ConfigureRadioButtons();
			SelectDefaultRadioButton();
			LogoView.AdjustUIForSubHeader();
			RegisterDidYouKnowViewCallBacks();
			RegisterRadioButtonCallBacks();
        }

        public void ConfigurePageBinding()
        {
            viewModel = new MakeAppointmentPageViewModel()
            {
                OnActionCompletionCallback = new Command(OnSubmissionCompletion),
                OnActionFailedCallback = new Command(OnFailed)
            };

            BindingContext = viewModel;
        }

        public void ConfigureFonts()
        {
			if (Device.Idiom == TargetIdiom.Phone)
			{
                LogoView.DescriptionFontSize = 17;
				viewDidYouKnow.DescriptionFontSize = 17;
			}
			else
			{
                LogoView.DescriptionFontSize = 22;

				if (Device.RuntimePlatform == Device.iOS)
				{
					btnSubmit.FontSize = 26;
					btnCancel.FontSize = 26;
				}
				else if (Device.RuntimePlatform == Device.Android)
				{
					btnSubmit.FontSize = 22;
					btnCancel.FontSize = 22;
				}

                lblHowWouldYouLike.FontSize = 22;
                lblSelectDateTime.FontSize = 22;

                viewDidYouKnow.DescriptionFontSize = 20;
                rdCall.DescriptionFontSize = 20;
                rdEmail.DescriptionFontSize = 20;

                txtName.DescriptionFontSize = 22;
                txtCity.DescriptionFontSize = 22;
                txtCountry.DescriptionFontSize = 22;
                txtContactNo.DescriptionFontSize = 22;
                txtEmaillAddress.DescriptionFontSize = 22;
			}
        }

        void ConfigureRadioButtons()
        {
            radioButtonsManager = new WMSRadioButtonsGroupManager();
            radioButtonsManager.Add(rdCall);
            radioButtonsManager.Add(rdEmail);
        }

        void RegisterDidYouKnowViewCallBacks()
        {
            viewDidYouKnow.LinkCommandWatchDemo = new Command((obj) =>
            {
                Device.OpenUri(new Uri(WMSUrlHelper.WATCH_DEMO_URL_STRING));
            });

            viewDidYouKnow.LinkCommandDownloadWalkthrough = new Command((obj) =>
            {
                Device.OpenUri(new Uri(WMSUrlHelper.DOWNLOAD_WALKTHROUGH_URL_STRING));
            });

            viewDidYouKnow.LinkCommandSeeFAQs = new Command((obj) =>
            {
                Device.OpenUri(new Uri(WMSUrlHelper.SEE_FAQ_URL_STRING));
            });
        }

        void RegisterRadioButtonCallBacks()
        {
            rdCall.ExternalCommand = new Command((obj) =>
            {
                radioButtonsManager.SelectRadioButton(rdCall);
            });

            rdEmail.ExternalCommand = new Command((obj) =>
            {
                radioButtonsManager.SelectRadioButton(rdEmail);
            });
        }

        void SelectDefaultRadioButton()
        {
            radioButtonsManager.SelectRadioButton(rdEmail);
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        void Cancel_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.RemovePage(this);
        }

        void OnSubmissionCompletion()
        {
            DisplayAlert("Info", "Submitted", "OK").ContinueWith((args) =>
            {
                this.Navigation.RemovePage(this);
            });
        }

		void OnFailed(object errorMessage)
		{
			if (errorMessage != null && errorMessage is string)
			{
				DisplayAlert("Error", errorMessage as string, "Ok");
			}
		}
    }
	
}