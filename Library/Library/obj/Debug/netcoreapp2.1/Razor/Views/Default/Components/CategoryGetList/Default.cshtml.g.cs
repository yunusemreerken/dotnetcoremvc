#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Components\CategoryGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c4637af779abd7f5b27815a4829fbd3751d473f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Default/Components/CategoryGetList/Default.cshtml", typeof(AspNetCore.Views_Default_Components_CategoryGetList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4637af779abd7f5b27815a4829fbd3751d473f", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
    public class Views_Default_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 30, true);
            WriteLiteral("\r\n<h1>Kategoriler</h1>\r\n<ul>\r\n");
            EndContext();
#line 5 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Components\CategoryGetList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(121, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 135, "\"", 172, 2);
            WriteAttributeValue("", 142, "/Default/Book/", 142, 14, true);
#line 7 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Components\CategoryGetList\Default.cshtml"
WriteAttributeValue("", 156, item.CategoryId, 156, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(173, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(175, 27, false);
#line 7 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Components\CategoryGetList\Default.cshtml"
                                                Write(item.CategoryName.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(202, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 8 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Components\CategoryGetList\Default.cshtml"

    }

#line default
#line hidden
            BeginContext(222, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
