#pragma checksum "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb69d7b277453faca31b6630b324039381115a33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogAdd.cshtml", typeof(AspNetCore.Views_Blog_BlogAdd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb69d7b277453faca31b6630b324039381115a33", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
            BeginContext(129, 32, true);
            WriteLiteral("\r\n<h1>Create Blog</h1>\r\n<br />\r\n");
            EndContext();
#line 9 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
 using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(230, 19, false);
#line 11 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Title"));

#line default
#line hidden
            EndContext();
            BeginContext(256, 66, false);
#line 12 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.blogTitle, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(329, 43, false);
#line 13 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.blogTitle));

#line default
#line hidden
            EndContext();
            BeginContext(374, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(391, 24, false);
#line 15 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Image"));

#line default
#line hidden
            EndContext();
            BeginContext(422, 66, false);
#line 16 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.blogImage, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(495, 43, false);
#line 17 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.blogImage));

#line default
#line hidden
            EndContext();
            BeginContext(540, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(557, 28, false);
#line 19 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Thumbnail"));

#line default
#line hidden
            EndContext();
            BeginContext(592, 75, false);
#line 20 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.blogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(669, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(686, 22, false);
#line 22 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
            EndContext();
            BeginContext(715, 101, false);
#line 23 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.DropDownListFor(x=>x.categoryID,(List<SelectListItem>)ViewBag.cv, new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(818, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(835, 26, false);
#line 25 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Content"));

#line default
#line hidden
            EndContext();
            BeginContext(868, 76, false);
#line 26 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextAreaFor(x => x.blogContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(951, 45, false);
#line 27 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.blogContent));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 64, true);
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Add Blog</button>\r\n");
            EndContext();
#line 31 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
}

#line default
#line hidden
            BeginContext(1067, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591