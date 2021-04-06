#pragma checksum "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c385f2a6f2a98d4d222adc054351f3106a2537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c385f2a6f2a98d4d222adc054351f3106a2537", @"/Views/Book/Index.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Data.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 1670, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card card-plain"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title mt-0""> Book Operations</h4>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-hover"">
                        <thead class="""">
                            <tr>
                                <th>
                                    ID
                                </th>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Author
                                </th>
                                <th>
                                    Publisher
                                </th>
                                <th>
                                    Category
        ");
            WriteLiteral(@"                        </th>
                                <th>
                                    Price
                                </th>
                                <th>
                                    Cover Image
                                </th>
                                <th>
                                    Operations
                                </th>
                                <th>
                                    Details
                                </th>
                            </tr>
                        </thead>
                        <tbody class=""tbody-image"">
");
            EndContext();
#line 48 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1893, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2014, 11, false);
#line 52 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
                                   Write(item.BookId);

#line default
#line hidden
            EndContext();
            BeginContext(2025, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2153, 13, false);
#line 55 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
                                   Write(item.BookName);

#line default
#line hidden
            EndContext();
            BeginContext(2166, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2294, 11, false);
#line 58 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
                                   Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(2305, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2433, 18, false);
#line 61 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
                                   Write(item.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(2451, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2579, 26, false);
#line 64 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
                                   Write(item.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(2605, 129, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ₺ ");
            EndContext();
            BeginContext(2735, 10, false);
#line 67 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
                                     Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2745, 131, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2876, "\"", 2898, 1);
#line 70 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
WriteAttributeValue("", 2882, item.CoverImage, 2882, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2899, "\"", 2920, 2);
#line 70 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
WriteAttributeValue("", 2905, item.BookName, 2905, 14, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2919, "", 2920, 1, true);
            EndWriteAttribute();
            BeginContext(2921, 303, true);
            WriteLiteral(@" />
                                    </td>
                                    <td class=""td-actions text-right"">
                                        <div rel=""tooltip"" title="""" class=""btn btn-primary btn-link btn-sm"" data-original-title=""Edit"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3224, "\"", 3254, 2);
            WriteAttributeValue("", 3231, "/Book/Edit/", 3231, 11, true);
#line 74 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
WriteAttributeValue("", 3242, item.BookId, 3242, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3255, 405, true);
            WriteLiteral(@"><i class=""material-icons"">edit</i></a>
                                            <div class=""ripple-container""></div>
                                        </div>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-danger btn-link btn-sm"" data-original-title=""Remove"" aria-describedby=""tooltip416464"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3660, "\"", 3692, 2);
            WriteAttributeValue("", 3667, "/Book/Delete/", 3667, 13, true);
#line 78 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
WriteAttributeValue("", 3680, item.BookId, 3680, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3693, 496, true);
            WriteLiteral(@"><i class=""material-icons"">close</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                    </td>
                                    <td>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-success btn-link btn-sm"" data-original-title=""Details"" aria-describedby=""tooltip416464"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4189, "\"", 4222, 2);
            WriteAttributeValue("", 4196, "/Book/Details/", 4196, 14, true);
#line 84 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"
WriteAttributeValue("", 4210, item.BookId, 4210, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4223, 260, true);
            WriteLiteral(@"> <i class=""material-icons"">segment</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                    </td>
                                </tr>
");
            EndContext();
#line 89 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(4516, 268, true);
            WriteLiteral(@"

                        </tbody>
                    </table>
                    <a href=""/Book/Add"" class=""btn btn-primary""><i class=""material-icons"">library_add</i> New Book</a>

                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Data.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591