#pragma checksum "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Movies\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af07ecb5073173a0e9e4dbf1ede69494f510a8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Edit), @"mvc.1.0.view", @"/Views/Movies/Edit.cshtml")]
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
#line 1 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\_ViewImports.cshtml"
using Mypros.MvcDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\_ViewImports.cshtml"
using Mypros.MvcDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af07ecb5073173a0e9e4dbf1ede69494f510a8e", @"/Views/Movies/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c389b5336f47102d89677cad65ce9adf6d3f1513", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mypros.MvcDemo.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Movies\Edit.cshtml"
  
    ViewData["Title"] = "编辑页";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8af07ecb5073173a0e9e4dbf1ede69494f510a8e3655", async() => {
                WriteLiteral("\r\n<h2>编辑页</h2>\r\n<p>ID：");
#nullable restore
#line 7 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Movies\Edit.cshtml"
 Write(Html.DisplayFor(model=>model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>标题：");
#nullable restore
#line 8 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Movies\Edit.cshtml"
 Write(Html.EditorFor(model=>model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>URL:");
#nullable restore
#line 9 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Movies\Edit.cshtml"
  Write(Html.EditorFor(model => model.Url));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p> ");
#nullable restore
#line 10 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Movies\Edit.cshtml"
Write(Html.EditorFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 11 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Movies\Edit.cshtml"
Write(Html.EditorFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n <div class=\"form-group\">\r\n    <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n </div>\r\n<div>\r\n");
                WriteLiteral("</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mypros.MvcDemo.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
