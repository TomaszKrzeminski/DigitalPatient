using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Patient.Data;
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

                taskToDo =  ctx.TasksToDo.Include(x=>x.IntervalData).ThenInclude(x=>x.CorrectTimes).ThenInclude(x=>x.IntervalCorrectTimeActions).Include(x=>x.Measurements).ThenInclude(x=>x.MeasurementCategory).Include(x=>x.Measurements).ThenInclude(x=>x.MeasurementPairs).Include(x=>x.TaskToDoCategory)
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

