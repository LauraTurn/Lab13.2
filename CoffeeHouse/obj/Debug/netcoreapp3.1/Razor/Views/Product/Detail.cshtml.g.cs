#pragma checksum "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9424094290fce5cc5c8c226d75cb7efa1a89677"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\_ViewImports.cshtml"
using CoffeeHouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\_ViewImports.cshtml"
using CoffeeHouse.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9424094290fce5cc5c8c226d75cb7efa1a89677", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0294fe7d5e9d617deee3c63d87515446de498248", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details!</h1>\r\n\r\nThere are ");
#nullable restore
#line 8 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Detail.cshtml"
     Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" products.\r\n\r\n");
#nullable restore
#line 10 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Detail.cshtml"
 foreach (Product prod in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <br />\r\n    <strong>");
#nullable restore
#line 14 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Detail.cshtml"
       Write(prod.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 14 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Detail.cshtml"
                 Write(prod.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong><br />\r\n        Description: ");
#nullable restore
#line 15 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Detail.cshtml"
                Write(prod.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Price: ");
#nullable restore
#line 16 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Detail.cshtml"
          Write(prod.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        <br />\r\n\r\n</div>\r\n");
#nullable restore
#line 20 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\CoffeeHouse\CoffeeHouse\Views\Product\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591