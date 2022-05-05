#pragma checksum "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eacfd404d62db4f763c30264c21798f4dec3d28b"
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
            __builder.AddMarkupContent(0, "<h3>TaskPanel</h3>\r\n\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 17 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
     UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col col-lg-3");
            __builder.AddMarkupContent(10, "\r\n            Pacjenci\r\n");
#nullable restore
#line 24 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
             foreach (var u in allpatients.OrderBy(x=>x))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
                                 ()=>AddToMyPatients(u)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, 
#nullable restore
#line 27 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
                     u

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col col-lg-3");
            __builder.AddMarkupContent(17, "\r\n            Moi Pacjenci\r\n");
#nullable restore
#line 33 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
             foreach (var u in patients.OrderBy(x=>x.Email))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddContent(19, 
#nullable restore
#line 36 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
                     u.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<div class=\"col col-lg-3\">\r\n            Zadania\r\n        </div>\r\n        ");
            __builder.AddMarkupContent(22, "<div class=\"col col-lg-3\">\r\n            Dodaj Nowe\r\n        </div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskPanel.razor"
       

    [Parameter]
    public string UserId { get; set; }

    public string SelectedPatientEmail { get; set; }

    private Repository repository;

    List<ApplicationUser> patients = new List<ApplicationUser>();

    List<string> allpatients = new List<string>();

    protected async override Task OnParametersSetAsync()
    {


        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        patients = repository.GetDoctorPatients(UserId );

        List<string> listExcept = new List<string>();

        if(patients!=null&&patients.Count>0)
        {
            listExcept = patients.Select(x => x.Email).ToList();
        }

        allpatients = repository.GetAllPatients(listExcept);


    }

    public void AddToMyPatients(string Email)
    {
        repository.AddUserToDoctorPatients(Email, UserId);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ApplicationDbContext> factory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
