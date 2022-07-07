// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Digital_Patient.Blazor
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
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
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.AspNetCore.SignalR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.AspNetCore.Http.Connections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Digital_Patient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/taskupdate")]
    public partial class UpdateTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\UpdateTask.razor"
       


    [Parameter]
    public string Cookie1 { get; set; }

    public string Message { get; set; } = "";

    private string TaskId { get; set; }
    private string TaskDescriptionMessage { get; set; }
    private HubConnection? hubConnection;
    private bool Action { get; set; } = false;
    //[Inject]
    //public CookiesProvider CookiesProvider { get; set; }
    protected override async Task OnInitializedAsync()
    {



        var container = new CookieContainer();
        var cookie = new Cookie()
        {
            Name = ".AspNetCore.Identity.Application",
            Domain = "localhost",
            Value = Cookie1
        };

        container.Add(cookie);


        hubConnection = new HubConnectionBuilder()
       .WithUrl(NavigationManager.ToAbsoluteUri("/taskhub"), options =>
       {
           options.Cookies = container;
       }).Build();



        await hubConnection.StartAsync();





        hubConnection.On<int>("UpdateTask", (TaskId) =>
        {
            Action = true;
            Message = "Dodano nowe zadanie";
            //// call  refresh tasks and view messages

            InvokeAsync(StateHasChanged);
        });



        //hubConnection.On<int>("UpdateTask2", (TaskId) =>
        //{
        //    Action = true;
        //    //// call  refresh tasks and view messages

        //    InvokeAsync(StateHasChanged);
        //});





    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
