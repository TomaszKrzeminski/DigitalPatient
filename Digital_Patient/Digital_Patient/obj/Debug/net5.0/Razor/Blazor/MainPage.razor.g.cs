#pragma checksum "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ffee05d24196f9b992bc02041919ad795d77147"
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
            __builder.AddMarkupContent(0, "<style>\r\n    .selectTask:hover {\r\n        background-color: darkgoldenrod;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n\r\n\r\n");
            __Blazor.Digital_Patient.Blazor.MainPage.TypeInference.CreateCascadingValue_0(__builder, 1, 2, "BackGroundColor1", 3, 
#nullable restore
#line 28 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                               BackGroundColor

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __Blazor.Digital_Patient.Blazor.MainPage.TypeInference.CreateCascadingValue_1(__builder2, 5, 6, "TextColor1", 7, 
#nullable restore
#line 29 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                             TextColor

#line default
#line hidden
#nullable disable
                , 8, (__builder3) => {
                    __builder3.OpenElement(9, "div");
                    __builder3.AddAttribute(10, "class", "container-fluid" + " " + (
#nullable restore
#line 30 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                     BackGroundColor

#line default
#line hidden
#nullable disable
                    ) + " " + (
#nullable restore
#line 30 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                      TextColor

#line default
#line hidden
#nullable disable
                    ) + " ");
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "row");
                    __builder3.AddMarkupContent(13, "<div class=\"col col-lg-4\"></div>\r\n                <div class=\"col col-lg-4\"></div>\r\n                ");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "col col-lg-4");
                    __builder3.OpenComponent<Digital_Patient.Blazor.WebApiExample>(16);
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(17, "\r\n\r\n            ");
                    __builder3.OpenElement(18, "div");
                    __builder3.AddAttribute(19, "class", "row");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col col-lg-12");
                    __builder3.OpenElement(22, "h1");
                    __builder3.AddContent(23, 
#nullable restore
#line 44 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                          ActionMessage

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n                    ");
                    __builder3.OpenComponent<Digital_Patient.Blazor.UpdateTask>(25);
                    __builder3.AddAttribute(26, "Cookie1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                          Cookie1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "UpdateEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 45 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                    UpdateTaskList

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n\r\n            ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "row");
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "class", "col-lg-6");
                    __builder3.OpenElement(33, "div");
                    __builder3.AddAttribute(34, "class", "row");
                    __builder3.OpenElement(35, "h1");
                    __builder3.AddAttribute(36, "class", "badge badge-dark text-left");
                    __builder3.AddContent(37, 
#nullable restore
#line 52 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                 AllTasks

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 56 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                     foreach (var hour in Hours)
                    {


#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(38, "div");
                    __builder3.AddAttribute(39, "class", "row");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "col-lg-12" + " text-left" + "  " + (
#nullable restore
#line 60 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                      BackGroundColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenElement(42, "h2");
                    __builder3.AddContent(43, 
#nullable restore
#line 61 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
             hour.HourTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(44, " : 00   ");
                    __builder3.CloseElement();
                    __builder3.OpenElement(45, "p");
                    __builder3.AddAttribute(46, "class", "badge badge-warning");
                    __builder3.AddContent(47, 
#nullable restore
#line 61 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                        hour.HourTasks

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 65 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                         if (hour.HourTime == Now.Hour)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(48, "div");
                    __builder3.AddAttribute(49, "class", "row");
#nullable restore
#line 69 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
       int i = 0;
        foreach (var min in hour.minutes)
        {

            if (min.Tasks != null && min.Tasks.Count > 0)
            {



#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "col-lg-12" + " col-md-12" + " col-sm-12" + "  text-left" + " " + (
#nullable restore
#line 77 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                      BackGroundColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "row");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col col-lg-4");
                    __builder3.OpenElement(56, "p");
                    __builder3.AddAttribute(57, "class", "badge badge-light");
                    __builder3.AddContent(58, 
#nullable restore
#line 79 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                 hour.HourTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(59, " : ");
                    __builder3.AddContent(60, 
#nullable restore
#line 79 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                  i

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n        <div class=\"col col-lg-4\"></div>\r\n        <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 91 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                     foreach (var task in min.Tasks)
                                    {
                                        string clock = hour.HourTime + ":" + min.MinuteTime;

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "class", "col-lg-12 col-md-12 col-sm-12  text-left");
                    __builder3.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                                  ()=>SetTaskId(@task.TaskToDoId,clock)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "row");
                    __builder3.OpenElement(67, "div");
                    __builder3.AddAttribute(68, "class", "col col-lg-4 alert-dark selectTask ");
                    __builder3.AddContent(69, 
#nullable restore
#line 102 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                           task.TaskToDoId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(70, " ");
                    __builder3.AddContent(71, 
#nullable restore
#line 102 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                                            task.Description

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(72, " ");
                    __builder3.AddContent(73, 
#nullable restore
#line 102 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                                                              task.TaskToDoCategory.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(74, " ");
                    __builder3.AddContent(75, 
#nullable restore
#line 102 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                                                                                                  task.Measurements.FirstOrDefault().MeasurementCategory.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\r\n                                                                                        <div class=\"col col-lg-4\"></div>\r\n                                                                                        <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 109 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                        }


                                i++;

                            } 

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 117 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
       }
else
{

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "row");
#nullable restore
#line 122 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
       int i = 0;
        foreach (var min in hour.minutes)
        {

            if (min.Tasks != null && min.Tasks.Count > 0)
            {


                if (i < 10)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col-lg-12 col-md-12 col-sm-12  text-left");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "row");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "class", "col col-lg-4");
                    __builder3.OpenElement(85, "p");
                    __builder3.AddAttribute(86, "class", "badge badge-light selectTask ");
                    __builder3.AddContent(87, 
#nullable restore
#line 134 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                             hour.HourTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(88, " : 0 ");
                    __builder3.AddContent(89, 
#nullable restore
#line 134 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                i

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n        <div class=\"col col-lg-4\"></div>\r\n        <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 139 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
       }
else
{

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "col-lg-12 col-md-12 col-sm-12  text-left");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "class", "row");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "class", "col col-lg-4");
                    __builder3.OpenElement(97, "p");
                    __builder3.AddAttribute(98, "class", "badge badge-light ");
                    __builder3.AddContent(99, 
#nullable restore
#line 144 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                  hour.HourTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(100, " : ");
                    __builder3.AddContent(101, 
#nullable restore
#line 144 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                   i

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\r\n        <div class=\"col col-lg-4\"></div>\r\n        <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 149 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
       }









#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
 foreach (var task in min.Tasks)
{
    string clock = hour.HourTime + ":" + min.MinuteTime;



#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(103, "div");
                    __builder3.AddAttribute(104, "class", "col-lg-12 col-md-12 col-sm-12  text-left");
                    __builder3.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 163 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                              ()=>SetTaskId(@task.TaskToDoId,clock)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenElement(106, "div");
                    __builder3.AddAttribute(107, "class", "row");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "class", "col col-lg-4 selectTask  ");
                    __builder3.AddContent(110, 
#nullable restore
#line 167 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                             task.TaskToDoId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(111, " ");
                    __builder3.AddContent(112, 
#nullable restore
#line 167 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                              task.Description

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(113, " ");
                    __builder3.AddContent(114, 
#nullable restore
#line 167 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                task.TaskToDoCategory.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(115, " ");
                    __builder3.AddContent(116, 
#nullable restore
#line 167 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                                                    task.Measurements.FirstOrDefault().MeasurementCategory.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(117, "\r\n                                                    <div class=\"col col-lg-4\"></div>\r\n                                                    <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 174 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                    }


i++;

} 

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 182 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 182 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                         }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\r\n                ");
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col-lg-6" + " col-md-12" + " col-sm-12" + " alert-light" + " " + (
#nullable restore
#line 186 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                      BackGroundColor

#line default
#line hidden
#nullable disable
                    ) + " " + (
#nullable restore
#line 186 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                       TextColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(121, "style", "min-height:200px;    ");
                    __builder3.OpenElement(122, "div");
                    __builder3.AddAttribute(123, "class", "row");
#nullable restore
#line 189 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                         if (BackGroundColor == "bg-dark")
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(124, "div");
                    __builder3.AddAttribute(125, "class", "col col-lg-12");
                    __builder3.OpenElement(126, "button");
                    __builder3.AddAttribute(127, "class", "btn btn-light");
                    __builder3.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 192 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                  ChangeColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(129, "Tło");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 193 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
           }
else
{

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(130, "div");
                    __builder3.AddAttribute(131, "class", "col col-lg-12");
                    __builder3.OpenElement(132, "button");
                    __builder3.AddAttribute(133, "class", "btn btn-dark");
                    __builder3.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 197 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                             ChangeColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(135, "Tło");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 198 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(136, "\r\n                    ");
                    __builder3.OpenComponent<Digital_Patient.Blazor.TaskAction>(137);
                    __builder3.AddAttribute(138, "TaskId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 202 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                         SelectedTaskId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(139, "CustomEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 202 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                       HandleTask

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(140, "TaskTime", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 202 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                              FullTime

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "MessageSet", new System.Action<System.String>(
#nullable restore
#line 202 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                     ShowMessage

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                );
            }
            );
            __builder.AddMarkupContent(142, "\r\n\r\n");
            __builder.OpenComponent<Digital_Patient.Blazor.WebApiExample>(143);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 215 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
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
namespace __Blazor.Digital_Patient.Blazor.MainPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
