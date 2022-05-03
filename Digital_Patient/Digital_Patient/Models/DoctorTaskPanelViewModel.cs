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
       public string UserId { get; set; }

    }
}
