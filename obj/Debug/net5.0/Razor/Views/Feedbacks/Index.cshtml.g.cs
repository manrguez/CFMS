#pragma checksum "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "612d6d798face5da5d4e8187a838f9bbfeff6af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedbacks_Index), @"mvc.1.0.view", @"/Views/Feedbacks/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"612d6d798face5da5d4e8187a838f9bbfeff6af0", @"/Views/Feedbacks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273c81fafa23c0f4208f2c4cd5adf133afa1ec05", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Feedbacks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CFMS.Models.Feedback>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\Index.cshtml"
  
    ViewData["Title"] = "Feedbacks";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Feedbacks</h1>

<p>    
    <button type=""button"" class=""btn btn-sm btn-success pull-right"" data-toggle=""modal"" data-target=""#modalCreate"" onclick=""LoadModalContent('/Feedbacks/Create')"">Add new</button>
</p>

<div id=""containerList"">
    <!-- partial view to render feedbacks list and realoading using ajax call -->
    ");
#nullable restore
#line 15 "C:\Users\Luis\source\repos\CFMS\Views\Feedbacks\Index.cshtml"
Write(Html.Partial("_List", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>


<div class=""modal fade"" role=""dialog"" id=""modalCreate"" data-backdrop=""false"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-body"" id=""modalContent"">
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CFMS.Models.Feedback>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591