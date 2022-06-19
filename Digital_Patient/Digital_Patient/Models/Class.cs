using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{
    public class AddTaskToUserModel
    {





        public AddTaskToUserModel()
        {
            measurementcaterogiesList = new List<MeasurementCategory>();
            measurementList = new List<Measurement>();
            intervalData = new IntervalData(DateTime.Now,DateTime.Now.AddDays(30));
            correctTimes = new List<DateTime?>();
            showTimes = new List<bool>();

            //for (int i = 0; i < 12; i++)
            //{
            //    correctTimes.Add(new DateTime(2022,1,1,12,00,1));
            //}

            correctTimes.Add(DateTime.Now);
            for (int i = 1; i < 12; i++)
            {
                correctTimes.Add(null);
            }


            for (int i = 0; i < 11; i++)
            {
                showTimes.Add(false);
            }


        }


        public List<MeasurementCategory> SetMeasurementCategories(string SelectedString)
        {


            TaskCat taskcat;
            Enum.TryParse<TaskCat>(SelectedString, out taskcat);
            MeasurementCategoryFactory factory = new MeasurementCategoryFactory();
            ITaskCat tasktoDoCat = factory.SetTaskCat(taskcat);
            List<MeasurementCategory> categories = tasktoDoCat.AddCategories();
            measurementcaterogiesList = categories;
            return categories;


        }


        public void RemoveDuplicationsDateTime()
        {
            List<DateTime?> list2 = new List<DateTime?>();
             list2=correctTimes.Distinct().ToList();


            list2.RemoveAll(x => x == null);

            correctTimes = list2;
                
        }


        public void SetMeasurements()
        {
            foreach (var item in measurementcaterogiesList)
            {
                Measurement measurement = new Measurement();

                MeasurementCat mCat;
                Enum.TryParse<MeasurementCat>(item.CategoryName, out mCat);
                MeasurementPairsFactory factory2 = new MeasurementPairsFactory();
                IMeasurementPair measurementPair = factory2.SetMeasurement(mCat);
                List<MeasurementPair> mList = measurementPair.AddPairs();

                measurement.MeasurementPairs.AddRange(mList);            
               
                measurement.MeasurementCategory = item;

                measurementList.Add(measurement);
            }
            






           
        }


        public string UserId { get; set; }
        public string DoctorId { get; set; }
        public TaskToDo tasktoDo { get; set; }
        [Required]
        public string Description { get; set; }

        public string TaskToDoCategory { get; set; } = "Stolec";
        public List<MeasurementCategory> measurementcaterogiesList { get; set; }
        public List<Measurement> measurementList { get; set; }

        public IntervalData intervalData { get; set; }
        public List<DateTime?> correctTimes { get; set; }

        public List<bool> showTimes { get; set; }

    }



    public class EditTaskToDoModel
    {

        public EditTaskToDoModel()
        {
            measurementcaterogiesList = new List<MeasurementCategory>();
            measurementList = new List<Measurement>();
            intervalData = new IntervalData(DateTime.Now, DateTime.Now.AddDays(30));
            correctTimes = new List<DateTime?>();
            showTimes = new List<bool>();


            for (int i = 1; i < 12; i++)
            {
                correctTimes.Add(null);
            }


            for (int i = 0; i < 11; i++)
            {
                showTimes.Add(false);
            }





            //for (int i = 0; i < 12; i++)
            //{
            //    correctTimes.Add(new DateTime());
            //}

            //for (int i = 0; i < 12; i++)
            //{
            //    showTimes.Add(false);
            //}


        }


        


        public void RemoveDuplicationsDateTime()
        {
            List<DateTime?> list2 = new List<DateTime?>();
            list2 = correctTimes.Distinct().ToList();


            list2.RemoveAll(x => x == null);

            correctTimes = list2;

        }


       

        public int TaskToDoId { get; set; }
        public string UserId { get; set; }
        public string DoctorId { get; set; }
        public TaskToDo tasktoDo { get; set; }
        [Required]
        public string Description { get; set; }

        public string TaskToDoCategory { get; set; } 
        public List<MeasurementCategory> measurementcaterogiesList { get; set; }
        public List<Measurement> measurementList { get; set; }

        public IntervalData intervalData { get; set; }
        public List<DateTime?> correctTimes { get; set; }

        public List<bool> showTimes { get; set; }



    }





   


}
