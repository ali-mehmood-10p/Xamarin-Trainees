using System;
using Xamarin.Forms;
using System.ComponentModel;

namespace WMS.CustomControls
{
    public class WMSLabel: Label, INotifyPropertyChanged
    {
        public override Thickness Margin
        {
            get;
            set;
        }

        public WMSLabel()
        {
            
        }
    }
}
