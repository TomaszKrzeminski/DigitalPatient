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
#line 1 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Digital_Patient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class TaskAction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
 

    public TaskToDoActionModel model { get; set; } = new TaskToDoActionModel();

    [Parameter]
    public string TaskTime { get; set; }
    public bool DataLogin = false;
    public TaskToDo EditTask { get; set; } = new TaskToDo();
    private Repository repository;

    [Parameter]
    public int TaskId { get; set; } = 0;

    public DateTime tasktime { get; set; }

    public bool Done { get; set; } = false;

    [Parameter]
    public EventCallback<bool> CustomEvent { get; set; }

    public string Tekst { get; set; } = "Brak";

    public async Task DoneTask()
    {

        Done = true;
        await CustomEvent.InvokeAsync(Done);

    }


    public DateTime GetTimeFromString(string Time)
    {
        int hour = Int32.Parse(Time.Split(":")[0]);
        int minute = Int32.Parse(Time.Split(":")[1]);

        DateTime time = new DateTime(2100, 1, 1, hour, minute, 0);
        return time;
    }

    protected async override Task OnParametersSetAsync()
    {

        //set time here 




        //


        EditTask = new TaskToDo();
        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        if(TaskId!=0)
        {


            tasktime = GetTimeFromString(TaskTime);
            model.taskToDo =  repository.GetTaskToDo(TaskId);
        }

    }


    public async Task HandleInvalidSubmit()
    {
        if (DataLogin)
        {
            return;
        }


        try
        {

            using (var repo = new Repository(factory.CreateDbContext()))
            {
                model.TaskCorrectTime = tasktime;
                repo.ChangeMeasurmentsData(model);
            }

        }
        catch (Exception ex)
        {

        }
        finally
        {
            //model = new TaskToDoActionModel();
            DataLogin = false;

        }
    }






    public async Task HandleValidSubmit()
    {


        if (DataLogin)
        {
            return;
        }


        try
        {

            using (var repo = new Repository(factory.CreateDbContext()))
            {
                model.TaskCorrectTime = tasktime;
                repo.ChangeMeasurmentsData(model);
            }

        }
        catch (Exception ex)
        {

        }
        finally
        {
            //model = new TaskToDoActionModel();
            DataLogin = false;

        }









    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ApplicationDbContext> factory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
