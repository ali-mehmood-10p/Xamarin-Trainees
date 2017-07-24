using System;
using System.Windows.Input;
using WMS.Interfaces;

namespace WMS.ViewModels
{
    public class BasePageViewModel: IWMSPageAction
    {
		public ICommand OnActionCompletionCallback { get; set; }
		public ICommand OnActionFailedCallback { get; set; }

        public BasePageViewModel()
        {
            
        }
    }
}
