using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{
    public class DoctorTaskPanelViewModel
    {

        public DoctorTaskPanelViewModel(string UserId)
        {
            this.UserId = UserId;
        }


        public DoctorTaskPanelViewModel(string UserId,string Cookie1)
        {
            this.UserId = UserId;
            this.Cookie1 = Cookie1;
        }

        public string UserId { get; set; }
        public string Cookie1 { get; set; }

    }
}
