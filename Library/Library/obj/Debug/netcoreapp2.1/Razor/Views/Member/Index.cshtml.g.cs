#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4a6a5990ccdd2a3b608fa36b521d269ecf9ab95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Index), @"mvc.1.0.view", @"/Views/Member/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/Index.cshtml", typeof(AspNetCore.Views_Member_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a6a5990ccdd2a3b608fa36b521d269ecf9ab95", @"/Views/Member/Index.cshtml")]
    public class Views_Member_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Data.Models.Member>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
  
    ViewData["Title"] = "Members";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 1586, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card card-plain"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title mt-0""> Member Operations</h4>
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
                                    Email
                                </th>
                                <th>
                                    Telephone
                                </th>
                                
                                <th>
                   ");
            WriteLiteral(@"                 ??dentity Number
                                </th>
                                <th>
                                    ??mage
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
#line 46 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1813, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1934, 14, false);
#line 50 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
                                   Write(item.Member_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1948, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2076, 16, false);
#line 53 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
                                   Write(item.Member_Name);

#line default
#line hidden
            EndContext();
            BeginContext(2092, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2220, 10, false);
#line 56 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2230, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2358, 14, false);
#line 59 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
                                   Write(item.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(2372, 165, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    \r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2538, 19, false);
#line 63 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
                                   Write(item.IdentityNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2557, 131, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2688, "\"", 2705, 1);
#line 66 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
WriteAttributeValue("", 2694, item.Image, 2694, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2706, "\"", 2730, 2);
#line 66 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
WriteAttributeValue("", 2712, item.Member_Name, 2712, 17, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2729, "", 2730, 1, true);
            EndWriteAttribute();
            BeginContext(2731, 320, true);
            WriteLiteral(@" />
                                    </td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-primary btn-link btn-sm"" data-original-title=""Edit"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3051, "\"", 3086, 2);
            WriteAttributeValue("", 3058, "/Member/Edit/", 3058, 13, true);
#line 70 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
WriteAttributeValue("", 3071, item.Member_Id, 3071, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3087, 408, true);
            WriteLiteral(@"><i class=""material-icons"">edit</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-danger btn-link btn-sm"" data-original-title=""Remove"" aria-describedby=""tooltip416464"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3495, "\"", 3532, 2);
            WriteAttributeValue("", 3502, "/Member/Delete/", 3502, 15, true);
#line 74 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
WriteAttributeValue("", 3517, item.Member_Id, 3517, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3533, 496, true);
            WriteLiteral(@"><i class=""material-icons"">close</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                    </td>
                                    <td>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-success btn-link btn-sm"" data-original-title=""Details"" aria-describedby=""tooltip416464"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4029, "\"", 4067, 2);
            WriteAttributeValue("", 4036, "/Member/Details/", 4036, 16, true);
#line 80 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"
WriteAttributeValue("", 4052, item.Member_Id, 4052, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4068, 260, true);
            WriteLiteral(@"> <i class=""material-icons"">segment</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                    </td>
                                </tr>
");
            EndContext();
#line 85 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(4361, 266, true);
            WriteLiteral(@"

                        </tbody>
                    </table>
                    <a href=""/Member/Add"" class=""btn btn-primary""><i class=""material-icons"">library_add</i> New </a>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Data.Models.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
