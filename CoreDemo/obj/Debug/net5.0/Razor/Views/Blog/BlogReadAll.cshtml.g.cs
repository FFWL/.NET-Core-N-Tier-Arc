#pragma checksum "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "899170506e5b9f2505c6c21ee047201ab71033df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogReadAll), @"mvc.1.0.view", @"/Views/Blog/BlogReadAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogReadAll.cshtml", typeof(AspNetCore.Views_Blog_BlogReadAll))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899170506e5b9f2505c6c21ee047201ab71033df", @"/Views/Blog/BlogReadAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogReadAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/HeaderLayout.cshtml";

#line default
#line hidden
            BeginContext(148, 232, true);
            WriteLiteral("\r\n<!--\r\n    Author: W3layouts\r\n    Author URL: http://w3layouts.com\r\n    License: Creative Commons Attribution 3.0 Unported\r\n    License URL: http://creativecommons.org/licenses/by/3.0/\r\n-->\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            EndContext();
            BeginContext(380, 6028, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "899170506e5b9f2505c6c21ee047201ab71033df5429", async() => {
                BeginContext(386, 261, true);
                WriteLiteral(@"

    <!--//banner-->
    <section class=""banner-bottom"">
        <!--/blog-->
        <div class=""container"">
            <div class=""row"">
                <!--left-->
                <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
");
                EndContext();
#line 27 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(720, 274, true);
                WriteLiteral(@"                        <div class=""blog-grid-top"">
                            <div class=""b-grid-top"">
                                <div class=""blog_info_left_grid"">
                                    <a href=""single.html"">
                                        ");
                EndContext();
                BeginContext(994, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "899170506e5b9f2505c6c21ee047201ab71033df6665", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1050, 378, true);
                WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""blog-info-middle"">
                                    <ul>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-calendar-alt""></i> ");
                EndContext();
                BeginContext(1430, 55, false);
#line 40 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                                                                Write(((DateTime)item.blogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1486, 909, true);
                WriteLiteral(@"
                                            </a>
                                        </li>
                                        <li class=""mx-2"">
                                            <a href=""#"">
                                                <i class=""far fa-thumbs-up""></i> 201 Likes
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-comment""></i> 15 Comments
                                            </a>
                                        </li>

                                    </ul>
                                </div>
                            </div>

                            <h3>
                                <a href=""single.html"">");
                EndContext();
                BeginContext(2396, 14, false);
#line 59 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                                 Write(item.blogTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2410, 106, true);
                WriteLiteral("</a>\r\n                            </h3>\r\n                            <p>\r\n                                ");
                EndContext();
                BeginContext(2517, 16, false);
#line 62 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                           Write(item.blogContent);

#line default
#line hidden
                EndContext();
                BeginContext(2533, 165, true);
                WriteLiteral("\r\n                            </p>\r\n                            <a href=\"/Blog/Index/\" class=\"btn btn-primary read-m\">Read More</a>\r\n                        </div>\r\n");
                EndContext();
#line 66 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                    }

#line default
#line hidden
                BeginContext(2721, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(2742, 71, false);
#line 67 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
               Write(await Component.InvokeAsync("CommentListByBlog", new { id = ViewBag.i}));

#line default
#line hidden
                EndContext();
                BeginContext(2813, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2909, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2932, 67, false);
#line 70 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/PartialAddComment.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(2999, 310, true);
                WriteLiteral(@"

                </div>

                <!--//left-->
                <!--right-->
                <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                    <div class=""right-blog-info text-left"">
                        <div class=""tech-btm"">
                            ");
                EndContext();
                BeginContext(3309, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "899170506e5b9f2505c6c21ee047201ab71033df12420", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3370, 60, true);
                WriteLiteral("\r\n                        </div>\r\n\r\n                        ");
                EndContext();
                BeginContext(3431, 66, false);
#line 82 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(3497, 28, true);
                WriteLiteral("\r\n\r\n                        ");
                EndContext();
                BeginContext(3526, 43, false);
#line 84 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
                EndContext();
                BeginContext(3569, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(3596, 45, false);
#line 85 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Component.InvokeAsync("WriterLastBlog"));

#line default
#line hidden
                EndContext();
                BeginContext(3641, 2097, true);
                WriteLiteral(@" 
                        <div class=""single-gd my-5 tech-btm"">
                            <h4>Our Progress</h4>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
");
                WriteLiteral(@"                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                        </div>
                        <div class=""single-gd tech-btm"">
                            <h4>Recent Post</h4>
                            <div class=""blog-grids"">
                                <div class=""blog-grid-left"">
                                    <a href=""single.html"">
                                 ");
                WriteLiteral("       <img src=\"images/b1.jpg\" class=\"img-fluid\"");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 5738, "\"", 5744, 0);
                EndWriteAttribute();
                BeginContext(5745, 656, true);
                WriteLiteral(@">
                                    </a>
                                </div>
                                <div class=""blog-grid-right"">

                                    <h5>
                                        <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                                    </h5>
                                </div>
                                <div class=""clearfix""> </div>
                            </div>
                        </div>
                    </div>

                </aside>
                <!--//right-->
            </div>
        </div>
    </section>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6408, 15, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
