#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Login\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ba651c031033067855c818606012f09cc2e9276"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Register), @"mvc.1.0.view", @"/Views/Login/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Register.cshtml", typeof(AspNetCore.Views_Login_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ba651c031033067855c818606012f09cc2e9276", @"/Views/Login/Register.cshtml")]
    public class Views_Login_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("txt2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Login/SignIn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Login\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_AuthLayout.cshtml";

#line default
#line hidden
            BeginContext(97, 2298, true);
            WriteLiteral(@"

<form class=""login100-form validate-form"">
    <span class=""login100-form-title"">
        Member Register
    </span>
    <div class=""wrap-input100 validate-input"" data-validate=""Valid email is required: ex@abc.xyz"">
        <input class=""input100"" type=""text"" name=""email"" placeholder=""Email"">
        <span class=""focus-input100""></span>
        <span class=""symbol-input100"">
            <i class=""fa fa-envelope"" aria-hidden=""true""></i>
        </span>
    </div>
    <div class=""wrap-input100 validate-input"" data-validate=""Valid email is required: ex@abc.xyz"">
        <input class=""input100"" type=""text"" name=""email"" placeholder=""Email"">
        <span class=""focus-input100""></span>
        <span class=""symbol-input100"">
            <i class=""fa fa-envelope"" aria-hidden=""true""></i>
        </span>
    </div>
    <div class=""wrap-input100 validate-input"" data-validate=""Valid email is required: ex@abc.xyz"">
        <input class=""input100"" type=""text"" name=""email"" placeholder=""Email"">
     ");
            WriteLiteral(@"   <span class=""focus-input100""></span>
        <span class=""symbol-input100"">
            <i class=""fa fa-envelope"" aria-hidden=""true""></i>
        </span>
    </div>

    <div class=""wrap-input100 validate-input"" data-validate=""Valid email is required: ex@abc.xyz"">
        <input class=""input100"" type=""text"" name=""email"" placeholder=""Email"">
        <span class=""focus-input100""></span>
        <span class=""symbol-input100"">
            <i class=""fa fa-envelope"" aria-hidden=""true""></i>
        </span>
    </div>

    <div class=""wrap-input100 validate-input"" data-validate=""Password is required"">
        <input class=""input100"" type=""password"" name=""pass"" placeholder=""Password"">
        <span class=""focus-input100""></span>
        <span class=""symbol-input100"">
            <i class=""fa fa-lock"" aria-hidden=""true""></i>
        </span>
    </div>

    <div class=""container-login100-form-btn"">
        <button class=""login100-form-btn"">
            Register
        </button>
    </div>
");
            WriteLiteral("\r\n    <div class=\"text-center p-t-12\">\r\n        <span class=\"txt1\">\r\n            Forgot\r\n        </span>\r\n        <a class=\"txt2\" href=\"#\">\r\n            Username / Password?\r\n        </a>\r\n    </div>\r\n\r\n    <div class=\"text-center p-t-136\">\r\n        ");
            EndContext();
            BeginContext(2395, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4b97c0bbe64770883f0b5c387be74c", async() => {
                BeginContext(2433, 120, true);
                WriteLiteral("\r\n            <i class=\"fa fa-long-arrow-left m-l-5\" aria-hidden=\"true\"></i>\r\n            Back To Member Login\r\n        ");
                EndContext();
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
            BeginContext(2557, 21, true);
            WriteLiteral("\r\n    </div>\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
