#pragma checksum "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b25944ced2f1cc7695e66315455827788507f607"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Index), @"mvc.1.0.view", @"/Views/Message/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Message/Index.cshtml", typeof(AspNetCore.Views_Message_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b25944ced2f1cc7695e66315455827788507f607", @"/Views/Message/Index.cshtml")]
    public class Views_Message_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Data.Models.Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 306, true);
            WriteLiteral(@"




<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card card-plain"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title mt-0""> Messages Operations</h4>
            </div>
            <br />
            <div class=""form-search"">
");
            EndContext();
#line 19 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
            BeginContext(505, 58, true);
            WriteLiteral("                    <p>\r\n                        Search : ");
            EndContext();
            BeginContext(564, 17, false);
#line 22 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
                            Write(Html.TextBox("p"));

#line default
#line hidden
            EndContext();
            BeginContext(581, 90, true);
            WriteLiteral("\r\n                        <input type=\"submit\" value=\"Find\" />\r\n                    </p>\r\n");
            EndContext();
#line 25 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(692, 1116, true);
            WriteLiteral(@"            </div>
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
                                    Status
                                </th>
                                <th>
                                    Operations
                                </th>
                                <th>
                                    Details
                                </th>
                            </");
            WriteLiteral("tr>\r\n                        </thead>\r\n                        <tbody class=\"tbody-image\">\r\n");
            EndContext();
#line 55 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1897, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2018, 14, false);
#line 59 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
                                   Write(item.MessageId);

#line default
#line hidden
            EndContext();
            BeginContext(2032, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2160, 9, false);
#line 62 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2169, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2297, 10, false);
#line 65 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2307, 165, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    \r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2473, 11, false);
#line 69 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
                                   Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(2484, 319, true);
            WriteLiteral(@"
                                    </td>

                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-primary btn-link btn-sm"" data-original-title=""Edit"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2803, "\"", 2839, 2);
            WriteAttributeValue("", 2810, "/Message/Edit/", 2810, 14, true);
#line 74 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
WriteAttributeValue("", 2824, item.MessageId, 2824, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2840, 408, true);
            WriteLiteral(@"><i class=""material-icons"">edit</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-danger btn-link btn-sm"" data-original-title=""Remove"" aria-describedby=""tooltip416464"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3248, "\"", 3286, 2);
            WriteAttributeValue("", 3255, "/Message/Delete/", 3255, 16, true);
#line 78 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
WriteAttributeValue("", 3271, item.MessageId, 3271, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3287, 496, true);
            WriteLiteral(@"><i class=""material-icons"">close</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                    </td>
                                    <td>
                                        <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-success btn-link btn-sm"" data-original-title=""Details"" aria-describedby=""tooltip416464"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3783, "\"", 3822, 2);
            WriteAttributeValue("", 3790, "/Message/Details/", 3790, 17, true);
#line 84 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"
WriteAttributeValue("", 3807, item.MessageId, 3807, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3823, 260, true);
            WriteLiteral(@"> <i class=""material-icons"">segment</i></a>
                                            <div class=""ripple-container""></div>
                                        </button>
                                    </td>
                                </tr>
");
            EndContext();
#line 89 "C:\Users\MyAsus\source\repos\Library\Library\Views\Message\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(4116, 148, true);
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Data.Models.Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
