#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b40d5de0d4b57a11aa68289d682d31a2aa4ab73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Food/Index.cshtml", typeof(AspNetCore.Views_Food_Index))]
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
#line 1 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#line 2 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b40d5de0d4b57a11aa68289d682d31a2aa4ab73", @"/Views/Food/Index.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(186, 307, true);
            WriteLiteral(@"
<h2>Food List</h2>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>id</th>
        <th>food name</th>
        <th>price</th>
        <th>food stok</th>
        <th>category name</th>
        <th>food description</th>
        <th>delete</th>
        <th>update</th>
    </tr>
");
            EndContext();
#line 22 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(534, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(565, 11, false);
#line 25 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.FoodId);

#line default
#line hidden
            EndContext();
            BeginContext(576, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(600, 13, false);
#line 26 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.FoodName);

#line default
#line hidden
            EndContext();
            BeginContext(613, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(637, 10, false);
#line 27 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(647, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(671, 10, false);
#line 28 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(681, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(705, 26, false);
#line 29 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(731, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(755, 16, false);
#line 30 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(771, 25, true);
            WriteLiteral("</td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 796, "\"", 832, 2);
            WriteAttributeValue("", 803, "/Food/DeleteFood/", 803, 17, true);
#line 31 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 820, item.FoodId, 820, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(833, 60, true);
            WriteLiteral(" class=\" btn btn-danger\">Delete</a></td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 893, "\"", 926, 2);
            WriteAttributeValue("", 900, "/Food/GetFood/", 900, 14, true);
#line 32 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 914, item.FoodId, 914, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(927, 58, true);
            WriteLiteral(" class=\" btn btn-success\">Update</a></td>\r\n        </tr>\r\n");
            EndContext();
#line 34 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(992, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(1003, 78, false);
#line 36 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index", new { page })));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 63, true);
            WriteLiteral("\r\n<a href=\"/Food/AddFood\" class=\" btn btn-primary\">new food</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
