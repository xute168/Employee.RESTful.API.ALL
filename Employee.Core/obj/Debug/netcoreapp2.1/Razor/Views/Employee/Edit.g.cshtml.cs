#pragma checksum "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a39b1b73a29f2bce1b88e993287606f36e31b8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Edit), @"mvc.1.0.view", @"/Views/Employee/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Edit.cshtml", typeof(AspNetCore.Views_Employee_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a39b1b73a29f2bce1b88e993287606f36e31b8c", @"/Views/Employee/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e9d194212ddf067db935a3b5f03a7934aa613d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
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
#line 3 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(55, 21, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(111, 23, false);
#line 12 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(142, 86, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Employee</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(229, 64, false);
#line 17 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(293, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(304, 41, false);
#line 18 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
   Write(Html.HiddenFor(model => model.EmployeeId));

#line default
#line hidden
            EndContext();
            BeginContext(345, 50, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(396, 98, false);
#line 21 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
       Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(494, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(550, 98, false);
#line 23 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
           Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(648, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(667, 87, false);
#line 24 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(754, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(841, 97, false);
#line 29 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
       Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(938, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(994, 97, false);
#line 31 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
           Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1110, 86, false);
#line 32 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1283, 97, false);
#line 37 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
       Write(Html.LabelFor(model => model.HireDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1436, 97, false);
#line 39 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
           Write(Html.EditorFor(model => model.HireDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1552, 86, false);
#line 40 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.HireDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 253, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 50 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(1894, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1908, 40, false);
#line 53 "D:\Users\mxu@aocit.com\source\repos\Employee.RESTful.API.ALL\Employee.Core\Views\Employee\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1960, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d0f94742dc41f594c06a09c386d0ea", async() => {
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
            BeginContext(2014, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2016, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51890b356c9e4eb2acdf57cad4930651", async() => {
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
            BeginContext(2072, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2074, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28eb7f79f54a40aaaf904bff5afef405", async() => {
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
            BeginContext(2142, 2, true);
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
