#pragma checksum "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d117e8744155fa3e2873cf63a58afc494fd77c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_PendingOrders), @"mvc.1.0.view", @"/Views/Orders/PendingOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d117e8744155fa3e2873cf63a58afc494fd77c1", @"/Views/Orders/PendingOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a23ffb7c8abe7e837e27711f0ebb50539fc50c63", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_PendingOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
  
    ViewData["Title"] = "PendingOrders";

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
                        <td></td>
             ");
            WriteLiteral("       </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 32 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                     foreach (var customerService in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 35 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.Customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.Customer.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.Customer.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.Customer.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.TotalPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 46 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                                 if ((customerService.TotalPaid + customerService.Discount) >= customerService.TotalCost)
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("0");
#nullable restore
#line 48 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                                                  
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                                      Write((customerService.TotalPaid + customerService.Discount) - customerService.TotalCost);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                                                                                                                                      
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 56 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                           Write(customerService.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d117e8744155fa3e2873cf63a58afc494fd77c110634", async() => {
                WriteLiteral("Complete Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
                                                                                              WriteLiteral(customerService.ServiceId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 61 "C:\BootCamp2020\GodeyCarRepairShop\GodeyCarRepairShop\Views\Orders\PendingOrders.cshtml"
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
