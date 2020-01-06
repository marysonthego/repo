#pragma checksum "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6d842f68533f0dca9d72f139666a6cc74258bcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restrict_MyOrders), @"mvc.1.0.view", @"/Views/Restrict/MyOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restrict/MyOrders.cshtml", typeof(AspNetCore.Views_Restrict_MyOrders))]
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
#line 1 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\_ViewImports.cshtml"
using Demo6;

#line default
#line hidden
#line 2 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\_ViewImports.cshtml"
using Demo6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d842f68533f0dca9d72f139666a6cc74258bcf", @"/Views/Restrict/MyOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aab0efa45ba2d4cb68b1230e20f6ec013272657", @"/Views/_ViewImports.cshtml")]
    public class Views_Restrict_MyOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TblOrderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
  
    ViewData["Title"] = "My Orders";

#line default
#line hidden
            BeginContext(125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(183, 19, true);
            WriteLiteral("    <h1>Orders for ");
            EndContext();
            BeginContext(203, 26, false);
#line 13 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
              Write(Context.User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(229, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(238, 491, true);
            WriteLiteral(@"    <table class=""table table-sm table-striped table-bordered"">
        <thead>
            <tr>
                <th>
                    Order Date
                </th>
                <th>
                    Product
                </th>
                <th class=""text-right"">
                    Price
                </th>
                <th class=""text-right"">
                    Quanitity
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 33 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(786, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(860, 40, false);
#line 37 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
                    Write($"{item.OrderFkNavigation?.OrderDate:d}");

#line default
#line hidden
            EndContext();
            BeginContext(901, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(981, 34, false);
#line 40 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
                   Write(item.ProductFkNavigation.ModelName);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 98, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(1114, 47, false);
#line 43 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
                   Write(item.ProductFkNavigation.UnitCost.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 98, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(1260, 13, false);
#line 46 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1273, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 49 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
            }

#line default
#line hidden
            BeginContext(1340, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 52 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1384, 22, true);
            WriteLiteral("    <h1>No orders for ");
            EndContext();
            BeginContext(1407, 26, false);
#line 55 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
                 Write(Context.User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1433, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 56 "\\tsclient\C\Users\marys\Docs\Repos\CIS665\Demo6\Demo6\Views\Restrict\MyOrders.cshtml"
}

#line default
#line hidden
            BeginContext(1443, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TblOrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
