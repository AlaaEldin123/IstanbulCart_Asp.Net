#pragma checksum "E:\my study p1\advance programing\assignment\Alaa Eldin APP\BusAPP\Views\Admin\BlueList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d6a6f7da8b2722b98e56035b8d1a10e92dc1d56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BlueList), @"mvc.1.0.view", @"/Views/Admin/BlueList.cshtml")]
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
#nullable restore
#line 1 "E:\my study p1\advance programing\assignment\Alaa Eldin APP\BusAPP\Views\_ViewImports.cshtml"
using BusAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\my study p1\advance programing\assignment\Alaa Eldin APP\BusAPP\Views\_ViewImports.cshtml"
using BusAPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d6a6f7da8b2722b98e56035b8d1a10e92dc1d56", @"/Views/Admin/BlueList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf2e74e40c2011436d482b6a5f23ab13bd6ee2ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BlueList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BusAPP.AddClasses.BlueCard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""app-content content"">
    <div class=""content-overlay""></div>

    <div class=""header-navbar-shadow""></div>

    <div class=""content-wrapper"">

        <div class=""col-12"">

            <div class=""card"">

                <div class=""card-header"">

                    <h4 class=""card-title"">Blue List Tables</h4>
                </div>

                <div class=""card-content"">

                    <!-- Table with no outer spacing -->
                    <div class=""table-responsive"">

                        <table class=""table mb-0"">

                            <thead>
                                <tr>

                                    <th>Customer Name</th>
                                    <th>Customer ID</th>
                                    <th>Card ID</th>
                                    <th>Points</th>

                                </tr>
                            </thead>

                            <tbody>

");
#nullable restore
#line 38 "E:\my study p1\advance programing\assignment\Alaa Eldin APP\BusAPP\Views\Admin\BlueList.cshtml"
                                 foreach (var ist in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n\n                            <td>");
#nullable restore
#line 42 "E:\my study p1\advance programing\assignment\Alaa Eldin APP\BusAPP\Views\Admin\BlueList.cshtml"
                           Write(ist.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 43 "E:\my study p1\advance programing\assignment\Alaa Eldin APP\BusAPP\Views\Admin\BlueList.cshtml"
                           Write(ist.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 44 "E:\my study p1\advance programing\assignment\Alaa Eldin APP\BusAPP\Views\Admin\BlueList.cshtml"
                           Write(ist.CardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 45 "E:\my study p1\advance programing\assignment\Alaa Eldin APP\BusAPP\Views\Admin\BlueList.cshtml"
                           Write(ist.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 47 "E:\my study p1\advance programing\assignment\Alaa Eldin APP\BusAPP\Views\Admin\BlueList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </tbody>\n                        </table>\n\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BusAPP.AddClasses.BlueCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
