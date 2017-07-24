using System;
using System.Collections.Generic;
using WMS.Pages;
using WMS.ViewModels;
using Xamarin.Forms;
using WMS.Utils;

namespace WMS.Pages
{
    public partial class MakeAppointmentPage : BaseContentPage
    {
        MakeAppointmentPageViewModel viewModel;
        WMSRadioButtonsGroupManager radioButtonsManager;

        public MakeAppointmentPage()
        {
            InitializeComponent();

            ConfigurePageBinding();
            RegisterDidYouKnowViewCallBacks();
            ConfigureRadioButtons();
            RegisterRadioButtonCallBacks();
            SelectDefaultRadioButton();
        }

        void ConfigurePageBinding()
        {
            viewModel = new MakeAppointmentPageViewModel()
            {
                OnActionCompletionCallback = new Command(OnSubmissionCompletion),
                OnActionFailedCallback = new Command(OnFailed)
            };

            BindingContext = viewModel;
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
