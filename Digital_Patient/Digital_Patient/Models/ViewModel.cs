using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{
  public class  MainPageViewModel
    {

        public MainPageViewModel(string UserId)
        {
            this.UserId = UserId;
        }

        public string UserId { get; set; }

    }
}
