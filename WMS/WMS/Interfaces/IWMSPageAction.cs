using System;
using System.Windows.Input;

namespace WMS.Interfaces
{
    public interface IWMSPageAction
    {
		ICommand OnActionCompletionCallback { get; set; }
		ICommand OnActionFailedCallback { get; set; }
    }
}
