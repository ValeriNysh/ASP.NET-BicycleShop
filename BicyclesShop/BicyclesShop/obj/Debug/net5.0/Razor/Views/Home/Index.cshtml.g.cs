#pragma checksum "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0df97878b4d8b8ce17789088ddac405506738c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\_ViewImports.cshtml"
using BicyclesShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\_ViewImports.cshtml"
using BicyclesShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df97878b4d8b8ce17789088ddac405506738c4f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bfda19f4ce8afc0c861eafd53550bd773d7d5a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<BicyclesShop.Models.Bicycle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n");
#nullable restore
#line 5 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
 if (ViewBag.Thanks != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"display-4 text-center font-weight-bold mb-3\" style=\"color:darkgreen; background-color:lawngreen\">");
#nullable restore
#line 11 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
                                                                                                            Write(ViewBag.Thanks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Велосипеды</h1>
<table class=""table"">
    <thead>
        <tr>
            <th>Название</th>
            <th>Цвет</th>
            <th>Тип</th>
            <th>Диаметр колеса</th>
            <th>Размер рамы</th>
            <th>Материал рамы</th>
            <th>Цена</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
         foreach (var bicycle in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
               Write(bicycle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
               Write(bicycle.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
               Write(bicycle.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
               Write(bicycle.WheelDiametr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\'</td>\r\n                <td>");
#nullable restore
#line 35 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
               Write(bicycle.FrameSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\'</td>\r\n                <td>");
#nullable restore
#line 36 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
               Write(bicycle.FrameMaterial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
               Write(bicycle.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" грн</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0df97878b4d8b8ce17789088ddac405506738c4f7947", async() => {
                WriteLiteral("Купить");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1074, "~/Home/Buy/", 1074, 11, true);
#nullable restore
#line 38 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1085, bicycle.BicycleId, 1085, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 40 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
                     using (Html.BeginForm("AddToCart", "Cart"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1303, "\"", 1329, 1);
#nullable restore
#line 42 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1311, bicycle.BicycleId, 1311, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"BicycleId\" />\r\n");
#nullable restore
#line 43 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
                   Write(Html.Hidden("returnUrl", Context.Request.Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"submit\" class=\"btn btn-primary\" value=\"+  в корзину\" />\r\n");
#nullable restore
#line 45 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 52 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
  
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0df97878b4d8b8ce17789088ddac405506738c4f11762", async() => {
                WriteLiteral("            \r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
                      WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1893, "btn", 1893, 3, true);
            AddHtmlAttributeValue(" ", 1896, "page", 1897, 5, true);
            AddHtmlAttributeValue(" ", 1901, "prevPage", 1902, 9, true);
#nullable restore
#line 59 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 1910, prevDisabled, 1911, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0df97878b4d8b8ce17789088ddac405506738c4f14700", async() => {
                WriteLiteral("           \r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2061, "btn", 2061, 3, true);
            AddHtmlAttributeValue(" ", 2064, "page", 2065, 5, true);
            AddHtmlAttributeValue(" ", 2069, "nextPage", 2070, 9, true);
#nullable restore
#line 63 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 2078, nextDisabled, 2079, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"infoPage\">Страница ");
#nullable restore
#line 66 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
                              Write(Model.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral(" из ");
#nullable restore
#line 66 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Home\Index.cshtml"
                                                  Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<BicyclesShop.Models.Bicycle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
