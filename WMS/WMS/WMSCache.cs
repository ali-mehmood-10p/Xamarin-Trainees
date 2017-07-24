using System;

using Xamarin.Forms;

namespace WMS
{
    public class WMSCache : ContentPage
    {
        public WMSCache()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

