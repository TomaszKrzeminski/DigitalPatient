using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{
    public class AddTaskToUserModel
    {
        public string UserId { get; set; }
        public string DoctorId { get; set; }

        public TaskToDo tasktoDo { get; set; }


    }
}
