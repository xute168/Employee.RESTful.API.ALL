#pragma checksum "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71f7d52819c71547d4d8bf873673948912191843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Create.cshtml", typeof(AspNetCore.Views_Employee_Create))]
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
#line 1 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\_ViewImports.cshtml"
using Employee.Core;

#line default
#line hidden
#line 2 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\_ViewImports.cshtml"
using Employee.Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71f7d52819c71547d4d8bf873673948912191843", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e9d194212ddf067db935a3b5f03a7934aa613d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(57, 23, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
            BeginContext(116, 23, false);
#line 12 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(147, 86, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Employee</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(234, 64, false);
#line 17 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(298, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(347, 98, false);
#line 19 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
       Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(445, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(501, 98, false);
#line 21 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
           Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(599, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(618, 87, false);
#line 22 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(705, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(792, 97, false);
#line 27 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
       Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(889, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(945, 97, false);
#line 29 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
           Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1061, 86, false);
#line 30 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1234, 97, false);
#line 35 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
       Write(Html.LabelFor(model => model.HireDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1387, 97, false);
#line 37 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
           Write(Html.EditorFor(model => model.HireDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1503, 86, false);
#line 38 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.HireDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 255, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 48 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
}

#line default
#line hidden
            BeginContext(1847, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1861, 40, false);
#line 51 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1913, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "608a506a72374940a86732d30258df7c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1967, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1969, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e96fdaffeaa1430f98ae73178e8f98dd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2025, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2027, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2157586c38424b8cb377a4c19a2dd57e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2095, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591