#pragma checksum "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Singers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2385a174a031820702d802ebc505cbe3ca954533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Singers_Details), @"mvc.1.0.view", @"/Views/Singers/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2385a174a031820702d802ebc505cbe3ca954533", @"/Views/Singers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c389b5336f47102d89677cad65ce9adf6d3f1513", @"/Views/_ViewImports.cshtml")]
    public class Views_Singers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mypros.MvcDemo.Models.Singer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Singers\Details.cshtml"
  
    ViewData["Title"] = "详细页";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>详细页</h2>\r\n<p>ID：");
#nullable restore
#line 7 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Singers\Details.cshtml"
 Write(Html.DisplayFor(model=>model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>标题：");
#nullable restore
#line 8 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Singers\Details.cshtml"
 Write(Html.DisplayFor(model=>model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mypros.MvcDemo.Models.Singer> Html { get; private set; }
    }
}
#pragma warning restore 1591
