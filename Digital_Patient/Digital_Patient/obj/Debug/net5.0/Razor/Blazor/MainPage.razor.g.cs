#pragma checksum "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51edd280fc46473efe7c9c0e8765c74c06f2e4b2"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/MainPage")]
    public partial class MainPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    .selectTask:hover {\n        background-color: darkgoldenrod;\n    }\n</style>\n\n");
            __Blazor.Digital_Patient.Blazor.MainPage.TypeInference.CreateCascadingValue_0(__builder, 1, 2, "BackGroundColor1", 3, 
#nullable restore
#line 23 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                               BackGroundColor

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __Blazor.Digital_Patient.Blazor.MainPage.TypeInference.CreateCascadingValue_1(__builder2, 5, 6, "TextColor1", 7, 
#nullable restore
#line 24 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                             TextColor

#line default
#line hidden
#nullable disable
                , 8, (__builder3) => {
                    __builder3.OpenElement(9, "div");
                    __builder3.AddAttribute(10, "class", "container-fluid" + " " + (
#nullable restore
#line 25 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                     BackGroundColor

#line default
#line hidden
#nullable disable
                    ) + " " + (
#nullable restore
#line 25 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                      TextColor

#line default
#line hidden
#nullable disable
                    ) + " ");
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "row");
                    __builder3.OpenElement(13, "div");
                    __builder3.AddAttribute(14, "class", "col col-lg-12");
                    __builder3.OpenElement(15, "h1");
                    __builder3.AddContent(16, 
#nullable restore
#line 28 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                          ActionMessage

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(17, "\n\n            ");
                    __builder3.OpenElement(18, "div");
                    __builder3.AddAttribute(19, "class", "row");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-lg-6");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "row");
                    __builder3.OpenElement(24, "h1");
                    __builder3.AddAttribute(25, "class", "badge badge-dark text-left");
                    __builder3.AddContent(26, 
#nullable restore
#line 35 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                 AllTasks

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 39 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                     foreach (var hour in Hours)
                    {


#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(27, "div");
                    __builder3.AddAttribute(28, "class", "row");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-lg-12" + " text-left" + "  " + (
#nullable restore
#line 43 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                              BackGroundColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenElement(31, "h2");
                    __builder3.AddContent(32, 
#nullable restore
#line 44 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                     hour.HourTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(33, " : 00   ");
                    __builder3.CloseElement();
                    __builder3.OpenElement(34, "p");
                    __builder3.AddAttribute(35, "class", "badge badge-warning");
                    __builder3.AddContent(36, 
#nullable restore
#line 44 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                hour.HourTasks

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 48 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                         if (hour.HourTime == Now.Hour)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "class", "row");
#nullable restore
#line 52 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                  

                                    int i = 0;
                                    foreach (var min in hour.minutes)
                                    {

                                        if (min.Tasks != null && min.Tasks.Count > 0)
                                        {



#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(39, "div");
                    __builder3.AddAttribute(40, "class", "col-lg-12" + " col-md-12" + " col-sm-12" + "  text-left" + " " + (
#nullable restore
#line 62 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                  BackGroundColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "class", "row");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "col col-lg-4");
                    __builder3.OpenElement(45, "p");
                    __builder3.AddAttribute(46, "class", "badge badge-light");
                    __builder3.AddContent(47, 
#nullable restore
#line 64 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                             hour.HourTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(48, " : ");
                    __builder3.AddContent(49, 
#nullable restore
#line 64 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                              i

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n                                                    <div class=\"col col-lg-4\"></div>\n                                                    <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 76 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                             foreach (var task in min.Tasks)
                                            {
                                                string clock = hour.HourTime + ":" + min.MinuteTime;
                                                

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-lg-12 col-md-12 col-sm-12  text-left");
                    __builder3.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                  ()=>SetTaskId(@task.TaskToDoId,clock)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "row");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "col col-lg-4 alert-dark selectTask ");
                    __builder3.AddContent(58, 
#nullable restore
#line 88 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                           task.TaskToDoId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(59, " ");
                    __builder3.AddContent(60, 
#nullable restore
#line 88 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                            task.Description

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(61, " ");
                    __builder3.AddContent(62, 
#nullable restore
#line 88 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                              task.TaskToDoCategory.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(63, " ");
                    __builder3.AddContent(64, 
#nullable restore
#line 88 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                                                                  task.Measurements.FirstOrDefault().MeasurementCategory.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\n                                                        <div class=\"col col-lg-4\"></div>\n                                                        <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 96 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"

                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                             

                                        }


                                        i++;

                                    }

                                

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 110 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "row");
#nullable restore
#line 115 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                  

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
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "col-lg-12 col-md-12 col-sm-12  text-left");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "class", "row");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "col col-lg-4");
                    __builder3.OpenElement(74, "p");
                    __builder3.AddAttribute(75, "class", "badge badge-light selectTask ");
                    __builder3.AddContent(76, 
#nullable restore
#line 129 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                             hour.HourTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(77, " : 0 ");
                    __builder3.AddContent(78, 
#nullable restore
#line 129 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                                i

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\n                                                        <div class=\"col col-lg-4\"></div>\n                                                        <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 135 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "class", "col-lg-12 col-md-12 col-sm-12  text-left");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "class", "row");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "class", "col col-lg-4");
                    __builder3.OpenElement(86, "p");
                    __builder3.AddAttribute(87, "class", "badge badge-light ");
                    __builder3.AddContent(88, 
#nullable restore
#line 140 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                  hour.HourTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(89, " : ");
                    __builder3.AddContent(90, 
#nullable restore
#line 140 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                   i

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\n                                                        <div class=\"col col-lg-4\"></div>\n                                                        <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 146 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                            }








                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                             foreach (var task in min.Tasks)
                                            {
                                                string clock = hour.HourTime + ":" + min.MinuteTime;
                                                

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "col-lg-12 col-md-12 col-sm-12  text-left");
                    __builder3.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 163 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                  ()=>SetTaskId(@task.TaskToDoId,clock)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "class", "row");
                    __builder3.OpenElement(97, "div");
                    __builder3.AddAttribute(98, "class", "col col-lg-4 selectTask  ");
                    __builder3.AddContent(99, 
#nullable restore
#line 167 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                 task.TaskToDoId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(100, " ");
                    __builder3.AddContent(101, 
#nullable restore
#line 167 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                  task.Description

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(102, " ");
                    __builder3.AddContent(103, 
#nullable restore
#line 167 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                    task.TaskToDoCategory.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(104, " ");
                    __builder3.AddContent(105, 
#nullable restore
#line 167 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                                                                                                        task.Measurements.FirstOrDefault().MeasurementCategory.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n                                                        <div class=\"col col-lg-4\"></div>\n                                                        <div class=\"col col-lg-4\"></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 175 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"

                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 176 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                             

                                        }


                                        i++;

                                    }

                                

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 189 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 189 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                         






                    }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(107, "\n                ");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "class", "col-lg-6" + " col-md-12" + " col-sm-12" + " alert-light" + " " + (
#nullable restore
#line 200 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                      BackGroundColor

#line default
#line hidden
#nullable disable
                    ) + " " + (
#nullable restore
#line 200 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                       TextColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(110, "style", "min-height:200px;    ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "row");
#nullable restore
#line 203 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                         if (BackGroundColor == "bg-dark")
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(113, "div");
                    __builder3.AddAttribute(114, "class", "col col-lg-12");
                    __builder3.OpenElement(115, "button");
                    __builder3.AddAttribute(116, "class", "btn btn-light");
                    __builder3.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 206 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                           ChangeColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(118, "Tło");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 208 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                        }
                        else
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col col-lg-12");
                    __builder3.OpenElement(121, "button");
                    __builder3.AddAttribute(122, "class", "btn btn-dark");
                    __builder3.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 212 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                 ChangeColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(124, "Tło");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 214 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\n                    ");
                    __builder3.OpenComponent<Digital_Patient.Blazor.TaskAction>(126);
                    __builder3.AddAttribute(127, "TaskId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 218 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                         SelectedTaskId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(128, "CustomEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 218 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                       HandleTask

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(129, "TaskTime", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 218 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
                                                                                              FullTime

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(130, "MessageSet", new System.Action<System.String>(
#nullable restore
#line 218 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 229 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\MainPage.razor"
           



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
            if(BackGroundColor=="bg-dark")
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
