#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListById\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d885b7000faa68ee77c7d545bbcdbc95f80ca10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_FoodListById_Default), @"mvc.1.0.view", @"/Views/Default/Components/FoodListById/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Default/Components/FoodListById/Default.cshtml", typeof(AspNetCore.Views_Default_Components_FoodListById_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d885b7000faa68ee77c7d545bbcdbc95f80ca10", @"/Views/Default/Components/FoodListById/Default.cshtml")]
    public class Views_Default_Components_FoodListById_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 133, true);
            WriteLiteral("<div class=\"top-brands\">\r\n    <div class=\"container\">\r\n        <h3>Ürünlerimiz</h3>\r\n        <div class=\"agile_top_brands_grids\">\r\n\r\n");
            EndContext();
#line 7 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListById\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(240, 511, true);
            WriteLiteral(@"                <div class=""col-md-3 top_brand_left"">
                    <div class=""hover14 column"">
                        <div class=""agile_top_brand_left_grid"">
                            <div class=""agile_top_brand_left_grid1"">
                                <figure>
                                    <div class=""snipcart-item block"">
                                        <div class=""snipcart-thumb"">
                                            <a href=""single.html""><img title="" "" alt="" """);
            EndContext();
            BeginWriteAttribute("src", " src=\"", 751, "\"", 771, 1);
#line 16 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListById\Default.cshtml"
WriteAttributeValue("", 757, item.ImageURL, 757, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(772, 56, true);
            WriteLiteral(" /></a>\r\n                                            <p>");
            EndContext();
            BeginContext(829, 13, false);
#line 17 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListById\Default.cshtml"
                                          Write(item.FoodName);

#line default
#line hidden
            EndContext();
            BeginContext(842, 55, true);
            WriteLiteral("</p>\r\n                                            <h4>₺");
            EndContext();
            BeginContext(898, 10, false);
#line 18 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListById\Default.cshtml"
                                            Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(908, 29, true);
            WriteLiteral("<span>₺ 10.00</span></h4><h6>");
            EndContext();
            BeginContext(938, 10, false);
#line 18 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListById\Default.cshtml"
                                                                                    Write(item.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(948, 1761, true);
            WriteLiteral(@"</h6>
                                        </div>
                                        <div class=""snipcart-details top_brand_home_details"">
                                            <form action=""checkout.html"" method=""post"">
                                                <fieldset>
                                                    <input type=""hidden"" name=""cmd"" value=""_cart"" />
                                                    <input type=""hidden"" name=""add"" value=""1"" />
                                                    <input type=""hidden"" name=""business"" value="" "" />
                                                    <input type=""hidden"" name=""item_name"" value=""Fortune Sunflower Oil"" />
                                                    <input type=""hidden"" name=""amount"" value=""7.99"" />
                                                    <input type=""hidden"" name=""discount_amount"" value=""1.00"" />
                                                    <input type=""hidden"" name=""cu");
            WriteLiteral(@"rrency_code"" value=""USD"" />
                                                    <input type=""hidden"" name=""return"" value="" "" />
                                                    <input type=""hidden"" name=""cancel_return"" value="" "" />
                                                    <input type=""submit"" name=""submit"" value=""Sepete Ekle"" class=""button"" />
                                                </fieldset>

                                            </form>

                                        </div>
                                    </div>
                                </figure>
                            </div>
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 44 "C:\Users\MyAsus\source\repos\dotnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListById\Default.cshtml"


            }

#line default
#line hidden
            BeginContext(2728, 77, true);
            WriteLiteral("            <div class=\"clearfix\"> </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
