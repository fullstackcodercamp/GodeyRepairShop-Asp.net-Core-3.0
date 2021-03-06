#pragma checksum "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "839f6eb466bee93ec3b86af99697e1223fb582fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_CompletedOrders), @"mvc.1.0.view", @"/Views/Orders/CompletedOrders.cshtml")]
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
#line 1 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\_ViewImports.cshtml"
using GodeyCarRepairShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\_ViewImports.cshtml"
using GodeyCarRepairShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\_ViewImports.cshtml"
using GodeyCarRepairShop.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839f6eb466bee93ec3b86af99697e1223fb582fa", @"/Views/Orders/CompletedOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a23ffb7c8abe7e837e27711f0ebb50539fc50c63", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_CompletedOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
  
    ViewData["Title"] = "CompletedOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""card border-primary mb-3"">
    <div class=""card-header"">Pending Orders</div>
    <div class=""card-body"">
        <div class=""card-text"">

            <table class=""table table-hover table-bordered table-striped table-responsive-md"">
                <thead>
                    <tr class=""table-danger"">
                        <th scope=""col"">First Name</th>
                        <th scope=""col"">Last Name</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">Phone</th>
                        <th scope=""col"">Make</th>
                        <th scope=""col"">Model</th>
                        <th scope=""col"">Year</th>
                        <th scope=""col"">Total Cost</th>
                        <th scope=""col"">Total Paid</th>
                        <th scope=""col"">Discount</th>
                        <th scope=""col"">Balance</th>
                        <th scope=""col"">Status</th>
    
                    </tr>
             ");
            WriteLiteral("   </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 33 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                     foreach (var customerService in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 36 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.Customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.Customer.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.Customer.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.Customer.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.TotalPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 47 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                                 if ((customerService.TotalPaid + customerService.Discount) >= customerService.TotalCost)
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("0");
#nullable restore
#line 49 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                                                  
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                                      Write((customerService.TotalPaid + customerService.Discount) - customerService.TotalCost);

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                                                                                                                                      
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 57 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                           Write(customerService.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            \r\n                        </tr>\r\n");
#nullable restore
#line 60 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\CompletedOrders.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
