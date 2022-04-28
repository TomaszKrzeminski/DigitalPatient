using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Digital_Patient.Models
{
    public enum Sex
    {
        Mężczyzna, Kobieta
    }

    public class   ApplicationUser:IdentityUser
    {

        public string FirstName { get; set; } = "Testowe 1";
        public string Surname { get; set; } = "Testowe 1";

        public Sex sex { get; set; } = Sex.Kobieta;
        public DateTime Dateofbirth { get; set; } = DateTime.Now;
        public string City { get; set; } = "Miasto";

        public string Street { get; set; } = "Ulica";

        public string PostalCode { get; set; } = "86-100";

        public string HouseNumber { get; set; } = "10";


        public override string PhoneNumber { get; set; } = "794219756";

        public string UserImagePath { get; set; } = "~/wwwroot/UserImages/DefaultUserPicture.jpg";

        /// <summary>
        public DateTime Breakfast { get; set; }
        public DateTime Lunch { get; set; }
        public DateTime Supper { get; set; }



        public ApplicationUser()
        {
            TasksToDo = new List<TaskToDo>();
            Breakfast = new DateTime(2022, 1, 1, 7, 0, 0);
            Lunch = new DateTime(2022, 1, 1, 13, 0, 0);
            Supper = new DateTime(2022, 1, 1, 19, 0, 0);



        }




        public virtual List<TaskToDo> TasksToDo { get; set; }
    }
    public class TaskToDo
    {
        public TaskToDo()
        {
            Measurements = new List<Measurement>();
        }
        public TaskToDo(string description)
        {
            Description = description;
            Measurements = new List<Measurement>();
        }
        public int TaskToDoId { get; set; }
        public string Description { get; set; } = "Nazwa Zadania";



        public string ApplicationUserId { get; set; }
        public  ApplicationUser ApplicationUser{get;set;}


        public int? TaskToDoCategoryId { get; set; }
        public virtual TaskToDoCategory TaskToDoCategory { get; set; }   

        public virtual IntervalData IntervalData { get; set; }
       
        public virtual List<Measurement> Measurements { get; set; }

    }
    public class TaskToDoCategory
    {

        public TaskToDoCategory()
        {
            TasksToDo = new List<TaskToDo>();
        }

        public int TaskToDoCategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<TaskToDo> TasksToDo { get; set; }


    }
    public class IntervalData
    {
      public int IntervalDataId { get; set; }


        public IntervalData()
        {
            Number = 999999;
            Weekends = true;
            Holidays = true;
            Interval = new TimeSpan(0, 0, 0);
        }


        


        public IntervalData(int Number,DateTime StartTime,DateTime EndTime,bool Weekends,bool Holidays)
        {
            this.Number = Number;           
            this.StartTime = StartTime;
            this.EndTime = EndTime;

           
            this.Weekends = Weekends;
            this.Holidays = Holidays;           
            this.CorrectTimes = new List<IntervalCorrectTime>();

        }
        public int Number { get; set; }

        public TimeSpan Interval { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        /// <summary>

        //public DateTime CorrectTime1 { get; set; } 
        //public DateTime CorrectTime2 { get; set; } 
        //public DateTime CorrectTime3 { get; set; } 
        //public DateTime CorrectTime4 { get; set; } 




        public bool Weekends { get; set; }
        public bool Holidays { get; set; }           
       

        public int? TaskToDoId { get; set; }
        public virtual TaskToDo TaskToDo { get; set; }

        public virtual List<IntervalCorrectTime> CorrectTimes { get; set; }

    }
    public class IntervalCorrectTime
    {

        public IntervalCorrectTime()
        {
            Time = new DateTime();
            IntervalCorrectTimeActions = new List<IntervalCorrectTimeAction>();
        }

        public IntervalCorrectTime(DateTime Time)
        {
            this.Time = Time;
            IntervalCorrectTimeActions = new List<IntervalCorrectTimeAction>();

        }

        public int IntervalCorrectTimeId { get; set; }
        public DateTime Time { get; set; }


        public int? IntervalDataId { get; set; }
        public virtual IntervalData IntervalData { get; set; }

        public virtual List<IntervalCorrectTimeAction> IntervalCorrectTimeActions { get; set; }

    }
    public class IntervalCorrectTimeAction
    {

        public IntervalCorrectTimeAction()
        {

        }

        public IntervalCorrectTimeAction(DateTime done)
        {
            Done = done;
        }

        public int IntervalCorrectTimeActionId { get; set; }
        public DateTime Done { get; set; }

        public int? IntervalCorrectTimeId { get; set; }
        public virtual IntervalCorrectTime IntervalCorrectTime { get; set; }

    }
    public class Measurement
    {

        public Measurement()
        {
            Time = DateTime.Now;
            MeasurementPairs = new List<MeasurementPair>();
            Note = new Note();
        }

        public int MeasurementId { get; set; }
       
        public DateTime Time { get; set; }

        public int? MeasurementCategoryId { get; set; }
        public MeasurementCategory MeasurementCategory { get; set; }

        public List<MeasurementPair> MeasurementPairs { get; set; }


        public int? TaskToDoId { get; set; }
        public TaskToDo TaskToDo { get; set; }

        public Note Note { get; set; }

    }


   public enum PairType
    {
        numeric,text
    }

    public class MeasurementCategory
    {

        public MeasurementCategory()
        {
            Measurements = new List<Measurement>();
        }

        public int MeasurementCategoryId { get; set; }
        public string CategoryName { get; set; }

        public PairType pairType { get; set; }

        public int PairsNumber { get; set; }

       public List<Measurement> Measurements { get; set; }

    }   
    public class MeasurementPair
    {
        public int MeasurementPairId { get; set; }

        public string Name { get; set; }

        public MeasurementPair()
        {
          
        }

        public MeasurementPair(string name,bool text=true)
        {
            Name = name;
            Text = text;
        }

        public bool Text { get; set; }

        public string MeasurementText { get; set; }

        public double MeasurementNumber { get; set; }


        public int? MeasurementId { get; set; }
        public virtual Measurement Measurement { get; set; }


    }
    public class Note
    {

        public Note()
        {

        }


        public Note(string text,bool important)
        {
            Text = text;
            Important = important;
        }

        public int NoteId { get; set; }
        public string Text { get; set; }
        public bool Important { get; set; }

        public int? MeasurementId { get; set; }
        public virtual Measurement Measurement { get; set; }

    }



}
