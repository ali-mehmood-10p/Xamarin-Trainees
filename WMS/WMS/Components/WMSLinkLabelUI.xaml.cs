using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

using Xamarin.Forms;
using System.Windows.Input;

namespace WMS.Components
{
    public partial class WMSLinkLabelUI : BaseContentView
	{
        void LinkLabel_Clicked(object sender, System.EventArgs e)
        {
            if(ExternalCommand != null)
            {
                ExternalCommand.Execute(null);
            }
        }

        public WMSLinkLabelUI()
		{
			InitializeComponent();
		}
	}
}
