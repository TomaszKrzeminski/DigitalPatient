using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{

    public class TaskToDoActionModel
    {
        public TaskToDoActionModel()
        {
            taskToDo = new TaskToDo();
            mpToAdd = new MeasurementPair();
        }

        public  TaskToDo taskToDo {get;set;}

       public MeasurementPair mpToAdd { get; set; }

        public DateTime ActionTime { get; set; }

        public DateTime TaskCorrectTime { get; set; }
    }

    public class FullHours
    {
        public List<Hour> Hours = new List<Hour>() { };
        public int HourTasks{ get; set; }

        public FullHours()
        {
            for (int i = 1; i < 24; i++)
            {
                Hours.Add(new Hour(i));
            }

            Hours.Add(new Hour(0));

        }


    }
    public class Minute
    {
        public int MinuteTime { get; set; }

        public Minute(int MinuteTime)
        {
            this.MinuteTime = MinuteTime;
            Tasks = new List<TaskToDo>();
        }
        public List<TaskToDo> Tasks { get; set; }

    }   
    public class Hour
    {
       public Hour()
        {
            minutes = new List<Minute>();
            for (int i = 0; i <= 59; i++)
            {
                minutes.Add(new Minute(i));
            }
        }

        public Hour(int HourTime)
        {
            this.HourTime = HourTime;

            minutes = new List<Minute>();
            for (int i = 0; i < 59; i++)
            {
                minutes.Add(new Minute(i));
            }


        }

        public int HourTasks { get; set; }
        public int HourTime { get; set; }
        public List<Minute> minutes { get; set; }        

    }



    





}
