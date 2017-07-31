using System;
using System.Windows.Input;

namespace WMS.Interfaces
{
    public interface ISchemeServiceProvider
    {
		ICommand OnAddSchemeCallback { get; set; }
		ICommand OnRemoveSchemeCallback { get; set; }
    }
}
