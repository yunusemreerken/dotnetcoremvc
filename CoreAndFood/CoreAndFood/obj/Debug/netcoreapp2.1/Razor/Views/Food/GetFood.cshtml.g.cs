#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db411db6229e7b16354fe407a49552af4f356ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_GetFood), @"mvc.1.0.view", @"/Views/Food/GetFood.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Food/GetFood.cshtml", typeof(AspNetCore.Views_Food_GetFood))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db411db6229e7b16354fe407a49552af4f356ae", @"/Views/Food/GetFood.cshtml")]
    public class Views_Food_GetFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
  
    ViewData["Title"] = "GetFood";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 40, true);
            WriteLiteral("\r\n<h2>Get Food page</h2>\r\n\r\n\r\n\r\n<br />\r\n");
            EndContext();
#line 13 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
 using (Html.BeginForm("UpdateFood", "Food", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(241, 28, false);
#line 15 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.LabelFor(x => x.FoodId));

#line default
#line hidden
            EndContext();
            BeginContext(276, 63, false);
#line 16 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextBoxFor(x => x.FoodId, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(341, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(358, 30, false);
#line 18 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.LabelFor(x => x.FoodName));

#line default
#line hidden
            EndContext();
            BeginContext(395, 65, false);
#line 19 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextBoxFor(x => x.FoodName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(462, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(479, 27, false);
#line 21 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.LabelFor(x => x.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(513, 62, false);
#line 22 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(577, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(594, 33, false);
#line 24 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(634, 69, false);
#line 25 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(705, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(722, 27, false);
#line 27 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.LabelFor(x => x.Price));

#line default
#line hidden
            EndContext();
            BeginContext(756, 62, false);
#line 28 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(820, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(837, 30, false);
#line 30 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.LabelFor(x => x.ImageURL));

#line default
#line hidden
            EndContext();
            BeginContext(874, 65, false);
#line 31 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextBoxFor(x => x.ImageURL, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(941, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(958, 22, false);
#line 33 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 105, false);
#line 35 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.v1, new { @class = "form-contol" }));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 64, true);
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\"> Save</button>\r\n");
            EndContext();
#line 38 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
