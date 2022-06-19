#pragma checksum "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "958d07a6a2b5cc88c2ea62134c8db2dc55371357"
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
#line 1 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
using Digital_Patient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class BlazorCalendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddContent(1, 
#nullable restore
#line 16 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<Digital_Patient.Blazor.BlazorCalendarSelect>(3);
            __builder.AddAttribute(4, "CustomEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 19 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                     LoadCalendar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "MonthNames", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 19 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                                                 MonthNames

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "SelectedMonth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                                                                              SelectedMonth

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-bordered table-striped");
            __builder.OpenElement(10, "thead");
            __builder.OpenElement(11, "tr");
#nullable restore
#line 28 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
             for (int dayIndex = 0; dayIndex < Days.Count(); dayIndex++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "th");
            __builder.AddContent(13, 
#nullable restore
#line 30 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                     Days[dayIndex]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 35 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
         for (int weekIndex = 0; weekIndex < weeks.Count; weekIndex++)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
#nullable restore
#line 39 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
             for (int dayIndex = 0; dayIndex < (weeks[weekIndex].Dates.Count()); dayIndex++)
            {
                var wIndex = weekIndex;
                var dIndex = dayIndex;
                int background = (int)@weeks[wIndex].Dates[dayIndex].color;
                string backgroundText = @weeks[wIndex].Dates[dayIndex].color.ToString();

                DateTime Date = @weeks[wIndex].Dates[dayIndex].EventDate.Date;

                bool checkDay = DateTime.Now.Date == Date;


                if (checkDay)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "class", "bg-" + (
#nullable restore
#line 53 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                   backgroundText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "style", "border: 3px solid #33ccff;");
            __builder.OpenElement(20, "label");
            __builder.AddAttribute(21, "style", "color: Highlight");
            __builder.AddContent(22, 
#nullable restore
#line 55 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                                          weeks[wIndex].Dates[dayIndex].DateValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n                        <br>\r\n                        ");
            __builder.OpenElement(24, "label");
            __builder.AddAttribute(25, "style", "color: Highlight");
            __builder.AddContent(26, 
#nullable restore
#line 58 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                                          weeks[wIndex].Dates[dayIndex].Done

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " / ");
            __builder.AddContent(28, 
#nullable restore
#line 58 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                                                                                weeks[wIndex].Dates[dayIndex].Max

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"



                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "class", "bg-" + (
#nullable restore
#line 67 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                   backgroundText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, 
#nullable restore
#line 69 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                         weeks[wIndex].Dates[dayIndex].DateValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n                        <br>\r\n                        ");
            __builder.OpenElement(33, "label");
            __builder.AddAttribute(34, "style", "color:gray");
            __builder.AddContent(35, 
#nullable restore
#line 71 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                                    weeks[wIndex].Dates[dayIndex].Done

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, " / ");
            __builder.AddContent(37, 
#nullable restore
#line 71 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
                                                                                          weeks[wIndex].Dates[dayIndex].Max

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"

                }



            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public string SelectedMonth { get; set; }

    [Parameter]
    public int TaskId { get; set; }

    List<string> MonthNames { get; set; }
    List<string> Days { get; set; }
    List<Week> weeks { get; set; }

    DateTime StartDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
    DateTime EndDate { get; set; } = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddMonths(1).AddDays(-1);

    DateTime Now { get; set; } = DateTime.Now.Date;

    protected override void OnParametersSet()
    {
        int x = TaskId;
        MonthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames.ToList();

        SelectedMonth = MonthNames[(DateTime.Now.Month)-1];

        GenerateCalendarHead();
        GenerateCalendarBody();

    }



    public void RefreshMe()
    {
        StateHasChanged();
        //OnParametersSet();
    }



    protected override void OnInitialized()
    {
        MonthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames.ToList();

        SelectedMonth = MonthNames[DateTime.Now.Month];

        GenerateCalendarHead();
        GenerateCalendarBody();
    }


    public void LoadCalendar(string month)
    {

        int monthIndex = DateTime.ParseExact(month, "MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("pl-PL")).Month;
        StartDate = new DateTime(DateTime.Now.Year, monthIndex, 1);


        EndDate = new DateTime(DateTime.Now.Year, monthIndex, 1).AddMonths(1).AddDays(-1);
        GenerateCalendarHead();
        GenerateCalendarBody();

    }





    private void GenerateCalendarHead()
    {

        var day1 = new List<string>();

        for (var dt = StartDate; dt <= EndDate; dt = dt.AddDays(1))
        {
            day1.Add(dt.ToString("dddd"));
        }

        Days = day1.Distinct().ToList();

    }




    private void GenerateCalendarBody()
    {
        int x = TaskId;


        ApplicationDbContext context = factory.CreateDbContext();
        Repository repository = new Repository(context);

        List<DayEvent> listOfDays = repository.TaskToDoDayStatistics(x,StartDate,EndDate);


        weeks = new List<Week>();
        int flag = 0;
        Week week = new Week();
        List<DayEvent> dates = new List<DayEvent>();
        var totalDays = (int)(EndDate - StartDate).TotalDays;
        int CountDays = 0;


        for (var dt = StartDate; dt <= EndDate; dt = dt.AddDays(1))
        {
            flag++;
            dates.Add(new DayEvent()
            {
                DateValue = dt.ToString("dd-MMM-yyyy"),
                DayName = dt.ToString("ddd")

            });

            if (flag == 7)
            {
                week = new Week();
                week.Dates = dates;
                weeks.Add(week);
                dates = new List<DayEvent>();
                flag = 0;
            }

            if (CountDays == totalDays)
            {
                week = new Week();
                week.Dates = dates;
                weeks.Add(week);
                dates = new List<DayEvent>();
                flag = 0;
                break;
            }

            CountDays++;

        }


        for (int i = 0; i < weeks.Count; i++)
        {


            for (int j = 0; j < weeks[i].Dates.Count; j++)
            {


                DayEvent day = weeks[i].Dates[j];

                DayEvent day2= listOfDays.Where(x => x.DateValue == day.DateValue).FirstOrDefault();

                if(day2!=null)
                {
                    weeks[i].Dates[j] = day2;
                }


            }




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
