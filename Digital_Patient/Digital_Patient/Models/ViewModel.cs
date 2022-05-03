using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{
  public class  MainPageViewModel
    {

        public MainPageViewModel(string UserId,string Role)
        {
            this.UserId = UserId;
            this.Role = Role;
        }

        public string UserId { get; set; }
        public string Role { get; set; }

    }
}
