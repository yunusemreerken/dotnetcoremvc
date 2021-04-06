#pragma checksum "C:\Users\MyAsus\source\repos\Library\Library\Views\Default\ContactMe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f138bef50eac66b5833a415a95c5c122f8443cf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_ContactMe), @"mvc.1.0.view", @"/Views/Default/ContactMe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Default/ContactMe.cshtml", typeof(AspNetCore.Views_Default_ContactMe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f138bef50eac66b5833a415a95c5c122f8443cf7", @"/Views/Default/ContactMe.cshtml")]
    public class Views_Default_ContactMe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Data.Models.Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/book-store/css/contactMe.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("ContactMe", async() => {
                BeginContext(20, 284, true);
                WriteLiteral(@"
    <link href=""//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js""></script>
    <script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
    ");
                EndContext();
                BeginContext(304, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dae3bfa37c7c4503b6e4dd942f28049d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(367, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
#line 8 "C:\Users\MyAsus\source\repos\Library\Library\Views\Default\ContactMe.cshtml"
  
    ViewData["Title"] = "ContactMe";
    Layout = "~/Views/Shared/_SiteLayout.cshtml";

#line default
#line hidden
            BeginContext(504, 62, true);
            WriteLiteral("\r\n\r\n<div class=\"col-md-12 \">\r\n    <div class=\"well well-sm\">\r\n");
            EndContext();
#line 16 "C:\Users\MyAsus\source\repos\Library\Library\Views\Default\ContactMe.cshtml"
         using (Html.BeginForm("MessageSubmit", "Default", FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(655, 326, true);
            WriteLiteral(@"            <fieldset>
                <legend class=""text-center"">Contact us</legend>

                <!-- Name input-->
                <div class=""form-group"">
                    <label class=""col-md-3 control-label color"" for=""name"">Name</label>
                    <div class=""col-md-9"">
                        ");
            EndContext();
            BeginContext(982, 103, false);
#line 25 "C:\Users\MyAsus\source\repos\Library\Library\Views\Default\ContactMe.cshtml"
                   Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control", @placeholder = "Your name", @id = "name" }));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 306, true);
            WriteLiteral(@"



                    </div>
                </div>

                <!-- Email input-->
                <div class=""form-group"">
                    <label class=""col-md-3 control-label color"" for=""email"">Your E-mail</label>
                    <div class=""col-md-9"">
                        ");
            EndContext();
            BeginContext(1392, 107, false);
#line 36 "C:\Users\MyAsus\source\repos\Library\Library\Views\Default\ContactMe.cshtml"
                   Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control", @placeholder = "Your E-mail", @id = "email" }));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 305, true);
            WriteLiteral(@"
                    </div>
                </div>

                <!-- Message body -->
                <div class=""form-group"">
                    <label class=""col-md-3 control-label color"" for=""message"">Your message</label>
                    <div class=""col-md-9"">
                        ");
            EndContext();
            BeginContext(1805, 150, false);
#line 44 "C:\Users\MyAsus\source\repos\Library\Library\Views\Default\ContactMe.cshtml"
                   Write(Html.TextAreaFor(x => x.YourMessage, new { @class = "form-control", @placeholder = "Please enter your message here...",@rows = "5", @id = "message" }));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 364, true);
            WriteLiteral(@"
                    </div>
                </div>

                <!-- Form actions -->
                <div class=""form-group"">
                    <div class=""col-md-12 text-right"">
                        <button type=""submit"" class=""btn btn-primary btn-sm"">Submit</button>
                    </div>
                </div>
            </fieldset>
");
            EndContext();
#line 55 "C:\Users\MyAsus\source\repos\Library\Library\Views\Default\ContactMe.cshtml"
        }

#line default
#line hidden
            BeginContext(2330, 24, true);
            WriteLiteral("        </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Data.Models.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
