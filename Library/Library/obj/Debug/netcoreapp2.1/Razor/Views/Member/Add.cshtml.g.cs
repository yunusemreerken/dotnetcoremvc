#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a803810cca56f31c33e08dadefb3a1ac89d07fbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Add), @"mvc.1.0.view", @"/Views/Member/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/Add.cshtml", typeof(AspNetCore.Views_Member_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a803810cca56f31c33e08dadefb3a1ac89d07fbc", @"/Views/Member/Add.cshtml")]
    public class Views_Member_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Data.Models.Member>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 252, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header card-header-primary\">\r\n                <h4 class=\"card-title\">Add Member</h4>\r\n            </div>\r\n            <div class=\"card-body\">\r\n");
            EndContext();
#line 15 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml"
                 using (Html.BeginForm("Add", "Member", FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(467, 260, true);
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Member Name</label>
                                ");
            EndContext();
            BeginContext(728, 68, false);
#line 21 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.Member_Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(796, 285, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Email</label>
                                ");
            EndContext();
            BeginContext(1082, 62, false);
#line 27 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 364, true);
            WriteLiteral(@"
                            </div>
                        </div>

                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Identity Number</label>
                                ");
            EndContext();
            BeginContext(1509, 71, false);
#line 36 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.IdentityNumber, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 289, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Telephone</label>
                                ");
            EndContext();
            BeginContext(1870, 66, false);
#line 42 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.Telephone, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1936, 355, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Password</label>
                                ");
            EndContext();
            BeginContext(2292, 65, false);
#line 50 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2357, 285, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Image</label>
                                ");
            EndContext();
            BeginContext(2643, 62, false);
#line 56 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml"
                           Write(Html.TextBoxFor(x => x.Image, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 98, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
            BeginContext(2827, 148, true);
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-primary pull-right\">Add Member</button>\r\n                    <div class=\"clearfix\"></div>\r\n");
            EndContext();
#line 64 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Member\Add.cshtml"
                }

#line default
#line hidden
            BeginContext(2994, 54, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Data.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
