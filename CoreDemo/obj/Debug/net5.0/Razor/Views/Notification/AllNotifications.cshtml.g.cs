#pragma checksum "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "143d32cc62392e2f48580f5dd224c811ae46297e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotifications), @"mvc.1.0.view", @"/Views/Notification/AllNotifications.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Notification/AllNotifications.cshtml", typeof(AspNetCore.Views_Notification_AllNotifications))]
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
#line 1 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"143d32cc62392e2f48580f5dd224c811ae46297e", @"/Views/Notification/AllNotifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_AllNotifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
  
    ViewData["Title"] = "AllNotifications";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
            BeginContext(160, 159, true);
            WriteLiteral("\r\n<h1>Notifications</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Notification</th>\r\n        <th>Date</th>\r\n    </tr>\r\n");
            EndContext();
#line 15 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
            BeginContext(367, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(414, 19, false);
#line 18 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
                   Write(item.notificationID);

#line default
#line hidden
            EndContext();
            BeginContext(433, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(465, 24, false);
#line 19 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
                   Write(item.notificationDetails);

#line default
#line hidden
            EndContext();
            BeginContext(489, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(521, 41, false);
#line 20 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
                   Write(item.notificationDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(562, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 22 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotifications.cshtml"
            }

#line default
#line hidden
            BeginContext(607, 10, true);
            WriteLiteral("</table>\r\n");
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