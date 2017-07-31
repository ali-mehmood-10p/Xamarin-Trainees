using System;
using Xamarin.Forms;

namespace WMS.Interfaces
{
    public interface IWMSExternalNotifyPropertyChange
    {
        void PostUpdatesToDataBinding(object propertyValue);
    }
}
