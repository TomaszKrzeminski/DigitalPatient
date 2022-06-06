#pragma checksum "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff20267241728ac29e8338eb9127a5a669745094"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<style>\r\n    .show:hover {\r\n        background-color: lightslategrey;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "PatientStatistics   ");
            __builder.AddContent(3, 
#nullable restore
#line 20 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                         ApplicationUserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container-fluid");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col col-lg-3 bg-light");
            __builder.AddMarkupContent(11, "\r\n            Zadania\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col col-lg-12");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "list-group");
#nullable restore
#line 28 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                     foreach (var task in PatientTasks.OrderBy(x => x.TaskToDoId))
                    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "list-group-item show");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                                                   (() => GetTaskStatistics(task.TaskToDoId))

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(19, "label");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                    task.TaskToDoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(21, "  ");
            __builder.OpenElement(22, "label");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                                                     task.TaskToDoCategory.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(24, " ");
            __builder.OpenElement(25, "label");
            __builder.AddContent(26, 
#nullable restore
#line 32 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                                                                                                        task.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"


                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col col-lg-9 bg-transparent");
#nullable restore
#line 43 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
             if (SelectedTask != null && SelectedTask.TaskToDoId != 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col col-lg-12");
            __builder.OpenElement(34, "h3");
            __builder.AddContent(35, 
#nullable restore
#line 47 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                         SelectedTask.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col col-lg-6");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table table-striped");
            __builder.AddMarkupContent(41, @"<thead><tr><th scope=""col"">Ilość wykonanych zadań</th>
                                <th scope=""col"">Dziś</th>
                                <th scope=""col"">Tydzień</th>
                                <th scope=""col"">Miesiąc</th></tr></thead>
                        ");
            __builder.OpenElement(42, "tbody");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "<th scope=\"row\">wykonana</th>\r\n                                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 65 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                     model.StatisticsPairsDigits[2].Val1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 66 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                     model.StatisticsPairsDigits[1].Val1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 67 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                     model.StatisticsPairsDigits[0].Val1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "tr");
            __builder.AddMarkupContent(55, "<th scope=\"row\">max</th>\r\n                                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 71 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                     model.StatisticsPairsDigits[2].Val2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 72 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                     model.StatisticsPairsDigits[1].Val2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 73 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                     model.StatisticsPairsDigits[0].Val2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col col-lg-6");
            __builder.OpenElement(67, "table");
            __builder.AddAttribute(68, "class", "table table-striped");
            __builder.AddMarkupContent(69, "<thead><tr><th scope=\"col\">Rozpoczęcie</th>\r\n                                <th scope=\"col\">Zakończenie</th></tr></thead>\r\n                        ");
            __builder.OpenElement(70, "tbody");
            __builder.OpenElement(71, "tr");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 95 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                     model.Start.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 96 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                     model.End.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col col-lg-12");
            __builder.OpenElement(80, "h1");
            __builder.AddContent(81, 
#nullable restore
#line 105 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                         SelectedTask.TaskToDoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n                    ");
            __builder.OpenComponent<Digital_Patient.Blazor.BlazorCalendar>(83);
            __builder.AddAttribute(84, "TaskId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 107 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"
                                                   SelectedTask.TaskToDoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "TaskIdChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedTask.TaskToDoId = __value, SelectedTask.TaskToDoId));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 112 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\PatientStatistics.razor"



            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
