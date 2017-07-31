using System;
namespace WMS.Interfaces
{
    public interface IWMSServices
    {
        void InvokeCallService();
        void InvokeSMSService();
        void InvokePaymentService();
    }
}
