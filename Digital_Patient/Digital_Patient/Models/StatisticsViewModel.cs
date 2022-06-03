using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{

    public class StatisticPairDigit
    {

        public StatisticPairDigit(string Name, double val1, double val2)
        {
            this.Name = Name;
            Val1 = val1;
            Val2 = val2;
        }

        public string Name { get; set; }
        public double Val1 { get; set; }
        public double Val2 { get; set; }
    }

    public class StatisticsCalendar
    {

    }

    public enum Status
    {
        Waiting, Done, NotMade
    }

    public class DayPairStats
    {

        public DayPairStats(DateTime time, Status status)
        {
            Time = time;
            Status = status;
        }

        public DateTime Time { get; set; }
        public Status Status { get; set; }
    }

    public class SelectedDayStatistics
    {

        public SelectedDayStatistics()
        {
            ListOfDayPairStats = new List<DayPairStats>();
        }

        public List<DayPairStats> ListOfDayPairStats { get; set; }


    }


    public class StatisticsViewModel
    {


        public StatisticsViewModel()
        {
            ListOfPatientsId = new List<string>();
            ListOfPatientsTasks = new List<TaskToDo>();
            StatisticsPairsDigits = new List<StatisticPairDigit>();
        }
        public DateTime Start { get; set; }

        public DateTime End { get; set; }
        public string SpecialMessage { get; set; } = "";

        public StatisticsCalendar calendar { get; set; }
        public string UserId { get; set; }
        public List<string> ListOfPatientsId { get; set; }
        public List<TaskToDo> ListOfPatientsTasks { get; set; }

        public List<StatisticPairDigit> StatisticsPairsDigits { get; set; }

    }
}
