#pragma checksum "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "623c52571ca1eb64d1b80f9ba26acd1849782dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Details.cshtml", typeof(AspNetCore.Views_Book_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"623c52571ca1eb64d1b80f9ba26acd1849782dc2", @"/Views/Book/Details.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Data.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
   
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 446, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-8"">
        <div class=""card"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title"">Details Book</h4>
            </div>
            <div class=""card-body"">
                    
                    <div class=""row"">

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                ");
            EndContext();
            BeginContext(571, 69, false);
#line 18 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                           Write(Html.LabelFor(x => x.BookName, new { @class = "bmd-label-floating" }));

#line default
#line hidden
            EndContext();
            BeginContext(640, 36, true);
            WriteLiteral("\r\n\r\n                                ");
            EndContext();
            BeginContext(677, 65, false);
#line 20 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                           Write(Html.TextBoxFor(x => x.BookName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(742, 286, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Author</label>
                                ");
            EndContext();
            BeginContext(1029, 63, false);
#line 26 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                           Write(Html.TextBoxFor(x => x.Author, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 363, true);
            WriteLiteral(@"
                            </div>
                        </div>

                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Publisher Name</label>
                                ");
            EndContext();
            BeginContext(1456, 70, false);
#line 35 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                           Write(Html.TextBoxFor(x => x.PublisherName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 290, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Cover Type</label>
                                ");
            EndContext();
            BeginContext(1817, 66, false);
#line 41 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                           Write(Html.TextBoxFor(x => x.CoverType, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 356, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Price (₺)</label>
                                ");
            EndContext();
            BeginContext(2240, 62, false);
#line 49 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                           Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2302, 284, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Cilt</label>
                                ");
            EndContext();
            BeginContext(2587, 61, false);
#line 55 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                           Write(Html.TextBoxFor(x => x.Cilt, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2648, 299, true);
            WriteLiteral(@"
                            </div>
                        </div>

                    </div>
                    <div class=""row"">
                        
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                ");
            EndContext();
            BeginContext(2948, 69, false);
#line 64 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                           Write(Html.LabelFor(x => x.Category, new { @class = "bmd-label-floating" }));

#line default
#line hidden
            EndContext();
            BeginContext(3017, 36, true);
            WriteLiteral("\r\n\r\n                                ");
            EndContext();
            BeginContext(3054, 106, false);
#line 66 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                           Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3160, 383, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""clearfix""></div>
            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""card card-profile"">
            <div class=""card-avatar"">
                <a href=""javascript:;"">
                    <img class=""img""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3543, "\"", 3566, 1);
#line 79 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
WriteAttributeValue("", 3549, Model.CoverImage, 3549, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3567, 156, true);
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h6 class=\"card-category text-gray\">\r\n                    ");
            EndContext();
            BeginContext(3724, 14, false);
#line 84 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
               Write(Model.BookName);

#line default
#line hidden
            EndContext();
            BeginContext(3738, 23, true);
            WriteLiteral(" &&                    ");
            EndContext();
            BeginContext(3762, 19, false);
#line 84 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                                                     Write(Model.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(3781, 64, true);
            WriteLiteral("\r\n                </h6>\r\n                <h4 class=\"card-title\">");
            EndContext();
            BeginContext(3846, 12, false);
#line 86 "C:\Users\MyAsus\source\repos\Library\Library\Views\Book\Details.cshtml"
                                  Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(3858, 211, true);
            WriteLiteral("</h4>\r\n                <p class=\"card-description\">\r\n                </p>\r\n                <a href=\"javascript:;\" class=\"btn btn-primary btn-round\">Buy</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Data.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591