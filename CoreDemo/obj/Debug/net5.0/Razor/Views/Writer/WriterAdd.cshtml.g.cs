#pragma checksum "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Writer\WriterAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "530af013dff6bf979c8d249107949a79580108d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterAdd), @"mvc.1.0.view", @"/Views/Writer/WriterAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Writer/WriterAdd.cshtml", typeof(AspNetCore.Views_Writer_WriterAdd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"530af013dff6bf979c8d249107949a79580108d1", @"/Views/Writer/WriterAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDemo.Models.AddProfileImage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Writer\WriterAdd.cshtml"
  
    ViewData["Title"] = "WriterAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
            BeginContext(137, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(139, 2084, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "530af013dff6bf979c8d249107949a79580108d14648", async() => {
                BeginContext(208, 204, true);
                WriteLiteral("\r\n    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Writer Profile Edit Page</h4>\r\n                ");
                EndContext();
                BeginContext(413, 64, false);
#line 12 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Writer\WriterAdd.cshtml"
           Write(Html.HiddenFor(x => x.writerID, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(477, 185, true);
                WriteLiteral("\r\n                <div class=\"forms-sample\">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Name</label>\r\n                        ");
                EndContext();
                BeginContext(663, 67, false);
#line 16 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Writer\WriterAdd.cshtml"
                   Write(Html.TextBoxFor(x => x.writerName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(730, 179, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputEmail3\">Email address</label>\r\n                        ");
                EndContext();
                BeginContext(910, 67, false);
#line 20 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Writer\WriterAdd.cshtml"
                   Write(Html.TextBoxFor(x => x.writerMail, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(977, 177, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">Password</label>\r\n                        ");
                EndContext();
                BeginContext(1155, 72, false);
#line 24 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Writer\WriterAdd.cshtml"
                   Write(Html.PasswordFor(x => x.writerPassword, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1227, 269, true);
                WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword4"">Re-Write Password</label>
                        <input type=""password"" name=""passwordAgain"" class=""form-control"" id=""passwordAgain""");
                EndContext();
                BeginWriteAttribute("required", " required=\"", 1496, "\"", 1507, 0);
                EndWriteAttribute();
                BeginContext(1508, 365, true);
                WriteLiteral(@" />
                    </div>
                    <div class=""form-group"">
                        <label>Image upload</label>
                        <input type=""file"" name=""writerImage"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleTextarea1"">About</label>
                        ");
                EndContext();
                BeginContext(1874, 76, false);
#line 36 "C:\Users\ASUS\source\repos\CoreDemo\CoreDemo\Views\Writer\WriterAdd.cshtml"
                   Write(Html.TextAreaFor(x => x.writerAbout, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1950, 266, true);
                WriteLiteral(@"
                    </div>
                    <button type=""submit"" class=""btn btn-gradient-primary mr-2"">Submit</button>
                    <button class=""btn btn-light"">Cancel</button>
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2223, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDemo.Models.AddProfileImage> Html { get; private set; }
    }
}
#pragma warning restore 1591
