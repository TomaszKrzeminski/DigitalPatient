// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Digital_Patient.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
using Digital_Patient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class TaskPanel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 449 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
        
    [Parameter]
    public string Cookie1 { get; set; }

    [Parameter]
    public string Cookie2 { get; set; }


    public string UserIdTaskChange { get; set; }
    public int TaskIdChange { get; set; }

    public string Cookie { get; set; } = "";

    public bool AddEditTask { get; set; } = true;


    public int TaskIdToEdit { get; set; }

    public EditTaskToDoModel modelEdit { get; set; } = new EditTaskToDoModel();



    public string Action { get; set; }

    public AddTaskToUserModel model { get; set; } = new AddTaskToUserModel();

    [Parameter]
    public string UserId { get; set; }

    public string PatientEmail { get; set; }



    private Repository repository;

    List<ApplicationUser> patients = new List<ApplicationUser>();

    List<string> allpatients = new List<string>();

    List<TaskToDo> PatientTaskList = new List<TaskToDo>();
    public void RemoveFromMyPatients(string PatientId)
    {
        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        bool check = repository.RemovePateintFromDoctor(UserId, PatientId);

        if (check)
        {
            Action = "Usunięto twojego Pacjenta ";

            OnParametersSetAsync();
        }


        PatientTaskList = new List<TaskToDo>();

        model.measurementList = null;
        AddEditTask = false;



    }

    protected async override Task OnParametersSetAsync()
    {


        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        patients = repository.GetDoctorPatients(UserId);

        List<string> listExcept = new List<string>();

        if (patients != null && patients.Count > 0)
        {
            listExcept = patients.Select(x => x.Email).ToList();
        }

        allpatients = repository.GetAllPatients(listExcept);


    }

    public async Task RemovePatientTask()
    {

        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        bool check = repository.RemoveTaskByDoctor(UserId, TaskIdToEdit);

        if (check)
        {
            Action = "Usunięto jedno z zadań  Pacjenta ";

            //OnParametersSetAsync();
        }

        ShowPatientTasks(PatientEmail);

    }


    public void AddToMyPatients(string Email)
    {
        bool check = repository.AddUserToDoctorPatients(Email, UserId);

        if (check)
        {
            Action = "Dodano" + " " + Email + " do twoich Pacjentów";
            ShowPatientTasks(Email);
            OnParametersSetAsync();
        }


    }

    public void ShowPatientTasks(string PatientEmail)
    {



        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        PatientTaskList = repository.GetUserTasksToDo2(PatientEmail);
        this.PatientEmail = PatientEmail;
        model.UserId = PatientEmail;


        AddEditTask = true;





        ShowTaskDetails(null);


    }

    public async Task HandleValidSubmit()
    {
        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);


        Action = repository.AddTaskToUser2(model);







        UserIdTaskChange = model.UserId;

        model = new AddTaskToUserModel();

        ShowPatientTasks(PatientEmail);
    }


    public async Task HandleInvalidSubmit()
    {

    }


    void ShowTaskDetails(ChangeEventArgs e)
    {
        string SelectedString = "Stolec";
        if (e != null)
        {
            SelectedString = e.Value.ToString();
            model.TaskToDoCategory = SelectedString;
        }







        TaskToDoCategory taskCategory = new TaskToDoCategory();
        taskCategory.CategoryName = SelectedString;

        model.measurementcaterogiesList = new List<MeasurementCategory>();
        model.measurementList = new List<Measurement>();

        model.measurementcaterogiesList = model.SetMeasurementCategories(SelectedString);
        model.SetMeasurements();



    }

    public void AddCorrectTime()
    {
        for (int i = 0; i < model.showTimes.Count; i++)
        {
            if (model.showTimes[i] == false)
            {


                DateTime now = DateTime.Now;


                model.showTimes[i] = true;
                model.correctTimes[i + 1] = now;
                break;



            }
        }

    }

    public void RemoveTime()
    {

        for (int i = 10; i >= 0; i--)
        {
            if (model.showTimes[i] == true)
            {
                model.showTimes[i] = false;
                model.correctTimes[i + 1] = null;
                break;
            }
        }



    }

    public void SetEdit(int TaskId)
    {

        TaskIdToEdit = TaskId;
        AddEditTask = false;

        modelEdit = repository.EditTaskToDo(TaskId);


    }

    public async Task HandleValidSubmitEdit()
    {
        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        modelEdit.TaskToDoId = TaskIdToEdit;
        repository.ChangeTaskToDo(modelEdit);


        ShowPatientTasks(PatientEmail);
    }


    public async Task HandleInvalidSubmitEdit()
    {

    }

    public void AddCorrectTime2()
    {
        for (int i = 0; i < modelEdit.showTimes.Count; i++)
        {
            if (modelEdit.showTimes[i] == false)
            {


                DateTime now = DateTime.Now;


                modelEdit.showTimes[i] = true;
                modelEdit.correctTimes[i + 1] = now;
                break;



            }
        }


    }

    public void RemoveTime2()
    {

        for (int i = 10; i >= 0; i--)
        {
            if (modelEdit.showTimes[i] == true)
            {
                modelEdit.showTimes[i] = false;
                modelEdit.correctTimes[i + 1] = null;
                break;
            }
        }

        EditTaskToDoModel x = modelEdit;

    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ApplicationDbContext> factory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
