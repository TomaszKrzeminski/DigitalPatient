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
#line 1 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Digital_Patient.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Digital_Patient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MainPage")]
    public partial class MainPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 204 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
        [Parameter]
    public string Cookie1 { get; set; }



    public void CleanMessage()
    {
        ActionMessage = "";
        //StateHasChanged();
    }


    public void ShowMessage(string message)
    {
        ActionMessage = message;
        //StateHasChanged();
    }

    public string ActionMessage { get; set; }

    [CascadingParameter(Name = "BackGroundColor1")]
    public string BackGroundColor { get; set; } = "bg-dark";
    [CascadingParameter(Name = "TextColor1")]
    public string TextColor { get; set; } = "text-light";



    public void ChangeColor()
    {
        if (BackGroundColor == "bg-dark")
        {
            BackGroundColor = "bg-light";
            TextColor = "text-dark";
        }
        else
        {
            BackGroundColor = "bg-dark";
            TextColor = "text-light";
        }
    }


    [Parameter]
    public string UserRole { get; set; }
    int SelectedTaskId { get; set; } = 0;
    string FullTime { get; set; }

    bool CompleteTask { get; set; }

    private Repository repository;

    int AllTasks { get; set; }

    [Parameter]
    public string Check { get; set; }

    [Parameter]
    public string ApplicationUserId { get; set; }

    public List<Hour> Hours { get; set; } = new List<Hour>();

    public DateTime Now { get; set; }

    public void SetTaskId(int TaskId, string fullTime)
    {
        SelectedTaskId = TaskId;
        FullTime = fullTime;

        CleanMessage();
    }


    public void HandleTask(bool Done)
    {
        CompleteTask = Done;
    }


    public void UpdateTaskList()
    {

        GetHoursView(ApplicationUserId);


        //StateHasChanged();
    }


    async Task GetHoursView(string Id)
    {
        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        //Hours = await repository.GetHoursData(ApplicationUserId);

        FullHours hours = await repository.GetHoursData2(ApplicationUserId);
        Hours = hours.Hours;
        AllTasks = hours.HourTasks;
    }




    //protected override async Task OnInitializedAsync()
    //{
    //    string Id = ApplicationUserId;
    //    await   GetHoursView(Id);

    //}





    protected async override Task OnParametersSetAsync()
    {
        string x = Check;
        string Id = ApplicationUserId;
        await GetHoursView(Id);
        Now = DateTime.Now;

    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ApplicationDbContext> factory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
