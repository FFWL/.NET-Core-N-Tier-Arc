#pragma checksum "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75260a5624e18ef8fa92699cbc92b40b4beb60be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/WriterNotification/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_WriterNotification_Default))]
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
#line 1 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75260a5624e18ef8fa92699cbc92b40b4beb60be", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 164, true);
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Notifications</h6>\r\n");
            EndContext();
#line 6 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(261, 159, true);
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\r\n        <a class=\"dropdown-item preview-item\">\r\n            <div class=\"preview-thumbnail\">\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 420, "\"", 455, 1);
#line 11 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 428, item.notificationTypeColor, 428, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(456, 25, true);
            WriteLiteral(">\r\n                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 481, "\"", 517, 1);
#line 12 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 489, item.notificationTypeSymbol, 489, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(518, 227, true);
            WriteLiteral("></i>\r\n                </div>\r\n            </div>\r\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                <h6 class=\"preview-subject font-weight-normal mb-1\">");
            EndContext();
            BeginContext(746, 21, false);
#line 16 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                               Write(item.notificationType);

#line default
#line hidden
            EndContext();
            BeginContext(767, 59, true);
            WriteLiteral("</h6>\r\n                <p class=\"text-gray ellipsis mb-0\"> ");
            EndContext();
            BeginContext(827, 24, false);
#line 17 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
                                               Write(item.notificationDetails);

#line default
#line hidden
            EndContext();
            BeginContext(851, 41, true);
            WriteLiteral(" </p>\r\n            </div>\r\n        </a>\r\n");
            EndContext();
#line 20 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(899, 657, true);
            WriteLiteral(@"    <div class=""dropdown-divider""></div>
    <a class=""dropdown-item preview-item"">
        <div class=""preview-thumbnail"">
            <div class=""preview-icon bg-warning"">
                <i class=""mdi mdi-settings""></i>
            </div>
        </div>
        <div class=""preview-item-content d-flex align-items-start flex-column justify-content-center"">
            <h6 class=""preview-subject font-weight-normal mb-1"">Settings</h6>
            <p class=""text-gray ellipsis mb-0""> Update dashboard </p>
        </div>
    </a>
    <div class=""dropdown-divider""></div>
    <h6 class=""p-3 mb-0 text-center"">See all notifications</h6>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
