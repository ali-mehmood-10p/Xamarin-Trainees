using System;
using System.Windows.Input;

namespace WMS.Interfaces
{
    public interface IWMSServicesProvider
    {
		ICommand PhoneCallCommandRequest { get; set; }
		ICommand SMSCommandRequest { get; set; }
		ICommand PurchaseCommandRequest { get; set; }
    }
}
