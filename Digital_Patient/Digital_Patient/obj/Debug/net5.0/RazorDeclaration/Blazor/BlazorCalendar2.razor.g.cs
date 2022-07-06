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
#line 1 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
using Digital_Patient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class BlazorCalendar2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\BlazorCalendar2.razor"
       


    public string SelectedMonth { get; set; }

    [Parameter]
    public int TaskId { get; set; }

    List<string> MonthNames { get; set; }
    List<string> Days { get; set; }
    List<Week> weeks { get; set; }

    DateTime StartDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
    DateTime EndDate { get; set; } = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddMonths(1).AddDays(-1);



    protected override void OnParametersSet()
    {
        int x = TaskId;
        MonthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames.ToList();

        SelectedMonth = MonthNames[DateTime.Now.Month];

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


    public void LoadCalendar(ChangeEventArgs e)
    {
        var month = e.Value.ToString();
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

        List<DayEvent> listOfDays = repository.TaskToDoDayStatistics(x, StartDate, EndDate);


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

                DayEvent day2 = listOfDays.Where(x => x.DateValue == day.DateValue).FirstOrDefault();

                if (day2 != null)
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
