#pragma checksum "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0916a059e10435089008a9cb2287587f4249182f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryListDashboard/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryListDashboard_Default))]
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
#line 1 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#line 2 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#line 1 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0916a059e10435089008a9cb2287587f4249182f", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 659, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Project Status</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Name </th>
                                <th> Due Date </th>
                                <th> Progress </th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 19 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                             foreach(var item in Model) {

#line default
#line hidden
            BeginContext(770, 71, true);
            WriteLiteral("                            <tr>\r\n                                <td> ");
            EndContext();
            BeginContext(842, 15, false);
#line 21 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                Write(item.categoryID);

#line default
#line hidden
            EndContext();
            BeginContext(857, 45, true);
            WriteLiteral(" </td>\r\n                                <td> ");
            EndContext();
            BeginContext(903, 17, false);
#line 22 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                Write(item.categoryName);

#line default
#line hidden
            EndContext();
            BeginContext(920, 45, true);
            WriteLiteral(" </td>\r\n                                <td> ");
            EndContext();
            BeginContext(966, 19, false);
#line 23 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                Write(item.categoryStatus);

#line default
#line hidden
            EndContext();
            BeginContext(985, 413, true);
            WriteLiteral(@" </td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                            </tr>
");
            EndContext();
#line 30 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(1429, 142, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
