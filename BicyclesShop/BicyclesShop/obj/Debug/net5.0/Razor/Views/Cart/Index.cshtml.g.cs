#pragma checksum "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ed05adbd10bf572719baad93d69af5f9b84d6dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed05adbd10bf572719baad93d69af5f9b84d6dd", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bfda19f4ce8afc0c861eafd53550bd773d7d5a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BicyclesShop.Models.ViewModels.CartIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Корзина</h1>\r\n\r\n");
#nullable restore
#line 5 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
 if (Model.Cart.Lines.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 style=\"margin-top: 50px;\">Корзина пустая!</h2>\r\n    <h3>P.S. Но это никогда не поздно исправить :)</h3>\r\n");
#nullable restore
#line 9 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Кол-во</th>
                <th>Название</th>
                <th>Цвет</th>
                <th>Тип</th>
                <th>Диаметр колеса</th>
                <th>Размер рамы</th>
                <th>Материал рамы</th>
                <th>Цена</th>
                <th>Промежуточный итог</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
             foreach (var line in Model.Cart.Lines)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                   Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.WheelDiametr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.FrameSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.FrameMaterial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                    Write(line.Quantity * line.Bicycle.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 41 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                         using (Html.BeginForm("RemoveFromCart", "Cart"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1459, "\"", 1490, 1);
#nullable restore
#line 43 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1467, line.Bicycle.BicycleId, 1467, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"BicycleId\" />\r\n");
#nullable restore
#line 44 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                       Write(Html.Hidden("returnUrl", Context.Request.Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"submit\" class=\"btn btn-danger\" value=\"Удалить\" />\r\n");
#nullable restore
#line 46 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td>Общая стоимость:</td>\r\n                <td>");
#nullable restore
#line 54 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
               Write(Model.Cart.ComputeTotalValue());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n\r\n    </table>\r\n");
#nullable restore
#line 59 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 1986, "\"", 2009, 1);
#nullable restore
#line 60 "D:\PROGRAMMING\ASP.NET\BicycleShop_repo\ASP.NET-BicycleShop\BicyclesShop\BicyclesShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1993, Model.ReturnUrl, 1993, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn align-content-center\" style=\"margin-top:50px; background-color:lawngreen !important; border: 3px solid green;\">Продолжить покупки</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BicyclesShop.Models.ViewModels.CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591