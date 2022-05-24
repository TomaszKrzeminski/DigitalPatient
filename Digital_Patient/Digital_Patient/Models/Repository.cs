using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Patient.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Nager.Date;

namespace Digital_Patient.Models
{
    public class Repository:IDisposable
    {
        ApplicationDbContext ctx;
       
        public Repository(ApplicationDbContext context)
        {
            ctx = context;
       
        }


        public bool RemoveTaskByDoctor(string DoctroId,int TaskId)
        {
            try
            {

                Doctor doctor = ctx.Doctors.Where(x => x.Id == DoctroId).FirstOrDefault();

                if(doctor!=null)
                {

                    TaskToDo task = ctx.TasksToDo.Include(x=>x.Measurements).Include(x=>x.IntervalData).Where(x=>x.TaskToDoId==TaskId).FirstOrDefault();
                    ApplicationUser user = ctx.Users.Include(x=>x.TasksToDo).Where(x=>x.Id==task.ApplicationUserId).FirstOrDefault();


                    List<Measurement> listMeasurement = ctx.TasksToDo.Include(x => x.Measurements).ThenInclude(x=>x.MeasurementPairs).Include(x=>x.Measurements).ThenInclude(x=>x.Note).Where(x => x.TaskToDoId == task.TaskToDoId).First().Measurements.ToList();

                    //MeasurementPairs
                    foreach (var item in listMeasurement)
                    {
                        ctx.MeasurementPairs.Where(x => x.MeasurementId == item.MeasurementId).ToList().ForEach(x => ctx.MeasurementPairs.Remove(x));
                    }



                    //Notes
                    foreach (var item in listMeasurement)
                    {
                        ctx.Notes.Where(x => x.MeasurementId == item.MeasurementId).ToList().ForEach(x => ctx.Notes.Remove(x));
                    }


                    //Measurements
                    ctx.Measurements.Where(x => x.TaskToDo.TaskToDoId == task.TaskToDoId).ToList().ForEach(p => ctx.Measurements.Remove(p));


                    IntervalData intervaldata = ctx.IntervalData.Include(x => x.CorrectTimes).ThenInclude(x=>x.IntervalCorrectTimeActions).Where(x => x.IntervalDataId == task.IntervalData.IntervalDataId).FirstOrDefault();

                    //IntervalCorrectTimesActions

                    intervaldata.CorrectTimes.SelectMany(x => x.IntervalCorrectTimeActions).ToList().ForEach(x => ctx.IntervalCorrectTimeActions.Remove(x));

                    //CorrectTimes
                    ctx.CorrectTimes.Where(p => p.IntervalDataId == intervaldata.IntervalDataId)
                    .ToList().ForEach(p => ctx.CorrectTimes.Remove(p));
                    ctx.SaveChanges();

                    //IntervalData
                   
                    ctx.IntervalData.Remove(intervaldata);

                   


                    


                   
                    




                    //TaskToDo
                    user.TasksToDo.Remove(task);

                    ctx.TasksToDo.Remove(task);

                    ctx.SaveChanges();


                }


                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
      public bool  RemovePateintFromDoctor(string DoctorId,string PatientId)
        {
            try
            {

                Doctor doctor = ctx.Doctors.Include(x => x.DoctorUsers).Where(x => x.Id == DoctorId).First();
               


                DoctorUser du = ctx.DoctorUsers.Where(x => x.DoctorId == DoctorId && x.ApplicationUserId == PatientId).FirstOrDefault();

                ctx.DoctorUsers.Remove(du);

                ctx.SaveChanges();




                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }



        public bool AddUserToDoctorPatients(string Email,string DoctorId)
        {
            try
            {
                Doctor doctor = ctx.Doctors.Include(x=>x.DoctorUsers).Where(x=>x.Id==DoctorId).First();
                ApplicationUser user = ctx.Users.Include(x => x.DoctorUsers).Where(x => x.Email == Email).First();

                DoctorUser doctorUser = new DoctorUser();
                doctorUser.ApplicationUser = user;
                doctorUser.Doctor = doctor;

                doctor.DoctorUsers.Add(doctorUser);
                ctx.SaveChanges();
                
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public int AddMeasurement(string MeasurementCategoryName, int NoteId, List<int> MeasurementPairIdList)
        {

            //Note note = context.Notes.Find(NoteId);
            List<MeasurementPair> measurementPairs = new List<MeasurementPair>();

            foreach (var item in MeasurementPairIdList)
            {
                MeasurementPair pair = ctx.MeasurementPairs.Find(item);
                measurementPairs.Add(pair);
            }



            MeasurementCategory mCategory = ctx.MeasurementCategories.Where(x => x.CategoryName == MeasurementCategoryName).FirstOrDefault();

            Measurement measurement = new Measurement();
            ctx.Measurements.Add(measurement);
            ctx.SaveChanges();



            measurement.MeasurementPairs.AddRange(measurementPairs);
            ctx.SaveChanges();
            mCategory.Measurements.Add(measurement);
            ctx.SaveChanges();

            //measurement.Note = note;
            ctx.SaveChanges();

            return measurement.MeasurementId;
        }

        int AddIntervalData(int Number, DateTime StartTime, DateTime EndTime, bool Weekends, bool Holidays, List<DateTime> CorrectTimes)
        {

            IntervalData intervalData = new IntervalData(Number, StartTime, EndTime, Weekends, Holidays);

            ctx.IntervalData.Add(intervalData);
            ctx.SaveChanges();

            foreach (var item in CorrectTimes)
            {
                intervalData.CorrectTimes.Add(new IntervalCorrectTime(item));
                ctx.SaveChanges();
            }
            return intervalData.IntervalDataId;
        }

        int AddMeasurementPair(string Name, double Number, string Text)
        {
            MeasurementPair pair = new MeasurementPair();
            pair.Name = Name;
            pair.MeasurementText = Text;
            pair.MeasurementNumber = Number;
            ctx.MeasurementPairs.Add(pair);
            ctx.SaveChanges();
            return pair.MeasurementPairId;
        }

        int SeedNote(string Text = "Text notatki", bool Important = true)
        {
            Note note = new Note(Text, Important);
            ctx.Notes.Add(note);
            ctx.SaveChanges();
            return note.NoteId;
        }

        void AddTaskToDo(string Description,string UserEmail, int IntervalDataId, string CategoryName, List<int> MeasurementIdList)
        {

            List<Measurement> measurementList = new List<Measurement>();

            foreach (var item in MeasurementIdList)
            {
                Measurement measurement = ctx.Measurements.Find(item);
                measurementList.Add(measurement);
            }

            IntervalData interval = ctx.IntervalData.Find(IntervalDataId);
            TaskToDo taskToDo = new TaskToDo();
            taskToDo.IntervalData = interval;
            ctx.SaveChanges();


            taskToDo.Description = Description;
            taskToDo.Measurements.AddRange(measurementList);
            ctx.TasksToDo.Add(taskToDo);
            ctx.SaveChanges();

            TaskToDoCategory taskCategory = ctx.TaskCategories.Where(x => x.CategoryName == CategoryName).FirstOrDefault();
            taskCategory.TasksToDo.Add(taskToDo);
            ctx.SaveChanges();

            ApplicationUser user = ctx.Users.Where(x => x.Email == UserEmail).FirstOrDefault();
            user.TasksToDo.Add(taskToDo);
            ctx.SaveChanges();

        }



        public bool CheckIfTaskExists(string UserEmail, List<DateTime> Times, DateTime StartTime, DateTime EndTime, bool Weekends, bool Holidays)
        {
            try
            {
                List<TaskToDo> list = ctx.Users.Include(x => x.TasksToDo).ThenInclude(x => x.IntervalData).ThenInclude(x => x.CorrectTimes).ThenInclude(x => x.IntervalCorrectTimeActions).Include(x => x.TasksToDo).ThenInclude(x => x.Measurements).ThenInclude(x => x.MeasurementCategory).Include(x => x.TasksToDo).ThenInclude(x => x.Measurements).ThenInclude(x => x.MeasurementPairs).Include(x => x.TasksToDo).ThenInclude(x => x.TaskToDoCategory).Include(x => x.TasksToDo).ThenInclude(x => x.Measurements).ThenInclude(x => x.Note)
                   .Where(x => x.Email == UserEmail).FirstOrDefault().TasksToDo.ToList();


                //bool task = ctx.Users.Include(x => x.TasksToDo).ThenInclude(x => x.IntervalData).ThenInclude(x => x.CorrectTimes).ThenInclude(x => x.IntervalCorrectTimeActions).Include(x => x.TasksToDo).ThenInclude(x => x.Measurements).ThenInclude(x => x.MeasurementCategory).Include(x => x.TasksToDo).ThenInclude(x => x.Measurements).ThenInclude(x => x.MeasurementPairs).Include(x => x.TasksToDo).ThenInclude(x => x.TaskToDoCategory).Include(x => x.TasksToDo).ThenInclude(x => x.Measurements).ThenInclude(x => x.Note)
                //    .Where(x => x.Email == UserEmail&&x.TasksToDo.Any(y=>y.IntervalData.Holidays==Holidays&&y.IntervalData.Weekends==Weekends&&y.IntervalData.CorrectTimes.Any(y=>Times.Contains(y.Time)&&y.IntervalData.StartTime==StartTime&&y.IntervalData.EndTime==EndTime))).FirstOrDefault().TasksToDo.Any();


                bool task = false;
                List<TaskToDo> list2 = new List<TaskToDo>();
                if(list!=null&&list.Count>0)
                {
                 list2 = list.Where(y=> y.IntervalData.Holidays == Holidays && y.IntervalData.Weekends == Weekends&&y.IntervalData.CorrectTimes.Any(y => Times.Contains(y.Time.Date) && y.IntervalData.StartTime.Date == StartTime.Date && y.IntervalData.EndTime.Date == EndTime.Date)).ToList();
                
                }
               return task;
               
            }
            catch(Exception ex)
            {
                return false;
            }
        }


     
        public EditTaskToDoModel  EditTaskToDo(int TaskId)
        {
            EditTaskToDoModel taskmodel = new EditTaskToDoModel();
            try
            {

                TaskToDo task = GetTaskToDo(TaskId);
                taskmodel.Description = task.Description;
                taskmodel.correctTimes = task.IntervalData.CorrectTimes.Select(x =>new DateTime?(x.Time) ).ToList<DateTime?>();
                taskmodel.RemoveDuplicationsDateTime();
                taskmodel.TaskToDoCategory = task.TaskToDoCategory.CategoryName;


                taskmodel.intervalData = task.IntervalData;

              int howMany=  taskmodel.correctTimes.Count();

                for (int i = 0; i < (howMany-1); i++)
                {
                    taskmodel.showTimes[i] = true;
                }


                int x = 12 - howMany;

                for (int i = 0; i < x; i++)
                {
                    taskmodel.correctTimes.Add(null);
                }


                return taskmodel;
            }
            catch(Exception ex)
            {
                return null;
            }

        }

        public bool ChangeTaskToDo(EditTaskToDoModel model)
        {
            try
            {
                TaskToDo task  = ctx.TasksToDo.Include(x => x.IntervalData).ThenInclude(x => x.CorrectTimes).ThenInclude(x => x.IntervalCorrectTimeActions).Include(x => x.Measurements).ThenInclude(x => x.MeasurementCategory).Include(x => x.Measurements).ThenInclude(x => x.MeasurementPairs).Include(x => x.TaskToDoCategory).Include(x => x.Measurements).ThenInclude(x => x.Note)
                    .Where(x => x.TaskToDoId == model.TaskToDoId).FirstOrDefault();

                task.Description = model.Description;

                model.RemoveDuplicationsDateTime();


                IntervalData data = task.IntervalData;
                data.Holidays = model.intervalData.Holidays;
                data.Weekends = model.intervalData.Weekends;
                data.StartTime = model.intervalData.StartTime;
                data.EndTime = model.intervalData.EndTime;

                ctx.SaveChanges();


                IntervalData interval = ctx.IntervalData.Include(x => x.CorrectTimes).Where(x => x.TaskToDo.IntervalData.IntervalDataId == data.IntervalDataId).FirstOrDefault();

                List<IntervalCorrectTime> times = interval.CorrectTimes;

                //for (int i = 0; i < times.Count; i++)                
                //{
                //    interval.CorrectTimes.Remove(times[i]);
                //   ctx.SaveChanges();
                //}




                ctx.CorrectTimes.Where(p => p.IntervalDataId == interval.IntervalDataId)
               .ToList().ForEach(p => ctx.CorrectTimes.Remove(p));
                ctx.SaveChanges();



                interval.CorrectTimes = new List<IntervalCorrectTime>();
                ctx.SaveChanges();
               




                for (int i = 0; i < model.correctTimes.Count; i++)
                {
                    interval.CorrectTimes.Add(new IntervalCorrectTime("special") { Time = (DateTime)model.correctTimes[i] });
                }

                ctx.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }


        public string AddTaskToUser2(AddTaskToUserModel model  )
        {

            string UserEmail = model.UserId;
            model.RemoveDuplicationsDateTime();
            string TaskCategoryName = model.TaskToDoCategory;


            int Number = model.intervalData.Number;

            DateTime StartTime = model.intervalData.StartTime;
            DateTime EndTime = model.intervalData.EndTime;
            bool Weekends = model.intervalData.Weekends;
            bool Holidays = model.intervalData.Holidays;

            List<DateTime> CorrectTimes = new List<DateTime>();


            foreach (var item in model.correctTimes)
            {
                CorrectTimes.Add((DateTime)item);
            }
                
                
                

        bool check=   CheckIfTaskExists( UserEmail, CorrectTimes,  StartTime,  EndTime,  Weekends,  Holidays);

            if(check)
            {
                return "Podobne zadanie już istnieje";
            }

            




            try
            {

                TaskCat taskcat;
                Enum.TryParse<TaskCat>(TaskCategoryName, out taskcat);
                MeasurementCategoryFactory factory = new MeasurementCategoryFactory();
                ITaskCat tasktoDoCat = factory.SetTaskCat(taskcat);
                List<MeasurementCategory> categories = tasktoDoCat.AddCategories();

                List<int> measurementIdList = new List<int>();



                foreach (var cat in categories)
                {
                    
                    List<int> MeasurementPairIdList = new List<int>();

                    MeasurementCat mCat;
                    Enum.TryParse<MeasurementCat>(cat.CategoryName, out mCat);
                    MeasurementPairsFactory factory2 = new MeasurementPairsFactory();
                    IMeasurementPair measurementPair = factory2.SetMeasurement(mCat);
                    List<MeasurementPair> mList = measurementPair.AddPairs();


                    foreach (var pairM in mList)
                    {
                        ctx.MeasurementPairs.Add(pairM);
                        ctx.SaveChanges();
                        MeasurementPairIdList.Add(pairM.MeasurementPairId);
                    }


                    int MeasurementId = AddMeasurement(cat.CategoryName, 1, MeasurementPairIdList);
                    measurementIdList.Add(MeasurementId);
                }



                int IntervalDataId = AddIntervalData(Number, StartTime, EndTime, Weekends, Holidays, CorrectTimes);

                AddTaskToDo(model.Description,UserEmail, IntervalDataId, TaskCategoryName, measurementIdList);


                return "Zadanie "+model.Description + " dodano poprawnie";
            }
            catch(Exception ex)
            {
                return "Nie udało się dodać zadania";
            }
            
        }

        public bool AddTaskToUser(AddTaskToUserModel model)
        {
            try
            {
                ApplicationUser user = ctx.Users.Find(model.UserId);










                user.TasksToDo.Add(model.tasktoDo);
                ctx.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<TaskToDo> GetUserTasksToDo2(string PatientEmail)
        {
            List<TaskToDo> list = new List<TaskToDo>();


            //////check if task exists




            try
            {
                list = ctx.Users.Include(x => x.TasksToDo).ThenInclude(x=>x.TaskToDoCategory).Where(x => x.Email == PatientEmail).First().TasksToDo.ToList();
                return list;
            }
            catch (Exception ex)
            {
                return list;
            }
        }

        public List<TaskToDo>  GetUserTasksToDo(string UserId)
        {
            List<TaskToDo> list = new List<TaskToDo>();
            try
            {
                list = ctx.Users.Include(x => x.TasksToDo).Where(x => x.Id == UserId).First().TasksToDo.ToList();
                return list;
            }
            catch(Exception ex)
            {
                return list;
            }
        }


        public List<string> GetAllPatients(List<string> exceptList)
        {
            List<string> list = new List<string>();
            try
            {
                string RoleId = ctx.Roles.Where(x => x.Name == "Patient").Select(x=>x.Id).FirstOrDefault();
                List<string> UserIdList = ctx.UserRoles.Where(x => x.RoleId == RoleId).Select(x=>x.UserId).ToList();
                list = ctx.Users.Where(x =>UserIdList.Contains(x.Id)).Select(x=>x.Email).ToList();
                list = list.Except(exceptList).ToList();

                return list;
            }
            catch (Exception ex)
            {
                return list;
            }
        }       


        public List<ApplicationUser>  GetDoctorPatients(string DoctorId)
        {
            List<ApplicationUser> list = new List<ApplicationUser>();
            try
            {

              list = ctx.Doctors.Include(x => x.DoctorUsers).ThenInclude(x => x.ApplicationUser).Where(x => x.Id == DoctorId).SelectMany(x => x.DoctorUsers).Select(x => x.ApplicationUser).ToList();



                return list;
            }
            catch(Exception ex)
            {
                return list;
            }
        }


        public List<ApplicationUser> GetHealthCarerPatients(string HealthCarerId)
        {
            List<ApplicationUser> list = new List<ApplicationUser>();
            
            try
            {
                list = ctx.HealthCarers.Include(x => x.HealthCarerUsers).ThenInclude(x => x.ApplicationUser).Where(x => x.Id == HealthCarerId).SelectMany(x => x.HealthCarerUsers).Select(x => x.ApplicationUser).ToList();
                return list;
            }
            catch (Exception ex)
            {
                return list;
            }
        }


        public bool ChangeMeasurmentsData(TaskToDoActionModel model)
        {

            try
            {

                TaskToDo task = ctx.TasksToDo.Include(x=>x.Measurements).ThenInclude(x=>x.MeasurementPairs).Include(x=>x.Measurements).ThenInclude(x=>x.Note).Where(x => x.TaskToDoId == model.taskToDo.TaskToDoId).First();

                List<Measurement> listMeasurements = task.Measurements.ToList();
                List<Measurement> listNewMeasurements = model.taskToDo.Measurements.ToList();

                foreach (var measurement in listMeasurements)
                {

                    Note n = listNewMeasurements.Where(x => x.MeasurementId == measurement.MeasurementId).Select(x=>x.Note).First();
                    Note n1 = measurement.Note;
                    n1.Text = n.Text;                   
              
                    ctx.SaveChanges();
                }




                List<MeasurementPair> listMeasurementPairs = task.Measurements.SelectMany(x=>x.MeasurementPairs).ToList();
                List<MeasurementPair> ListMeasurementPairsNew = model.taskToDo.Measurements.SelectMany(x => x.MeasurementPairs).ToList();

                foreach (var mp in listMeasurementPairs)
                {

                    MeasurementPair measuementPair = ListMeasurementPairsNew.Where(x => x.MeasurementPairId == mp.MeasurementPairId).FirstOrDefault();
                    mp.MeasurementNumber = measuementPair.MeasurementNumber;
                    mp.MeasurementText = measuementPair.MeasurementText;
                    mp.Name = measuementPair.Name;
                    mp.Text = measuementPair.Text;

                    ctx.SaveChanges();

                }




                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }


        public bool AddActionToTaskToDo(TaskToDoActionModel model)
        {
            try
            {
                model.ActionTime = DateTime.Now;

               


                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }       


        public TaskToDo GetTaskToDo(int TaskId)
        {

            TaskToDo taskToDo = new TaskToDo();
            try
            {

                taskToDo =  ctx.TasksToDo.Include(x=>x.IntervalData).ThenInclude(x=>x.CorrectTimes).ThenInclude(x=>x.IntervalCorrectTimeActions).Include(x=>x.Measurements).ThenInclude(x=>x.MeasurementCategory).Include(x=>x.Measurements).ThenInclude(x=>x.MeasurementPairs).Include(x=>x.TaskToDoCategory).Include(x=>x.Measurements).ThenInclude(x=>x.Note)
                    .Where(x => x.TaskToDoId == TaskId).FirstOrDefault();

                return taskToDo;
            }
            catch(Exception ex)
            {
                return taskToDo;
            }

        }

        public async Task<List<Hour>> GetHoursData(string ApplicationUserId)
        {
             FullHours hours = new FullHours();
            try
            {
                DateTime dateTime = DateTime.Now;                
                List<DateTime> Holidays = DateSystem.GetPublicHolidays(dateTime.Year, "PL").Select(x=>x.Date).ToList();

                bool holiday = Holidays.Contains(dateTime.Date);
                bool weekend = dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
               
                List<TaskToDo> TasksToDo = ctx.Users.Include(x => x.TasksToDo).ThenInclude(x => x.IntervalData).Include(x=>x.TasksToDo).ThenInclude(x=>x.Measurements).ThenInclude(x=>x.MeasurementCategory).Include(x=>x.TasksToDo).ThenInclude(x=>x.Measurements).ThenInclude(x=>x.MeasurementPairs).Include(x=>x.TasksToDo).ThenInclude(x=>x.TaskToDoCategory).Include(x=>x.TasksToDo).ThenInclude(x=>x.IntervalData).ThenInclude(x=>x.CorrectTimes).Where(x => x.Id == ApplicationUserId).FirstOrDefault().TasksToDo.Where(x => x.IntervalData.EndTime > dateTime && x.IntervalData.StartTime < dateTime).ToList();


                if(holiday)
                {
                     TasksToDo = ctx.Users.Include(x => x.TasksToDo).ThenInclude(x => x.IntervalData).Where(x => x.Id == ApplicationUserId).FirstOrDefault().TasksToDo.Where(x => x.IntervalData.EndTime > dateTime && x.IntervalData.StartTime < dateTime&&x.IntervalData.Holidays==true ).ToList();
                }
               
                if(weekend)
                {
                    TasksToDo = ctx.Users.Include(x => x.TasksToDo).ThenInclude(x => x.IntervalData).Where(x => x.Id == ApplicationUserId).FirstOrDefault().TasksToDo.Where(x => x.IntervalData.EndTime > dateTime && x.IntervalData.StartTime < dateTime && x.IntervalData.Weekends == true).ToList();
                }


                FullHours fullhours = new FullHours();
                int DayTasks = 0;

                for (int i = 0; i < hours.Hours.Count; i++)
                {
                    List<TaskToDo> listSelect = new List<TaskToDo>();

                    

                    foreach (var task in TasksToDo)
                    {
                        int h = hours.Hours[i].HourTime;

                       bool check = task.IntervalData.CorrectTimes.Any(x => x.Time.Hour == h);

                       if(check)
                        {

                            for (int j=0; j<=59;j++)
                            {

                                if(task.IntervalData.CorrectTimes.Any(x=>x.Time.Hour==h&&x.Time.Minute==j))
                                {
                                    hours.Hours[i].minutes[j].Tasks.Add(task);
                                    hours.HourTasks++;
                                    hours.Hours[i].HourTasks++;

                                }

                            }


                        }


                    }


                    
                }           


                return hours.Hours;
            }
            catch(Exception ex)
            {
                return hours.Hours;
            }
        }

        public async Task<FullHours> GetHoursData2(string ApplicationUserId)
        {
            FullHours hours = new FullHours();
            try
            {
                DateTime dateTime = DateTime.Now;
                List<DateTime> Holidays = DateSystem.GetPublicHolidays(dateTime.Year, "PL").Select(x => x.Date).ToList();

                bool holiday = Holidays.Contains(dateTime.Date);
                bool weekend = dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;

                List<TaskToDo> TasksToDo = ctx.Users.Include(x => x.TasksToDo).ThenInclude(x => x.IntervalData).Include(x => x.TasksToDo).ThenInclude(x => x.Measurements).ThenInclude(x => x.MeasurementCategory).Include(x => x.TasksToDo).ThenInclude(x => x.Measurements).ThenInclude(x => x.MeasurementPairs).Include(x => x.TasksToDo).ThenInclude(x => x.TaskToDoCategory).Include(x => x.TasksToDo).ThenInclude(x => x.IntervalData).ThenInclude(x => x.CorrectTimes).Where(x => x.Id == ApplicationUserId).FirstOrDefault().TasksToDo.Where(x => x.IntervalData.EndTime > dateTime && x.IntervalData.StartTime < dateTime).ToList();


                if (holiday)
                {
                    TasksToDo = ctx.Users.Include(x => x.TasksToDo).ThenInclude(x => x.IntervalData).Where(x => x.Id == ApplicationUserId).FirstOrDefault().TasksToDo.Where(x => x.IntervalData.EndTime > dateTime && x.IntervalData.StartTime < dateTime && x.IntervalData.Holidays == true).ToList();
                }

                if (weekend)
                {
                    TasksToDo = ctx.Users.Include(x => x.TasksToDo).ThenInclude(x => x.IntervalData).Where(x => x.Id == ApplicationUserId).FirstOrDefault().TasksToDo.Where(x => x.IntervalData.EndTime > dateTime && x.IntervalData.StartTime < dateTime && x.IntervalData.Weekends == true).ToList();
                }


                FullHours fullhours = new FullHours();
                int DayTasks = 0;

                for (int i = 0; i < hours.Hours.Count; i++)
                {
                    List<TaskToDo> listSelect = new List<TaskToDo>();



                    foreach (var task in TasksToDo)
                    {
                        int h = hours.Hours[i].HourTime;

                        bool check = task.IntervalData.CorrectTimes.Any(x => x.Time.Hour == h);

                        if (check)
                        {

                            for (int j = 0; j <= 59; j++)
                            {

                                if (task.IntervalData.CorrectTimes.Any(x => x.Time.Hour == h && x.Time.Minute == j))
                                {
                                    hours.Hours[i].minutes[j].Tasks.Add(task);
                                    hours.HourTasks++;
                                    hours.Hours[i].HourTasks++;

                                }

                            }


                        }


                    }



                }


                return hours;
            }
            catch (Exception ex)
            {
                return hours;
            }
        }


        public void Dispose()
        {
            ctx.DisposeAsync();
        }


    }



}

