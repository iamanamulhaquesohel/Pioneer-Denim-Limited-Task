#pragma checksum "D:\Downloads\PDL_Task\PDL_Task_Core\Views\Departments\IndexV2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "655e560c0a63e3af9a894bd95c22107395958ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_IndexV2), @"mvc.1.0.view", @"/Views/Departments/IndexV2.cshtml")]
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
#line 2 "D:\Downloads\PDL_Task\PDL_Task_Core\Views\_ViewImports.cshtml"
using PDL_Task_Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Downloads\PDL_Task\PDL_Task_Core\Views\_ViewImports.cshtml"
using PDL_Task_Core.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"655e560c0a63e3af9a894bd95c22107395958ffa", @"/Views/Departments/IndexV2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bc14694b9a3e887c950a6326f0fa3fb31030dc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_IndexV2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RetailerVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Downloads\PDL_Task\PDL_Task_Core\Views\Departments\IndexV2.cshtml"
  
    ViewData["Title"] = "Retailers";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">

    <div class=""col-12"">
        <h3>Retailers</h3>
        <table class=""table table-bordered"">
            <thead class=""table-light"">
                <tr>
                    <th>Department Name</th>
                    <th>Department Code</th>
                    <th>Retailer Name</th>
                    <th>Retailer Code</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 20 "D:\Downloads\PDL_Task\PDL_Task_Core\Views\Departments\IndexV2.cshtml"
                 foreach (var ret in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 23 "D:\Downloads\PDL_Task\PDL_Task_Core\Views\Departments\IndexV2.cshtml"
                       Write(ret.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "D:\Downloads\PDL_Task\PDL_Task_Core\Views\Departments\IndexV2.cshtml"
                       Write(ret.DepartmentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "D:\Downloads\PDL_Task\PDL_Task_Core\Views\Departments\IndexV2.cshtml"
                       Write(ret.RetailerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "D:\Downloads\PDL_Task\PDL_Task_Core\Views\Departments\IndexV2.cshtml"
                       Write(ret.RetailerCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 28 "D:\Downloads\PDL_Task\PDL_Task_Core\Views\Departments\IndexV2.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RetailerVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
