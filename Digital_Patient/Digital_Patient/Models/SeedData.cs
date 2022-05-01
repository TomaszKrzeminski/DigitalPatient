using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Digital_Patient.Data;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


    namespace SimpleShopWebApp.Models
    {




        public class SeedData
        {
            Repository repo;           
            public SeedData(ApplicationDbContext context)
            {
                repo = new Repository(context);
                this.context = context;
                selector = new MeasurementSelector();
            }

            public MeasurementSelector selector { get; set; }

         
            public ApplicationDbContext context;
            
            public enum UserRole
            {
                Patient, HealthCarer, Doctor, Administrator
            }

            public void EnsurePopulated()
            {            
                void SeedRoles()
                {

                    try
                    {


                        var roleStore = new RoleStore<IdentityRole>(context);

                        if (!context.Roles.Any(r => r.Name == "Patient" || r.Name == "HealthCarer" || r.Name == "Doctor"||r.Name== "Administrator"))                        {

                            roleStore.CreateAsync(new IdentityRole { Name = "Administrator", NormalizedName = "Administrator" });

                            roleStore.CreateAsync(new IdentityRole { Name = "HealthCarer", NormalizedName = "HealthCarer" });

                            roleStore.CreateAsync(new IdentityRole { Name = "Patient", NormalizedName = "Patient" });

                            roleStore.CreateAsync(new IdentityRole { Name = "Doctor", NormalizedName = "Doctor" });
                        }


                        context.SaveChangesAsync();





                    }
                    catch (Exception ex)
                    {

                    }
                }

                void SeedAdmin(string Name, string Surname, string Sex, string City, string Email, DateTime Dateofbirth)
                {


                    try
                    {
                        DateTime Now = DateTime.Now;
                        TimeSpan ts = Now - Dateofbirth;
                        int age = ts.Days / 365;

                        var User = new ApplicationUser()
                        {

                            Email = Email,
                            FirstName = Name,
                            Surname = Surname,
                            City = City,
                            Dateofbirth = Dateofbirth,
                            UserName = Email,
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            SecurityStamp = Guid.NewGuid().ToString(),
                            NormalizedEmail = Email.ToUpper(),
                            NormalizedUserName = Email.ToUpper(),
                        };

                        if (!context.Users.Any(u => u.UserName == User.UserName))
                        {
                            var password = new PasswordHasher<ApplicationUser>();
                            var hashed = password.HashPassword(User, "Sekret123@");
                            User.PasswordHash = hashed;
                            UserStore<ApplicationUser> userStore;

                            userStore = new UserStore<ApplicationUser>(context);

                            userStore.CreateAsync(User).Wait();
                            ////////
                            Claim claim = new Claim(ClaimTypes.Email, User.Email);
                            List<Claim> claims = new List<Claim>();
                            claims.Add(claim);
                            userStore.AddClaimsAsync(User, claims);
                            userStore.AddToRoleAsync(User, "Administrator").Wait();

                        }
                        context.SaveChanges();

                    }
                    catch (Exception ex)
                    {

                    }






                }

                void SeedUser(string Name, string Surname, string Sex, string City, string Email, DateTime Dateofbirth,UserRole userRole)
                {


                    try
                    {
                        DateTime Now = DateTime.Now;
                        TimeSpan ts = Now - Dateofbirth;
                        int age = ts.Days / 365;

                        var User = new ApplicationUser()
                        {

                            FirstName = Name,
                            Email = Email,
                            Surname = Surname,
                            //Sex = Sex,
                            City = City,
                            Dateofbirth = Dateofbirth,
                            UserName = Email,
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            SecurityStamp = Guid.NewGuid().ToString(),
                            NormalizedEmail = Email.ToUpper(),
                            NormalizedUserName = Email.ToUpper(),
                        };

                        if (!context.Users.Any(u => u.UserName == User.UserName))
                        {
                            var password = new PasswordHasher<ApplicationUser>();
                            var hashed = password.HashPassword(User, "Sekret123@");
                            User.PasswordHash = hashed;
                            UserStore<ApplicationUser> userStore;

                            userStore = new UserStore<ApplicationUser>(context);

                            //userStore.CreateAsync(User).Wait();
                            userStore.CreateAsync(User).Wait();
                            ////////
                            Claim claim = new Claim(ClaimTypes.Email, User.Email);
                            List<Claim> claims = new List<Claim>();
                            claims.Add(claim);
                            userStore.AddClaimsAsync(User, claims).Wait();
                            userStore.AddToRoleAsync(User, userRole.ToString()).Wait();

                        }
                        context.SaveChanges();

                    }
                    catch (Exception ex)
                    {

                    }






                }

                void SeddTaskToDoCategory(string CategoryName)
                {
                    context.TaskCategories.Add(new TaskToDoCategory() { CategoryName = CategoryName });
                    context.SaveChanges();
                }

                void SeddMeasurementCategory(string CategoryName)
                {
                    context.MeasurementCategories.Add(new MeasurementCategory() { CategoryName = CategoryName });
                    context.SaveChanges();
                }

                int  SeedIntervalData(int Number, DateTime StartTime, DateTime EndTime, bool Weekends, bool Holidays, List<DateTime> CorrectTimes)
                {
                    
                    IntervalData intervalData = new IntervalData( Number,  StartTime,  EndTime,  Weekends, Holidays);                    

                     context.IntervalData.Add(intervalData);
                    context.SaveChanges();

                    foreach (var item in CorrectTimes)
                    {
                        intervalData.CorrectTimes.Add( new IntervalCorrectTime(item));
                        context.SaveChanges();
                    }


                    

                    return intervalData.IntervalDataId;
                }
 
                //int SeedMeasurement(string MeasurementCategoryName,int NoteId,int MeasurementPairId)
                //{

                //    Note note = context.Notes.Find(NoteId);
                //    MeasurementPair measurementPair = context.MeasurementPairs.Find(MeasurementPairId);
                //    MeasurementCategory mCategory = context.MeasurementCategories.Where(x => x.CategoryName == MeasurementCategoryName).FirstOrDefault();

                //    Measurement measurement = new Measurement();
                //    context.Measurements.Add(measurement);
                //    context.SaveChanges();

                    

                //    measurement.MeasurementPairs.Add(measurementPair);
                //    context.SaveChanges();
                //    mCategory.Measurements.Add(measurement);
                //    context.SaveChanges();

                //    measurement.Note = note;
                //    context.SaveChanges();

                //    return measurement.MeasurementId;
                //}

               

                int SeedMeasurement3(string MeasurementCategoryName, int NoteId, List<int> MeasurementPairIdList)
                {

                    //Note note = context.Notes.Find(NoteId);
                    List<MeasurementPair> measurementPairs = new List<MeasurementPair>();

                    foreach (var item in MeasurementPairIdList)
                    {
                       MeasurementPair pair= context.MeasurementPairs.Find(item);
                        measurementPairs.Add(pair);
                    }
                        
                        
                        
                    MeasurementCategory mCategory = context.MeasurementCategories.Where(x => x.CategoryName == MeasurementCategoryName).FirstOrDefault();

                    Measurement measurement = new Measurement();
                    context.Measurements.Add(measurement);
                    context.SaveChanges();



                    measurement.MeasurementPairs.AddRange(measurementPairs);
                    context.SaveChanges();
                    mCategory.Measurements.Add(measurement);
                    context.SaveChanges();

                    //measurement.Note = note;
                    context.SaveChanges();

                    return measurement.MeasurementId;
                }



                int SeedMeasurementPair(string Name,double Number,string Text)
                {
                    MeasurementPair pair = new MeasurementPair();
                    pair.Name = Name;
                    pair.MeasurementText = Text;
                    pair.MeasurementNumber = Number;
                   
                    context.MeasurementPairs.Add(pair);
                    
                    context.SaveChanges();
                    return pair.MeasurementPairId;
                }

                int SeedNote(string Text="Text notatki",bool Important=true)
                {
                    Note note = new Note(Text,Important);
                    context.Notes.Add(note);
                    context.SaveChanges();
                    return note.NoteId;
                }
              
                void SeeedTaskToDo(string UserEmail,int IntervalDataId,string CategoryName,List<int> MeasurementIdList)
                {

                    List<Measurement> measurementList = new List<Measurement>();

                    foreach (var item in MeasurementIdList)
                    {
                        Measurement measurement = context.Measurements.Find(item);
                        measurementList.Add(measurement);
                    }

                    



                    IntervalData interval = context.IntervalData.Find(IntervalDataId);
                    TaskToDo taskToDo = new TaskToDo();
                    taskToDo.IntervalData = interval;
                    context.SaveChanges();

                    taskToDo.Measurements.AddRange(measurementList);
                    context.TasksToDo.Add(taskToDo);
                    context.SaveChanges();
                    
                    TaskToDoCategory taskCategory = context.TaskCategories.Where(x => x.CategoryName == CategoryName).FirstOrDefault();
                    taskCategory.TasksToDo.Add(taskToDo);
                    context.SaveChanges();
                                                            
                    ApplicationUser user = context.Users.Where(x => x.Email == UserEmail).FirstOrDefault();
                    user.TasksToDo.Add(taskToDo);
                    context.SaveChanges();           

                }     
                


                if (context.Database.EnsureCreated())
                {
                    if (!context.Users.Any())
                    {

                      


                        void AddTaskToUser(string UserEmail, string MeasurementName, double NumberMeasurement, string TextMeasurement, string MeasurementCategory, string TaskToDoCategory, int Number, TimeSpan Interval, DateTime StartTime, DateTime EndTime, bool Weekends, bool Holidays, List<DateTime> CorrectTimes)
                        {
                           

                            TaskCat taskcat;
                            Enum.TryParse<TaskCat>( TaskToDoCategory,out taskcat);
                            MeasurementCategoryFactory factory = new MeasurementCategoryFactory();
                            ITaskCat tasktoDoCat = factory.SetTaskCat(taskcat);
                            List<MeasurementCategory> categories = tasktoDoCat.AddCategories();

                            List<int> measurementIdList = new List<int>();



                            foreach (var cat in categories)
                            {
                                //int NoteId = SeedNote();
                                //int MeasurementPairId = SeedMeasurementPair(MeasurementName, NumberMeasurement, TextMeasurement);

                                List<int> MeasurementPairIdList = new List<int>();

                                MeasurementCat mCat;
                                Enum.TryParse<MeasurementCat>(cat.CategoryName, out mCat);
                                MeasurementPairsFactory factory2 = new MeasurementPairsFactory();
                                IMeasurementPair measurementPair = factory2.SetMeasurement(mCat);
                                List<MeasurementPair> mList = measurementPair.AddPairs();


                                foreach (var pairM in mList)
                                {
                                    context.MeasurementPairs.Add(pairM);
                                    context.SaveChanges();
                                    MeasurementPairIdList.Add(pairM.MeasurementPairId);
                                }


                                int MeasurementId = SeedMeasurement3(cat.CategoryName, 1, MeasurementPairIdList);
                                measurementIdList.Add(MeasurementId);
                            }



                            int IntervalDataId = SeedIntervalData(Number, StartTime, EndTime, Weekends, Holidays, CorrectTimes);

                            SeeedTaskToDo(UserEmail, IntervalDataId, MeasurementName, measurementIdList);
                        }




                        List<ApplicationUser> UserList = new List<ApplicationUser>();

                        SeedRoles();

                        SeedAdmin("Ada", "Krzemińska", "Kobieta", "Świecie", "Ada@gmail.com", new DateTime(1984, 8, 21));

                        SeedUser("Doctor1", "Surname1", "Kobieta", "Świecie", "Doctor1@gmail.com", DateTime.Now,UserRole.Doctor);
                        SeedUser("Doctor2", "Surname2", "Kobieta", "Świecie", "Doctor2@gmail.com", DateTime.Now, UserRole.Doctor);
                        SeedUser("Doctor3", "Surname3", "Kobieta", "Świecie", "Doctor3@gmail.com", DateTime.Now, UserRole.Doctor);

                        SeedUser("Patient1", "Surname1", "Kobieta", "Świecie", "Patient1@gmail.com", DateTime.Now, UserRole.Patient);
                        SeedUser("Patient2", "Surname2", "Kobieta", "Świecie", "Patient2@gmail.com", DateTime.Now, UserRole.Patient);
                        SeedUser("Patient3", "Surname3", "Kobieta", "Świecie", "Patient3@gmail.com", DateTime.Now, UserRole.Patient);

                        SeedUser("HealthCarer1", "Surname1", "Kobieta", "Świecie", "HealthCarer1@gmail.com", DateTime.Now, UserRole.Doctor);
                        SeedUser("HealthCarer2", "Surname2", "Kobieta", "Świecie", "HealthCarer2@gmail.com", DateTime.Now, UserRole.Doctor);
                        SeedUser("HealthCarer3", "Surname3", "Kobieta", "Świecie", "HealthCarer3@gmail.com", DateTime.Now, UserRole.Doctor);

                        List<string> listTaskToDoCategory = new List<string>() { "Stolec", "Mocz", "Lekarstwo", "Płyn", "Jedzenie", "Ćwiczenia","Zabiegi","Sen" };

                        foreach (var item in listTaskToDoCategory)
                        {
                            SeddTaskToDoCategory(item);
                        }

                        List<string> listMeasurementCategory = new List<string>() { "Ciśnienie","Waga", "Saturacja","Temperatura","Ekg","Czas","Stan", "Ilość","Uwaga","Kalorie" };

                        foreach (var item in listMeasurementCategory)
                        {
                            SeddMeasurementCategory(item);
                        }                     

                        DateTime d1 = new DateTime( 2100, 1, 1, 6, 0,0 );
                        DateTime d2 = new DateTime(2100, 1, 1, 14, 0, 0);
                        DateTime d3 = new DateTime(2100, 1, 1, 18, 0, 0);

                        DateTime d11 = new DateTime(2100, 1, 1, 6, 15, 0);
                        DateTime d12 = new DateTime(2100, 1, 1, 6, 14, 0);
                        DateTime d21 = new DateTime(2100, 1, 1, 6, 12, 0);
                        DateTime d31 = new DateTime(2100, 1, 1, 6, 11, 0);
                        DateTime d13 = new DateTime(2100, 1, 1, 6, 13, 0);

                        List<DateTime> times1 = new List<DateTime>() { d11,d12,d13, d21, d31 };

                        List<DateTime> times = new List<DateTime>() { d1, d2, d3 };

                        AddTaskToUser("Ada@gmail.com", "Jedzenie", 83, "", "Waga", "Jedzenie", 30, new TimeSpan(), DateTime.Now, DateTime.Now.AddDays(30), true, true, times );
                        AddTaskToUser("Ada@gmail.com", "Jedzenie", 83, "", "Waga", "Jedzenie", 30, new TimeSpan(), DateTime.Now, DateTime.Now.AddDays(30), true, true, times);

                        AddTaskToUser("Ada@gmail.com", "Ćwiczenia", 83, "", "Czas", "Ćwiczenia", 30, new TimeSpan(), DateTime.Now, DateTime.Now.AddDays(30), true, true, times1);
                        AddTaskToUser("Ada@gmail.com", "Ćwiczenia", 83, "", "Czas", "Ćwiczenia", 30, new TimeSpan(), DateTime.Now, DateTime.Now.AddDays(30), true, true, times1);
                        AddTaskToUser("Ada@gmail.com", "Ćwiczenia", 83, "", "Czas", "Ćwiczenia", 30, new TimeSpan(), DateTime.Now, DateTime.Now.AddDays(30), true, true, times1);
                        AddTaskToUser("Ada@gmail.com", "Lekarstwo", 83, "", "Stan", "Lekarstwo", 30, new TimeSpan(), DateTime.Now, DateTime.Now.AddDays(30), true, true, times1);
                        AddTaskToUser("Ada@gmail.com", "Lekarstwo", 83, "", "Stan", "Lekarstwo", 30, new TimeSpan(), DateTime.Now, DateTime.Now.AddDays(30), true, true, times1);
                        AddTaskToUser("Ada@gmail.com", "Lekarstwo", 83, "", "Stan", "Lekarstwo", 30, new TimeSpan(), DateTime.Now, DateTime.Now.AddDays(30), true, true, times1);

                    }


                }




                




            }
        }

    }

}
