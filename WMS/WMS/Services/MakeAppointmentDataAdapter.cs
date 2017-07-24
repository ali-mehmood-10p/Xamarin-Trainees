using System;
using System.Collections.Generic;
namespace WMS.Services
{
    public class MakeAppointmentDataAdapter
    {
        public MakeAppointmentDataAdapter()
        {
            
        }

        public List<string> FillHearAboutUsData()
        {
            return new List<string>(new string[] {
                "Friend, Family, Co-worker",
                "Email",
                "LinkedIn",
                "Facebook",
                "Twitter"
            });
        }
    }
}
