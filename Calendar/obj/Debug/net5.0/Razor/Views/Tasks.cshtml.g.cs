#pragma checksum "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff1ce01cd1d9923fea1b74aa60c27a2d0c083021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks), @"mvc.1.0.view", @"/Views/Tasks.cshtml")]
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
#line 1 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
using Calendar.ModelViews;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff1ce01cd1d9923fea1b74aa60c27a2d0c083021", @"/Views/Tasks.cshtml")]
    public class Views_Tasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TasksView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
  
    DateTime date = Model.Date;
    List<Calendar.Models.Task> tasks = Model.Tasks;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1ce01cd1d9923fea1b74aa60c27a2d0c0830214329", async() => {
                WriteLiteral("\r\n    <title>Tasks</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff1ce01cd1d9923fea1b74aa60c27a2d0c0830214619", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1ce01cd1d9923fea1b74aa60c27a2d0c0830216588", async() => {
                WriteLiteral("\r\n    <h2>");
#nullable restore
#line 16 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
   Write(date.ToString("dddd, dd MMMM yyyy", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    <ul>\r\n");
#nullable restore
#line 18 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
          
            foreach (var task in tasks) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\r\n                    <form method=\"post\" action=\"/Delete/Task\">\r\n                        <span>");
#nullable restore
#line 22 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
                         Write(task.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("     </span>\r\n                        <span>");
#nullable restore
#line 23 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
                         Write(task.Desc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 704, "\"", 720, 1);
#nullable restore
#line 24 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
WriteAttributeValue("", 712, task.Id, 712, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                        <input type=\"submit\" value=\"Delete\" />\r\n                    </form>\r\n                </li>\r\n");
#nullable restore
#line 28 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <form method=\"post\" action=\"/Add/Task\">\r\n        <input type=\"hidden\" name=\"Year\"");
                BeginWriteAttribute("value", " value=\"", 974, "\"", 992, 1);
#nullable restore
#line 32 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
WriteAttributeValue("", 982, date.Year, 982, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"Month\"");
                BeginWriteAttribute("value", " value=\"", 1039, "\"", 1058, 1);
#nullable restore
#line 33 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
WriteAttributeValue("", 1047, date.Month, 1047, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"Day\"");
                BeginWriteAttribute("value", " value=\"", 1103, "\"", 1120, 1);
#nullable restore
#line 34 "C:\Users\art10\source\repos\Calendar\Calendar\Views\Tasks.cshtml"
WriteAttributeValue("", 1111, date.Day, 1111, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"time\" name=\"Time\" required />\r\n        <input type=\"text\" name=\"Desc\" placeholder=\"Description\" required />\r\n        <input type=\"submit\" value=\"Add\" />\r\n    </form>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TasksView> Html { get; private set; }
    }
}
#pragma warning restore 1591
