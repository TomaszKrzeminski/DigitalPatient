#pragma checksum "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17563ba60e243e11943dde21fa7ebb27cea161b0"
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
#nullable restore
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
using System.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/call-js-example-1")]
    public partial class WebApiExample : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
 if(root!=null)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "h5");
            __builder.AddMarkupContent(3, "Gdzie jeste?? : ");
            __builder.AddContent(4, 
#nullable restore
#line 14 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
                        root.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "h6");
            __builder.AddContent(7, "Temperatura   ");
            __builder.AddContent(8, 
#nullable restore
#line 15 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
                       root.main.temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, "              Max :   ");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
                                                            root.main.temp_max

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, "       Min :    ");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
                                                                                               root.main.temp_min

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "icon");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "id", "wicon");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 16 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
                                        SRC

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "alt", "Weather icon");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"

            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\WebApiExample.razor"
       

    public Root root = null;
    public string SRC { get; set; } = "";

    protected override async Task OnParametersSetAsync()
    {
        string result = await JS.InvokeAsync<string>("getCoords");

        string[] tokens = result.Split(' ');



        string lon = tokens[0];
        string lat = tokens[1];
        string appikey = "479e261c6e9812ab2ad1c8b7f883ae19";

        string url3 = "https://api.openweathermap.org/data/2.5/weather?lat="+lat+"&lon="+lon+"&appid="+appikey+"&units=metric";

        var client = ClientFactory.CreateClient();

        var response = await client.GetAsync(url3);
        if (response.IsSuccessStatusCode)
        {
            var stringResponse = await response.Content.ReadAsStringAsync();
            root = JsonConvert.DeserializeObject<Root>(stringResponse);
            SRC= "http://openweathermap.org/img/w/" + root.weather[0].icon + ".png";

            //result = JsonSerializer.Deserialize<List<HolidayResponseModel>>(stringResponse,
            //    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
        else
        {
            //result = Array.Empty<HolidayResponseModel>().ToList();
        }

        //return result;






    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
