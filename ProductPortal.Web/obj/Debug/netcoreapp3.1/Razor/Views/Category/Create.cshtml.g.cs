#pragma checksum "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55f4c64f32bdd6300574f704ad0f658893a54343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Create), @"mvc.1.0.view", @"/Views/Category/Create.cshtml")]
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
#line 1 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\_ViewImports.cshtml"
using ProductPortal.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f4c64f32bdd6300574f704ad0f658893a54343", @"/Views/Category/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156f61aac52ca2f61bf858333fed69e892997270", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Create.cshtml"
  
    ViewBag.Title = "Create Category";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n");
#nullable restore
#line 6 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Create.cshtml"
         using (Html.BeginForm("create", "Category", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"usr\">Name:</label>\r\n                ");
#nullable restore
#line 10 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Create.cshtml"
           Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"usr\">Description:</label>\r\n                ");
#nullable restore
#line 15 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Create.cshtml"
           Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"usr\">PriceRange:</label>\r\n                ");
#nullable restore
#line 19 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Create.cshtml"
           Write(Html.TextBoxFor(x => x.PriceRange, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"usr\">DisplayOrder:</label>\r\n                ");
#nullable restore
#line 23 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Create.cshtml"
           Write(Html.TextBoxFor(x => x.DisplayOrder, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"btn-group\">\r\n                <button type=\"submit\" class=\"btn btn-success\">Save</button>\r\n                <a class=\"btn btn-danger\" href=\"/Product/index\">Cancel</a>\r\n            </div>\r\n");
#nullable restore
#line 30 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
