#pragma checksum "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7572a049827aac661b101d749641e6e9be3dca6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Views\_ViewImports.cshtml"
using Digital_Patient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Views\_ViewImports.cshtml"
using Digital_Patient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7572a049827aac661b101d749641e6e9be3dca6d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f7aa6bed3c89962e97feb8bf09ad3409dcbb6dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainPageViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7572a049827aac661b101d749641e6e9be3dca6d3398", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(Digital_Patient.Blazor.MainPage);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("param-ApplicationUserId", "Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper", "Parameters"));
            }
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["ApplicationUserId"] = Model.UserId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("param-ApplicationUserId", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["ApplicationUserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "C:\Users\tomszek\Desktop\DigitalPatient\Digital_Patient\Digital_Patient\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Server;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n   \r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
