using System;
namespace WMS.Interfaces
{
    public interface IWMSExternalNotifyPropertyChange
    {
        void PostUpdatesToDataBinding(object propertyValue);
    }
}
