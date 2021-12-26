#pragma checksum "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67ba9cfb5543497a6b2171c5b2a1a451e4aecac6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogListByWriter.cshtml", typeof(AspNetCore.Views_Blog_BlogListByWriter))]
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
#line 1 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67ba9cfb5543497a6b2171c5b2a1a451e4aecac6", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
            BeginContext(152, 271, true);
            WriteLiteral(@"
<h1>BlogListByWriter</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Blog Title</th>
        <th>Creation Date</th>
        <th>Category</th>
        <th>Status</th>
        <th>Edit</th>
        <th>Delete</th>
    </tr>
");
            EndContext();
#line 20 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(464, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(495, 11, false);
#line 23 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.blogID);

#line default
#line hidden
            EndContext();
            BeginContext(506, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(530, 14, false);
#line 24 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.blogTitle);

#line default
#line hidden
            EndContext();
            BeginContext(544, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(569, 55, false);
#line 25 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            Write(((DateTime)item.blogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(625, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(649, 26, false);
#line 26 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.Category.categoryName);

#line default
#line hidden
            EndContext();
            BeginContext(675, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
             if (@item.blogStatus)
            {

#line default
#line hidden
            BeginContext(733, 63, true);
            WriteLiteral("                <td><h6 style=\"color:green;\">Active</h6></td>\r\n");
            EndContext();
#line 30 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(844, 62, true);
            WriteLiteral("                <td><h6 style=\"color:red;\">Passive</h6></td>\r\n");
            EndContext();
#line 34 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            }

#line default
#line hidden
            BeginContext(921, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 939, "\"", 975, 2);
            WriteAttributeValue("", 946, "/Blog/DeleteBlog/", 946, 17, true);
#line 35 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 963, item.blogID, 963, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(976, 66, true);
            WriteLiteral(" class=\"btn btn-danger delete\">Delete</a></td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1042, "\"", 1076, 2);
            WriteAttributeValue("", 1049, "/Blog/EditBlog/", 1049, 15, true);
#line 36 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1064, item.blogID, 1064, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1077, 60, true);
            WriteLiteral(" class=\"btn btn-warning edit\">Edit</a></td>\r\n        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
    }

#line default
#line hidden
            BeginContext(1144, 75, true);
            WriteLiteral("</table>\r\n<a href=\"/Blog/BlogAdd/\" class=\"btn btn-primary\">New Blog</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
