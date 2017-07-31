using System;
using System.Collections.Generic;

using Xamarin.Forms;
using WMS.Components;

namespace WMS.Views
{
    public partial class RedemptionPage : BaseContentPage
    {
        public RedemptionPage()
        {
            InitializeComponent();

            Title = "REQUEST FOR REDEMPTION";

            BindingContext = this;

        }
    }
}
