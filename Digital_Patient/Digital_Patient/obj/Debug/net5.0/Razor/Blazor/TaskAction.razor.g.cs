#pragma checksum "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67d631165ded11fcfd5f1fc2acb9bb6decae1ec9"
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
#line 1 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Digital_Patient.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.EntityFrameworkCore.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class TaskAction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .HideInput {
        position: fixed;
        left: -200px;
        top: -200px;
    }


    .validation-errors {
        background-color: red;
        color: white;
        padding: 8px;
        text-align: center;
        font-size: 16px;
        font-weight: 500;
    }

    div.validation-message {
        color: red;
        font-weight: 500;
    }

    .modified.valid {
        border: solid 3px rgb(40,167,69);
    }

    .modified.invalid {
        border: solid 3px rgb(220,53,69);
    }












</style>");
#nullable restore
#line 62 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
 if (TaskId > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container" + "  " + (
#nullable restore
#line 64 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                            BackGroundColor

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 64 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                             TextColor

#line default
#line hidden
#nullable disable
            ) + "  ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-12");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.OpenElement(7, "h2");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddContent(9, 
#nullable restore
#line 68 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                             tasktime.TimeOfDay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 71 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                   editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 71 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ObjectGraphDataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n                ");
                __builder2.OpenComponent<Digital_Patient.Blazor.InitialValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n\n\n\n\n\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.OpenElement(23, "h2");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddContent(25, " Kategoria  ");
                __builder2.AddContent(26, 
#nullable restore
#line 81 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                          model.taskToDo.TaskToDoCategory.CategoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 84 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                 if (model.taskToDo.Measurements != null)
                {




                    foreach (var m in model.taskToDo.Measurements)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.OpenElement(29, "h2");
                __builder2.AddAttribute(30, "class", "form-control ");
                __builder2.AddContent(31, "Zbadaj ");
                __builder2.AddContent(32, 
#nullable restore
#line 94 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                              m.MeasurementCategory.CategoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n                        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
#nullable restore
#line 98 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                             foreach (var pair in m.MeasurementPairs)
                            {


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "clss", "row");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col col-lg-12");
                __builder2.AddContent(40, 
#nullable restore
#line 103 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                         pair.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n                                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col col-lg-12");
#nullable restore
#line 106 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                         if (pair.Text)
                                        {

#line default
#line hidden
#nullable disable
                __Blazor.Digital_Patient.Blazor.TaskAction.TypeInference.CreateValidationMessage_0(__builder2, 44, 45, 
#nullable restore
#line 108 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                                      () => pair.MeasurementText

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 109 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                                    pair.MeasurementText

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pair.MeasurementText = __value, pair.MeasurementText))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pair.MeasurementText));
                __builder2.CloseComponent();
#nullable restore
#line 110 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"

                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                __Blazor.Digital_Patient.Blazor.TaskAction.TypeInference.CreateValidationMessage_1(__builder2, 51, 52, 
#nullable restore
#line 114 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                                      () => pair.MeasurementNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\n                                            ");
                __Blazor.Digital_Patient.Blazor.TaskAction.TypeInference.CreateInputNumber_2(__builder2, 54, 55, 
#nullable restore
#line 115 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                                      pair.MeasurementNumber

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pair.MeasurementNumber = __value, pair.MeasurementNumber)), 57, () => pair.MeasurementNumber);
#nullable restore
#line 116 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"

                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 120 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"



                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "<label>Dodaj Notatkę</label>\n                            ");
                __Blazor.Digital_Patient.Blazor.TaskAction.TypeInference.CreateValidationMessage_3(__builder2, 61, 62, 
#nullable restore
#line 130 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                      () => m.Note.Text

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(63, "\n\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 133 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                    m.Note.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => m.Note.Text = __value, m.Note.Text))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => m.Note.Text));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 136 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                    }

                }
                

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(68, "<div class=\"form-group\"></div>\n\n                ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.OpenElement(71, "h2");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddContent(73, "Czas ");
                __builder2.AddContent(74, 
#nullable restore
#line 146 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
                                                   DateTime.Now.ToString("ddd, dd MMM yyy HH':'mm':'ss 'GMT'")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n                ");
                __builder2.AddMarkupContent(76, "<div class=\"form-group\"><button class=\"btn btn-danger\" type=\"submit\">Zapisz</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 165 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Blazor\TaskAction.razor"
 


    [Parameter] public Action<string> MessageSet { get; set; }

    private void ChangeMessage()
    {
        MessageSet?.Invoke("Zmiana zadania zakończona sukcesem");
    }












    [CascadingParameter(Name = "BackGroundColor1")]
    public string BackGroundColor { get; set; }
    [CascadingParameter(Name = "TextColor1")]
    public string TextColor { get; set; }


    ValidationMessageStore messageStore;
    EditContext editContext;
    EditForm editForm;

    //public TaskToDoActionModel model { get; set; } = new TaskToDoActionModel();
    public TaskToDoActionModel model { get;  set;  } = new TaskToDoActionModel();

    [Parameter]
    public string TaskTime { get; set; }
    public bool DataLogin = false;
    public TaskToDo EditTask { get; set; } = new TaskToDo();
    private Repository repository;
    public bool Check {get;set;}
    [Parameter]
    public int TaskId { get; set; } = 0;

    public DateTime tasktime { get; set; }

    public bool Done { get; set; } = false;

    [Parameter]
    public EventCallback<bool> CustomEvent { get; set; }

    public string Tekst { get; set; } = "Brak";

    public async Task DoneTask()
    {

        Done = true;
        await CustomEvent.InvokeAsync(Done);

    }

    public DateTime GetTimeFromString(string Time)
    {
        int hour = Int32.Parse(Time.Split(":")[0]);
        int minute = Int32.Parse(Time.Split(":")[1]);

        DateTime time = new DateTime(2100, 1, 1, hour, minute, 0);
        return time;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        editContext = new EditContext(model);
        messageStore = new ValidationMessageStore(editContext);
        editContext.OnFieldChanged += OnFormUpdated;




    }

    public void Dispose()
    {
        editContext.OnFieldChanged -= OnFormUpdated;
    }

    private void OnFormUpdated(Object sender, FieldChangedEventArgs args)
    {
        CheckValidation();
    }

    protected async override Task OnParametersSetAsync()
    {

        //set time here 

        //editContext = new EditContext(model);
        //messageStore = new ValidationMessageStore(editContext);


        //


        EditTask = new TaskToDo();
        ApplicationDbContext context = factory.CreateDbContext();
        repository = new Repository(context);

        if(TaskId!=0)
        {


            tasktime = GetTimeFromString(TaskTime);
            model.taskToDo =  repository.GetTaskToDo2(TaskId,tasktime);

            //


            List<Measurement> listMeasurement = model.taskToDo.Measurements;


            foreach (var measurement in listMeasurement)
            {


                foreach (var mp in measurement.MeasurementPairs)
                {

                    if(mp.Text==true&&mp.MeasurementText=="")
                    {
                        mp.MeasurementText = null;
                    }




                }

                if(  measurement.Note.Text=="")
                {
                    measurement.Note.Text = null;
                }




            }




            //

            //check if measurement pair is in time               TaskTime//






        }

    }

    public async Task HandleInvalidSubmit()
    {
        if (DataLogin)
        {
            return;
        }


        try
        {

            //using (var repo = new Repository(factory.CreateDbContext()))
            //{
            //    model.TaskCorrectTime = tasktime;
            //    repo.ChangeMeasurmentsData(model);
            //}

        }
        catch (Exception ex)
        {

        }
        finally
        {
            //model = new TaskToDoActionModel();
            DataLogin = false;

        }
    }

    private bool CheckValidation()
    {


        List<MeasurementPair> Pairs = model.taskToDo.Measurements.SelectMany(x => x.MeasurementPairs).ToList();

        Check = false;




        messageStore.Clear();

        List<Measurement> Measurements = model.taskToDo.Measurements.ToList();




        foreach (var item in Measurements)
        {

            if (item.Note.Text == "" || item.Note.Text == null )
            {
                messageStore.Add(() => item.Note.Text, "Uzupełnij dane w Notatce");
                Check = true;

            }
            else if(item.Note.Text != null && item.Note.Text.Count() < 8)
            {
                messageStore.Add(() => item.Note.Text, "Notatka musi zawierać co najmniej 8 znaków text  \" wykonano \" lub \"nie wykonano\" ");
                Check = true;
            }



        }






        //foreach (var item in Measurements)
        //{

        //    if (item.Note.Text == "" || item.Note.Text == null||item.Note.Text.Count()<8)
        //    {
        //        messageStore.Add(() => item.Note.Text, "Uzupełnij dane w Notatce");
        //        if (item.Note.Text!=null&&  item.Note.Text.Count() < 8)
        //        {
        //            messageStore.Add(() => item.Note.Text, "Notatka musi zawierać co najmniej 8 znaków text  \" wykonano \" lub \"nie wykonano\" ");
        //        }
        //    }





        //}



        foreach (var pair in Pairs)
        {

            if (pair.Text)
            {
                bool error = String.IsNullOrEmpty(pair.MeasurementText);
                if (error)
                {
                    messageStore.Add(() => pair.MeasurementText, "Uzupełnij dane w pomiarze");
                    Check = true; ;
                }

            }
            else
            {
                bool error = pair.MeasurementNumber == 0;
                if (error)
                {
                    messageStore.Add(() => pair.MeasurementNumber, "Uzupełnij dane numeryczne");
                    Check = true;
                }
            }



        }


        StateHasChanged();
        return Check;
    }

    private async Task HandleValidSubmit()
    {



        CheckValidation();


        if(Check)
        {
            editContext.Validate();
            return;
        }


        if (DataLogin)
        {
            return;
        }


        try
        {

            using (var repo = new Repository(factory.CreateDbContext()))
            {
                model.TaskCorrectTime = tasktime;
                repo.ChangeMeasurmentsData(model);

                ChangeMessage();

            }

        }
        catch (Exception ex)
        {

        }
        finally
        {
            //model = new TaskToDoActionModel();
            DataLogin = false;

        }
















    }








#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ApplicationDbContext> factory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
namespace __Blazor.Digital_Patient.Blazor.TaskAction
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
