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

