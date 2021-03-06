#pragma checksum "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Writercontroller\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff758f500094b7bde1b708375365a2da32b6a9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writercontroller_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writercontroller/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Writercontroller/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Writercontroller_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff758f500094b7bde1b708375365a2da32b6a9a", @"/Areas/Admin/Views/Writercontroller/Index.cshtml")]
    public class Areas_Admin_Views_Writercontroller_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Writercontroller\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(94, 167, true);
            WriteLiteral("\r\n<h1>Ajax</h1>\r\n<br />\r\n\r\n<button type=\"button\" id=\"btnlist\" class=\"btn btn-outline-primary\">Writer List</button>\r\n<br />\r\n<br />\r\n<div id=\"writerlist\">\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(278, 728, true);
                WriteLiteral(@" 
<script>
    $(""#btngetlist"").click(function () {
        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""Get"",
            url: ""/Admin/Writer/WriterList"",
            success: function (func) {
                let w = JQuery.parseJSON(func);
                let tablehtml = ""<table class=table table-bordered><tr><th>Writer ID </th><th>Writer Name</th></tr>"";
                $.each(w, (index, value) => {
                    tablehtml += `<tr><td>${value.Id}</td> <td>${value.Name}</td></tr>`
                });
                tablehtml += ""</table>"";
                $(""#writerlist"").html(tablehtml);
            }
        });
    });
</script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
