#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80a0665c55589eb38f23f9c048b39108454a3a86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a0665c55589eb38f23f9c048b39108454a3a86", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 269, true);
            WriteLiteral(@"
<h2>Category List</h2>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>id</th>
        <th>category name</th>
        <th>category description</th>
        <th>category status</th>
        <th>delete</th>
        <th>update</th>
    </tr>
");
            EndContext();
#line 18 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(445, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(476, 15, false);
#line 21 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(491, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(515, 17, false);
#line 22 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(532, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(556, 24, false);
#line 23 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(item.CategoryDescription);

#line default
#line hidden
            EndContext();
            BeginContext(580, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(604, 11, false);
#line 24 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(615, 25, true);
            WriteLiteral("</td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 640, "\"", 688, 2);
            WriteAttributeValue("", 647, "/Category/CategoryDelete/", 647, 25, true);
#line 25 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 672, item.CategoryId, 672, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(689, 60, true);
            WriteLiteral(" class=\" btn btn-danger\">Delete</a></td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 749, "\"", 794, 2);
            WriteAttributeValue("", 756, "/Category/CategoryGet/", 756, 22, true);
#line 26 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 778, item.CategoryId, 778, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(795, 58, true);
            WriteLiteral(" class=\" btn btn-success\">Update</a></td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(860, 84, true);
            WriteLiteral("</table>\r\n<a href=\"/Category/CategoryAdd\" class=\" btn btn-primary\">Category Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
