#pragma checksum "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32d5971bc61b863ab83f418367fd5436c30a6bb5"
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
#line 1 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\_Imports.razor"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 5 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\App.razor"
       [Parameter]
    public string Cookie { get; set; }

    protected override Task OnInitializedAsync()
    {
        CookiesProvider.Cookie = Cookie;

        return base.OnInitializedAsync();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CookiesProvider CookiesProvider { get; set; }
    }
}
#pragma warning restore 1591
