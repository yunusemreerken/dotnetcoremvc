#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eea79ac60c3380e0acd2355a31023f67b132201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Detail), @"mvc.1.0.view", @"/Views/Default/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Default/Detail.cshtml", typeof(AspNetCore.Views_Default_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eea79ac60c3380e0acd2355a31023f67b132201", @"/Views/Default/Detail.cshtml")]
    public class Views_Default_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Data.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_SiteLayout.cshtml";

#line default
#line hidden
            BeginContext(126, 49, true);
            WriteLiteral("\r\n<div id=\"templatemo_content_right\">\r\n\r\n    <h1>");
            EndContext();
            BeginContext(176, 14, false);
#line 9 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml"
   Write(Model.BookName);

#line default
#line hidden
            EndContext();
            BeginContext(190, 8, true);
            WriteLiteral(" <span>(");
            EndContext();
            BeginContext(199, 12, false);
#line 9 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml"
                          Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(211, 48, true);
            WriteLiteral(")</span></h1>\r\n    <div class=\"image_panel\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 259, "\"", 282, 1);
#line 10 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml"
WriteAttributeValue("", 265, Model.CoverImage, 265, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(283, 77, true);
            WriteLiteral(" alt=\"CSS Template\" width=\"100\" height=\"150\" /></div>\r\n    <h2>cilt Say??s?? : ");
            EndContext();
            BeginContext(361, 10, false);
#line 11 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml"
                 Write(Model.Cilt);

#line default
#line hidden
            EndContext();
            BeginContext(371, 51, true);
            WriteLiteral("</h2>\r\n    <ul>\r\n        <li>Yay??n Evi <a href=\"#\">");
            EndContext();
            BeginContext(423, 19, false);
#line 13 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml"
                             Write(Model.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(442, 23, true);
            WriteLiteral("</a></li>\r\n        <li>");
            EndContext();
            BeginContext(466, 15, false);
#line 14 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml"
       Write(Model.CoverType);

#line default
#line hidden
            EndContext();
            BeginContext(481, 27, true);
            WriteLiteral("</li>\r\n        <li>Fiyat : ");
            EndContext();
            BeginContext(509, 11, false);
#line 15 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml"
               Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(520, 29, true);
            WriteLiteral("</li>\r\n        <li>ISBN No : ");
            EndContext();
            BeginContext(550, 12, false);
#line 16 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Default\Detail.cshtml"
                 Write(Model.BookId);

#line default
#line hidden
            EndContext();
            BeginContext(562, 1049, true);
            WriteLiteral(@" </li>
    </ul>

    kitap i??eri??i ekle

    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus nec dui. Donec nec neque ut quam sodales feugiat. Nam sodales, pede vel dapibus lobortis, ipsum diam molestie risus, a vulputate risus nisl pulvinar lacus.</p>

    <p>Donec at arcu. Nunc aliquam, dolor vitae sollicitudin lacinia, nibh orci sagittis diam, dignissim sodales dui erat nec eros. Fusce quis enim. Aenean eleifend, neque hendrerit elementum sodales, odio erat sagittis quam, sed tempor orci magna vitae tellus. Proin dui mauris, tempor eget, pulvinar sed, pretium sit amet, dui. Proin vulputate justo et quam.</p>

    <p>In fermentum, eros ac tincidunt aliquam, elit velit semper nunc, a tincidunt orci lectus a arcu. Nullam commodo, arcu non facilisis imperdiet, felis lectus tempus felis, vitae volutpat augue ante quis leo. Aliquam tristique dolor ac odio. Sed consectetur, lacus et dictum tristique, odio neque elementum ante, nec eleifend leo dolor vel tortor.</p>



</div> <!--");
            WriteLiteral(" end of content right -->");
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
