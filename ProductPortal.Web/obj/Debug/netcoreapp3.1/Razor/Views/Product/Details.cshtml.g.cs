#pragma checksum "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e67fbde600a49e161429a136b50542c38033b9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/_ViewImports.cshtml"
using ProductPortal.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e67fbde600a49e161429a136b50542c38033b9c", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97600caf849a761d625112bd268cbb8bf0cf22f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
  
    ViewBag.Title = "Product Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n\n    <table class=\"table table-striped\">\n        <thead>\n            <tr>\n                <th>");
#nullable restore
#line 10 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
               Write(Html.LabelFor(x=>x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 11 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
               Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 12 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
               Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 13 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
               Write(Html.LabelFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 14 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
               Write(Html.LabelFor(x => x.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 15 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
               Write(Html.LabelFor(x => x.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 16 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
               Write(Html.LabelFor(x => x.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>Action</th>\n            </tr>\n        </thead>\n        <tbody>\n                <tr>\n                    <td>");
#nullable restore
#line 22 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 23 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 24 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 25 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
                   Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 26 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
                   Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
                   Write(Model.ExpirationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><a href=\"/Product/index\">Back to list</a> | <a");
            BeginWriteAttribute("href", " href=\"", 1044, "\"", 1074, 2);
            WriteAttributeValue("", 1051, "/Product/Edit/", 1051, 14, true);
#nullable restore
#line 29 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
WriteAttributeValue("", 1065, Model.Id, 1065, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit </a> | <a");
            BeginWriteAttribute("href", " href=\"", 1090, "\"", 1122, 2);
            WriteAttributeValue("", 1097, "/Product/Delete/", 1097, 16, true);
#nullable restore
#line 29 "/home/ezcoderz/Desktop/Portal/devopsdemo/ProductPortal.Web/Views/Product/Details.cshtml"
WriteAttributeValue("", 1113, Model.Id, 1113, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\n                </tr>\n            \n        </tbody>\n    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
