#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0478ba6193337085074c3aed9cd88f2d54c0ab08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_AddFood), @"mvc.1.0.view", @"/Views/Food/AddFood.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Food/AddFood.cshtml", typeof(AspNetCore.Views_Food_AddFood))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0478ba6193337085074c3aed9cd88f2d54c0ab08", @"/Views/Food/AddFood.cshtml")]
    public class Views_Food_AddFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
  
    ViewData["Title"] = "AddFood";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 36, true);
            WriteLiteral("\r\n\r\n<h2>Food Add Page</h2>\r\n<br />\r\n");
            EndContext();
#line 10 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
 using (Html.BeginForm("AddFood", "Food", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(232, 30, false);
#line 12 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.FoodName));

#line default
#line hidden
            EndContext();
            BeginContext(269, 65, false);
#line 13 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.FoodName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(336, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(353, 27, false);
#line 15 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(387, 62, false);
#line 16 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(451, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(468, 33, false);
#line 18 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(508, 69, false);
#line 19 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(579, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(596, 27, false);
#line 21 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.Price));

#line default
#line hidden
            EndContext();
            BeginContext(630, 62, false);
#line 22 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(694, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(711, 30, false);
#line 24 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.ImageURL));

#line default
#line hidden
            EndContext();
            BeginContext(748, 65, false);
#line 25 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.ImageURL, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(815, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(832, 22, false);
#line 27 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
            EndContext();
            BeginContext(861, 105, false);
#line 28 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.v1, new { @class = "form-contol" }));

#line default
#line hidden
            EndContext();
            BeginContext(968, 64, true);
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\"> Save</button>\r\n");
            EndContext();
#line 31 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
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
