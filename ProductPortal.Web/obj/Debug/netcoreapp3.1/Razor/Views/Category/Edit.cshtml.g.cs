#pragma checksum "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da97d38b2fd7a35d4eb5d24a30b0f2883216b73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Edit), @"mvc.1.0.view", @"/Views/Category/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da97d38b2fd7a35d4eb5d24a30b0f2883216b73", @"/Views/Category/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156f61aac52ca2f61bf858333fed69e892997270", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Edit.cshtml"
  
    ViewData["Title"] = "Edit Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 9 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Edit.cshtml"
     using (Html.BeginForm("edit", "Category", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Edit.cshtml"
   Write(Html.HiddenFor(x=>x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"usr\">Name:</label>\r\n            ");
#nullable restore
#line 14 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Edit.cshtml"
       Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"usr\">Description:</label>\r\n            ");
#nullable restore
#line 19 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Edit.cshtml"
       Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"usr\">PriceRange:</label>\r\n            ");
#nullable restore
#line 23 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Edit.cshtml"
       Write(Html.TextBoxFor(x => x.PriceRange, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"usr\">DisplayOrder:</label>\r\n            ");
#nullable restore
#line 27 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Edit.cshtml"
       Write(Html.TextBoxFor(x => x.DisplayOrder, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group btn-group\">\r\n            <button type=\"submit\" class=\"btn btn-success\">Save</button>\r\n            <a class=\"btn btn-danger\" href=\"/Product/index\">Cancel</a>\r\n        </div>\r\n");
#nullable restore
#line 34 "D:\RP\DotNet\Sample Projects\ProductPortal.Web\devopsdemo\ProductPortal.Web\Views\Category\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
