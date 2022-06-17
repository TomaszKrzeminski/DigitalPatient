using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{

    public enum Color
    {
        success,warning,danger
    }



    public class DayEvent
    {



        public DayEvent()
        {

        }


        public DayEvent(int Max ,int Done,string DateValue,string DateName,DateTime EventDate)
        {
            this.Max = Max;
            this.Done = Done;
            this.color = CheckColor(Done, Max);
            this.DateValue = DateValue;
            this.DayName = DateName;
            this.EventDate = EventDate;

        }


        public DayEvent(int Max, int Done, string DateValue, string DateName)
        {
            this.Max = Max;
            this.Done = Done;
            this.color = CheckColor(Done, Max);
            this.DateValue = DateValue;
            this.DayName = DateName;
            this.EventDate = EventDate;

        }



        public int DayEventId{get;set;}
        public string Note { get; set; }

        public Color CheckColor(double done,double max)
        {
            //Color color;

            double x = done / max;

            if(x==1)
            {
                color = Color.success;
            }
            else if(x>=0.5)
            {
                color = Color.warning;
            }
            else
            {
                color = Color.danger;
            }
            return color;
        }

        public void CheckIfToday()
        {
            DateTime now = DateTime.Now;

            if(now.Date==EventDate.Date)
            {
                DayIsToday = true;
            }

        }

        public bool DayIsToday { get; set; } = false;

        public DateTime EventDate { get; set; } = new DateTime(1900,1,1);
        public DateTime FromDate { get; set; } = new DateTime(1900, 1, 1);
        public DateTime ToDate { get; set; } = new DateTime(1900, 1, 1);
        public string DateValue { get; set; }
        public string DayName { get; set; }
        public string Message { get; set; }

        public int Done { get; set; }
        public int Max { get; set; }
       
        public Color color { get; set; }



    }


    public class Week
    {
        public List<DayEvent> Dates { get; set; } = new List<DayEvent>();

    }




}
