#pragma checksum "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10ede738d449a32f96fe9128e9316a71108cc711"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/_ViewImports.cshtml"
using ProductPortal.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10ede738d449a32f96fe9128e9316a71108cc711", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97600caf849a761d625112bd268cbb8bf0cf22f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
   
    ViewBag.Title = "Product List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">

    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>id</th>
                <th>Name</th>
                <th>Description</th>
                <th>PriceRange</th>
                <th>DisplayOrder</th>

                <th>Action</th>
                <th><a href=""/Category/Create/"" class=""class=""btn btn-primary"""">Create new</a></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 24 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
               Write(item.PriceRange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
               Write(item.DisplayOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 825, "\"", 858, 2);
            WriteAttributeValue("", 832, "/Category/Details/", 832, 18, true);
#nullable restore
#line 30 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
WriteAttributeValue("", 850, item.Id, 850, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View </a>| <a");
            BeginWriteAttribute("href", " href=\"", 873, "\"", 903, 2);
            WriteAttributeValue("", 880, "/Category/Edit/", 880, 15, true);
#nullable restore
#line 30 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
WriteAttributeValue("", 895, item.Id, 895, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit </a>| <a");
            BeginWriteAttribute("href", " href=\"", 918, "\"", 950, 2);
            WriteAttributeValue("", 925, "/Category/Delete/", 925, 17, true);
#nullable restore
#line 30 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
WriteAttributeValue("", 942, item.Id, 942, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\n            </tr>\n");
#nullable restore
#line 32 "/home/ezcoderz/Desktop/productPortal/devopsdemo/ProductPortal.Web/Views/Category/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
