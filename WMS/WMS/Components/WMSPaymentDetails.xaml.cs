using System;
using System.Collections.Generic;
using WMS.Utils;
using Xamarin.Forms;

namespace WMS.Components
{
	public enum PaymentOptions
	{
		Cheque,
        DemandDraft,
		PayOrder,
        OnlineTransfer
	}

	public partial class WMSPaymentDetails : BaseContentView
    {
		WMSRadioButtonsGroupManager rdGroupManager;
		PaymentOptions paymentOption;

		public WMSPaymentDetails()
        {
            InitializeComponent();

			rdGroupManager = new WMSRadioButtonsGroupManager();
			ConfigurePaymentOptions();
		}

		public void SetDefaultTypeOfService()
		{
            rdGroupManager.Add(rdCheque);
			rdGroupManager.Add(rdPayOrder);
			rdGroupManager.Add(rdDemandDraft);
			rdGroupManager.Add(rdOnlineTransfer);

			rdGroupManager.SelectRadioButton(rdCheque);
		}

		void ConfigurePaymentOptions()
		{
			rdCheque.ExternalCommand = new Command(() =>
			{
				rdGroupManager.SelectRadioButton(rdCheque);
				paymentOption = PaymentOptions.Cheque;
			});

			rdPayOrder.ExternalCommand = new Command(() =>
			{
				rdGroupManager.SelectRadioButton(rdPayOrder);
				paymentOption = PaymentOptions.PayOrder;
			});

			rdDemandDraft.ExternalCommand = new Command(() =>
			{
				rdGroupManager.SelectRadioButton(rdDemandDraft);
                paymentOption = PaymentOptions.DemandDraft;
			});

			rdOnlineTransfer.ExternalCommand = new Command(() =>
			{
				rdGroupManager.SelectRadioButton(rdOnlineTransfer);
                paymentOption = PaymentOptions.OnlineTransfer;
			});
		}

		public PaymentOptions GetSelectedPaymentOptions()
		{
			return paymentOption;
		}
	}
}
