#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62e8fc61224ad58d7d9a0eac841acca616a50c47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Add), @"mvc.1.0.view", @"/Views/Book/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Add.cshtml", typeof(AspNetCore.Views_Book_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e8fc61224ad58d7d9a0eac841acca616a50c47", @"/Views/Book/Add.cshtml")]
    public class Views_Book_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Data.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 250, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header card-header-primary\">\r\n                <h4 class=\"card-title\">Add Book</h4>\r\n            </div>\r\n            <div class=\"card-body\">\r\n");
            EndContext();
#line 15 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                 using (Html.BeginForm("Add", "Book", FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(461, 258, true);
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Book Name</label>
                                ");
            EndContext();
            BeginContext(720, 65, false);
#line 21 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.BookName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(785, 286, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Author</label>
                                ");
            EndContext();
            BeginContext(1072, 63, false);
#line 27 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.Author, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 363, true);
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
            BeginContext(1499, 70, false);
#line 36 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.PublisherName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 290, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Cover Type</label>
                                ");
            EndContext();
            BeginContext(1860, 66, false);
#line 42 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.CoverType, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 352, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Price</label>
                                ");
            EndContext();
            BeginContext(2279, 62, false);
#line 50 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2341, 291, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Cover Image</label>
                                ");
            EndContext();
            BeginContext(2633, 67, false);
#line 56 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.CoverImage, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2700, 351, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Cilt</label>
                                ");
            EndContext();
            BeginContext(3052, 61, false);
#line 64 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.Cilt, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3113, 289, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Category </label>
                                ");
            EndContext();
            BeginContext(3403, 106, false);
#line 70 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                           Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3509, 98, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
            BeginContext(3609, 146, true);
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-primary pull-right\">Add Book</button>\r\n                    <div class=\"clearfix\"></div>\r\n");
            EndContext();
#line 77 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Book\Add.cshtml"
                }

#line default
#line hidden
            BeginContext(3774, 54, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
