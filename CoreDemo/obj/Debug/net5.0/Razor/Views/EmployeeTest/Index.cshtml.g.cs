#pragma checksum "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec405557607be4e292e20f8f40e675861132fefa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeTest_Index), @"mvc.1.0.view", @"/Views/EmployeeTest/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeTest/Index.cshtml", typeof(AspNetCore.Views_EmployeeTest_Index))]
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
#line 1 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
using CoreDemo.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec405557607be4e292e20f8f40e675861132fefa", @"/Views/EmployeeTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Class1>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(142, 162, true);
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Name Surname</th>\r\n        <th>Delete</th>\r\n        <th>Edit</th>\r\n    </tr>\r\n");
            EndContext();
#line 16 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
            BeginContext(352, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(399, 7, false);
#line 19 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
                   Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(406, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(438, 9, false);
#line 20 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(447, 33, true);
            WriteLiteral("</td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 480, "\"", 524, 2);
            WriteAttributeValue("", 487, "/EmployeeTest/DeleteEmployee/", 487, 29, true);
#line 21 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 516, item.ID, 516, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(525, 75, true);
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 600, "\"", 642, 2);
            WriteAttributeValue("", 607, "/EmployeeTest/EditEmployee/", 607, 27, true);
#line 22 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 634, item.ID, 634, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(643, 71, true);
            WriteLiteral(" class=\"btn btn-outline-warning\">Edit</a></td>\r\n                </tr>\r\n");
            EndContext();
#line 24 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(729, 99, true);
            WriteLiteral("</table>\r\n\r\n<a href=\"/EmployeeTest/AddEmployee/\" class=\"btn btn-outline-primary\">New Employee</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Class1>> Html { get; private set; }
    }
}
#pragma warning restore 1591