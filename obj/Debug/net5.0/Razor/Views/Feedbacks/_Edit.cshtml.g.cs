#pragma checksum "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c468673a8cd621e59b17caa53c65893ed5962978"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedbacks__Edit), @"mvc.1.0.view", @"/Views/Feedbacks/_Edit.cshtml")]
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
#line 1 "C:\Users\Luis\source\repos\CFMS\Views\_ViewImports.cshtml"
using CFMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luis\source\repos\CFMS\Views\_ViewImports.cshtml"
using CFMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c468673a8cd621e59b17caa53c65893ed5962978", @"/Views/Feedbacks/_Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273c81fafa23c0f4208f2c4cd5adf133afa1ec05", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Feedbacks__Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CFMS.Models.Feedback>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    <h2>Edit Feedback</h2>\r\n    <button class=\"btn btn-sm pull-right btn-danger\" type=\"button\" id=\"btnClose\" data-dismiss=\"modal\">X</button>    \r\n</div>\r\n\r\n<div class=\"modal-body\">\r\n");
#nullable restore
#line 9 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
     using (Html.BeginForm("Edit", "Feedbacks", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\" id=\"CreateFrm\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
       Write(Html.HiddenFor(model => model.FeedbackId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 16 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
           Write(Html.LabelFor(model => model.CustomerName, htmlAttributes: new { @class = "control-label col-md-6" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
               Write(Html.EditorFor(model => model.CustomerName, new { htmlAttributes = new { @class = "form-control", id="CustomerName", name="CustomerName" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
           Write(Html.LabelFor(model => model.Category, htmlAttributes: new { @class = "control-label col-md-6" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
               Write(Html.EditorFor(model => model.Category, new { htmlAttributes = new { @class = "form-control", id="Category", name="Category" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
           Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-6" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
               Write(Html.TextAreaFor(model => model.Description, new { name="Description", id="Description", rows = 10, cols = 50 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \r\n                </div>\r\n            </div>\r\n           \r\n        </div>\r\n        <div class=\"modal-footer\">           \r\n            <input type=\"button\" value=\"Save\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1855, "\"", 1896, 3);
            WriteAttributeValue("", 1865, "EditFeedback(", 1865, 13, true);
#nullable restore
#line 38 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
WriteAttributeValue("", 1878, Model.FeedbackId, 1878, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1895, ")", 1895, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n");
#nullable restore
#line 40 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\_Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CFMS.Models.Feedback> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
