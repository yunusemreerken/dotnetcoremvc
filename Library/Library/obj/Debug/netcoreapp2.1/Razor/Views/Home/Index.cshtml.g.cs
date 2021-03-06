#pragma checksum "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac3bb1b2e14a3806de47005565263e57bfcca973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac3bb1b2e14a3806de47005565263e57bfcca973", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\MyAsus\source\repos\dotnetcoremvc\Library\Library\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Admin Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 22827, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-3 col-md-6 col-sm-6"">
        <div class=""card card-stats"">
            <div class=""card-header card-header-warning card-header-icon"">
                <div class=""card-icon"">
                    <i class=""material-icons"">content_copy</i>
                </div>
                <p class=""card-category"">Used Space</p>
                <h3 class=""card-title"">
                    49/50
                    <small>GB</small>
                </h3>
            </div>
            <div class=""card-footer"">
                <div class=""stats"">
                    <i class=""material-icons text-danger"">warning</i>
                    <a href=""javascript:;"">Get More Space...</a>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 col-md-6 col-sm-6"">
        <div class=""card card-stats"">
            <div class=""card-header card-header-success card-header-icon"">
                <div class=""card-icon"">
                   ");
            WriteLiteral(@" <i class=""material-icons"">store</i>
                </div>
                <p class=""card-category"">Revenue</p>
                <h3 class=""card-title"">$34,245</h3>
            </div>
            <div class=""card-footer"">
                <div class=""stats"">
                    <i class=""material-icons"">date_range</i> Last 24 Hours
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 col-md-6 col-sm-6"">
        <div class=""card card-stats"">
            <div class=""card-header card-header-danger card-header-icon"">
                <div class=""card-icon"">
                    <i class=""material-icons"">info_outline</i>
                </div>
                <p class=""card-category"">Fixed Issues</p>
                <h3 class=""card-title"">75</h3>
            </div>
            <div class=""card-footer"">
                <div class=""stats"">
                    <i class=""material-icons"">local_offer</i> Tracked from Github
                </div>
            ");
            WriteLiteral(@"</div>
        </div>
    </div>
    <div class=""col-lg-3 col-md-6 col-sm-6"">
        <div class=""card card-stats"">
            <div class=""card-header card-header-info card-header-icon"">
                <div class=""card-icon"">
                    <i class=""fa fa-twitter""></i>
                </div>
                <p class=""card-category"">Followers</p>
                <h3 class=""card-title"">+245</h3>
            </div>
            <div class=""card-footer"">
                <div class=""stats"">
                    <i class=""material-icons"">update</i> Just Updated
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-4"">
        <div class=""card card-chart"">
            <div class=""card-header card-header-success"">
                <div class=""ct-chart"" id=""dailySalesChart""></div>
            </div>
            <div class=""card-body"">
                <h4 class=""card-title"">Daily Sales</h4>
                <p class=""card-cate");
            WriteLiteral(@"gory"">
                    <span class=""text-success""><i class=""fa fa-long-arrow-up""></i> 55% </span> increase in today sales.
                </p>
            </div>
            <div class=""card-footer"">
                <div class=""stats"">
                    <i class=""material-icons"">access_time</i> updated 4 minutes ago
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""card card-chart"">
            <div class=""card-header card-header-warning"">
                <div class=""ct-chart"" id=""websiteViewsChart""></div>
            </div>
            <div class=""card-body"">
                <h4 class=""card-title"">Email Subscriptions</h4>
                <p class=""card-category"">Last Campaign Performance</p>
            </div>
            <div class=""card-footer"">
                <div class=""stats"">
                    <i class=""material-icons"">access_time</i> campaign sent 2 days ago
                </div>
            </div>
   ");
            WriteLiteral(@"     </div>
    </div>
    <div class=""col-md-4"">
        <div class=""card card-chart"">
            <div class=""card-header card-header-danger"">
                <div class=""ct-chart"" id=""completedTasksChart""></div>
            </div>
            <div class=""card-body"">
                <h4 class=""card-title"">Completed Tasks</h4>
                <p class=""card-category"">Last Campaign Performance</p>
            </div>
            <div class=""card-footer"">
                <div class=""stats"">
                    <i class=""material-icons"">access_time</i> campaign sent 2 days ago
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-header card-header-tabs card-header-primary"">
                <div class=""nav-tabs-navigation"">
                    <div class=""nav-tabs-wrapper"">
                        <span class=""nav-tabs-title"">Tasks:</span>
                 ");
            WriteLiteral(@"       <ul class=""nav nav-tabs"" data-tabs=""tabs"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" href=""#profile"" data-toggle=""tab"">
                                    <i class=""material-icons"">bug_report</i> Bugs
                                    <div class=""ripple-container""></div>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#messages"" data-toggle=""tab"">
                                    <i class=""material-icons"">code</i> Website
                                    <div class=""ripple-container""></div>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#settings"" data-toggle=""tab"">
                                    <i class=""material-icons"">cloud</i> Server
          ");
            WriteLiteral(@"                          <div class=""ripple-container""></div>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""tab-content"">
                    <div class=""tab-pane active"" id=""profile"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" value="""" checked>
                                                <span class=""form-check-sign"">
                                                    <span class=""check""></span>
                                                </span>");
            WriteLiteral(@"
                                            </label>
                                        </div>
                                    </td>
                                    <td>Sign contract for ""What are conference organizers afraid of?""</td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                            <i class=""material-icons"">edit</i>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                            <i class=""material-icons"">close</i>
                                        </button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
     ");
            WriteLiteral(@"                                   <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" value="""">
                                                <span class=""form-check-sign"">
                                                    <span class=""check""></span>
                                                </span>
                                            </label>
                                        </div>
                                    </td>
                                    <td>Lines From Great Russian Literature? Or E-mails From My Boss?</td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                            <i class=""material-icons"">edit</i>
                   ");
            WriteLiteral(@"                     </button>
                                        <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                            <i class=""material-icons"">close</i>
                                        </button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" value="""">
                                                <span class=""form-check-sign"">
                                                    <span class=""check""></span>
                                                </span>
                                            </label>
                                        </d");
            WriteLiteral(@"iv>
                                    </td>
                                    <td>
                                        Flooded: One year later, assessing what was lost and what was found when a ravaging rain swept through metro Detroit
                                    </td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                            <i class=""material-icons"">edit</i>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                            <i class=""material-icons"">close</i>
                                        </button>
                                    </td>
                                </tr>
                                <tr>
          ");
            WriteLiteral(@"                          <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" value="""" checked>
                                                <span class=""form-check-sign"">
                                                    <span class=""check""></span>
                                                </span>
                                            </label>
                                        </div>
                                    </td>
                                    <td>Create 4 Invisible User Experiences you Never Knew About</td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                            <i class=""mater");
            WriteLiteral(@"ial-icons"">edit</i>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                            <i class=""material-icons"">close</i>
                                        </button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""tab-pane"" id=""messages"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" value="""" checked>
                         ");
            WriteLiteral(@"                       <span class=""form-check-sign"">
                                                    <span class=""check""></span>
                                                </span>
                                            </label>
                                        </div>
                                    </td>
                                    <td>
                                        Flooded: One year later, assessing what was lost and what was found when a ravaging rain swept through metro Detroit
                                    </td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                            <i class=""material-icons"">edit</i>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn bt");
            WriteLiteral(@"n-danger btn-link btn-sm"">
                                            <i class=""material-icons"">close</i>
                                        </button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" value="""">
                                                <span class=""form-check-sign"">
                                                    <span class=""check""></span>
                                                </span>
                                            </label>
                                        </div>
                                    </td>
                                    <td>Sign contract for ""What are conference organizer");
            WriteLiteral(@"s afraid of?""</td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                            <i class=""material-icons"">edit</i>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                            <i class=""material-icons"">close</i>
                                        </button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""tab-pane"" id=""settings"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td");
            WriteLiteral(@">
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" value="""">
                                                <span class=""form-check-sign"">
                                                    <span class=""check""></span>
                                                </span>
                                            </label>
                                        </div>
                                    </td>
                                    <td>Lines From Great Russian Literature? Or E-mails From My Boss?</td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                            <i class=""material-icons"">edit</i>
           ");
            WriteLiteral(@"                             </button>
                                        <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                            <i class=""material-icons"">close</i>
                                        </button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" value="""" checked>
                                                <span class=""form-check-sign"">
                                                    <span class=""check""></span>
                                                </span>
                                            </label>
                           ");
            WriteLiteral(@"             </div>
                                    </td>
                                    <td>
                                        Flooded: One year later, assessing what was lost and what was found when a ravaging rain swept through metro Detroit
                                    </td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                            <i class=""material-icons"">edit</i>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                            <i class=""material-icons"">close</i>
                                        </button>
                                    </td>
                                </tr>
                                ");
            WriteLiteral(@"<tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" value="""" checked>
                                                <span class=""form-check-sign"">
                                                    <span class=""check""></span>
                                                </span>
                                            </label>
                                        </div>
                                    </td>
                                    <td>Sign contract for ""What are conference organizers afraid of?""</td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                      ");
            WriteLiteral(@"      <i class=""material-icons"">edit</i>
                                        </button>
                                        <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                            <i class=""material-icons"">close</i>
                                        </button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-header card-header-warning"">
                <h4 class=""card-title"">Employees Stats</h4>
                <p class=""card-category"">New employees on 15th September, 2016</p>
            </div>
            <div class=""card-body table-responsive"">
                <table class=""table table-hover"">
                  ");
            WriteLiteral(@"  <thead class=""text-warning"">
                    <th>ID</th>
                    <th>Name</th>
                    <th>Salary</th>
                    <th>Country</th>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>Dakota Rice</td>
                            <td>$36,738</td>
                            <td>Niger</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>Minerva Hooper</td>
                            <td>$23,789</td>
                            <td>Cura??ao</td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>Sage Rodriguez</td>
                            <td>$56,142</td>
                            <td>Netherlands</td>
                        </tr>
                        <tr>
                       ");
            WriteLiteral(@"     <td>4</td>
                            <td>Philip Chaney</td>
                            <td>$38,735</td>
                            <td>Korea, South</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>");
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
