#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\MemberBook\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de73c71536555912d8eb9277f5b9ea70adcb5b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberBook_Index), @"mvc.1.0.view", @"/Views/MemberBook/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MemberBook/Index.cshtml", typeof(AspNetCore.Views_MemberBook_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de73c71536555912d8eb9277f5b9ea70adcb5b3", @"/Views/MemberBook/Index.cshtml")]
    public class Views_MemberBook_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Data.Models.MemberBook>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\MemberBook\Index.cshtml"
      
        ViewData["Title"] = "Index";
        Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
            BeginContext(160, 1458, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card card-plain"">
                <div class=""card-header card-header-primary"">
                    <h4 class=""card-title mt-0""> Loaned Book Operations</h4>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover"">
                            <thead class="""">
                                <tr>

                                    <th>
                                       Book Name
                                    </th>
                                    <th>
                                        Member Name
                                    </th>
                                    <th>
                                        Loaned Date
                                    </th>
                                    <th>
                                        Cover Image
              ");
            WriteLiteral(@"                      </th>
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
#line 42 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\MemberBook\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(1715, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1836, 23, false);
#line 46 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\MemberBook\Index.cshtml"
                                   Write(item.Member.Member_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1859, 635, true);
            WriteLiteral(@"
                                    </td>
                                    <td>

                                    </td>
                                    <td>

                                    </td>
                                    <td>

                                    </td>
                                    <td>

                                    </td>
                                    <td>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-primary btn-link btn-sm"" data-original-title=""Edit"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2494, "\"", 2527, 2);
            WriteAttributeValue("", 2501, "/Book/Edit/", 2501, 11, true);
#line 62 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\MemberBook\Index.cshtml"
WriteAttributeValue("", 2512, item.Member_Id, 2512, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2528, 408, true);
            WriteLiteral(@"><i class=""material-icons"">edit</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-danger btn-link btn-sm"" data-original-title=""Remove"" aria-describedby=""tooltip416464"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2936, "\"", 2971, 2);
            WriteAttributeValue("", 2943, "/Book/Delete/", 2943, 13, true);
#line 66 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\MemberBook\Index.cshtml"
WriteAttributeValue("", 2956, item.Member_Id, 2956, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2972, 496, true);
            WriteLiteral(@"><i class=""material-icons"">close</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                    </td>
                                    <td>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-success btn-link btn-sm"" data-original-title=""Details"" aria-describedby=""tooltip416464"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3468, "\"", 3504, 2);
            WriteAttributeValue("", 3475, "/Book/Details/", 3475, 14, true);
#line 72 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\MemberBook\Index.cshtml"
WriteAttributeValue("", 3489, item.Member_Id, 3489, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3505, 260, true);
            WriteLiteral(@"> <i class=""material-icons"">segment</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                    </td>
                                </tr>
");
            EndContext();
#line 77 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\MemberBook\Index.cshtml"

                                }

#line default
#line hidden
            BeginContext(3802, 307, true);
            WriteLiteral(@"

                            </tbody>
                        </table>
                        <a href=""/MemberBook/Add/"" class=""btn btn-primary""><i class=""material-icons"">library_add</i> New Book</a>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Data.Models.MemberBook>> Html { get; private set; }
    }
}
#pragma warning restore 1591
