using System;
using System.Windows.Input;

namespace WMS.Interfaces
{
    public interface IScheme
    {
		ICommand OnAddSchemeCallback { get; set; }
		ICommand OnRemoveSchemeCallback { get; set; }
    }
}
