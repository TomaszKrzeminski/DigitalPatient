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
#line 1 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
using Digital_Patient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class PatientStatistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
       
        [Parameter]
        public string ApplicationUserId { get; set; }

public List<TaskToDo> PatientTasks { get; set; }

    private Repository repository;

    public StatisticsViewModel model = new StatisticsViewModel();

    public TaskToDo SelectedTask { get; set; } = new TaskToDo();

    protected override void OnParametersSet()
    {

        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        PatientTasks = repository.GetUserTasksToDo(ApplicationUserId);

    }


    public async void GetTaskStatistics(int TaskId)
    {

        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        SelectedTask = repository.GetTaskToDo(TaskId);
        model = repository.GetTaskToDoStatistics(TaskId);


    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ApplicationDbContext> factory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
