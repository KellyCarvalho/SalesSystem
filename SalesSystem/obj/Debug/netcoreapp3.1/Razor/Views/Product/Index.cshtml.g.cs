#pragma checksum "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c48b32135ec56fd1f08dbcc32b8a003173d90e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\_ViewImports.cshtml"
using SalesSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\_ViewImports.cshtml"
using SalesSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c48b32135ec56fd1f08dbcc32b8a003173d90e3", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b351feabe87694adb8125608e2a69c1d3455e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SalesSystem.Entities.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Products";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Products</h2>

<hr />

<table class=""table table-bordered"">

    <thead>
        <tr style=""background-color:#f977"">

            <th>Id</th>
            <th>Description</th>
            <th>Quantity</th>
            <th>Value</th>
            <th>Category</th>


        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 484, "\"", 510, 3);
            WriteAttributeValue("", 494, "Update(", 494, 7, true);
#nullable restore
#line 29 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml"
WriteAttributeValue("", 501, item.Id, 501, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 509, ")", 509, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer;\">\r\n                <td>");
#nullable restore
#line 30 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml"
               Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<br />

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""Register()""> Register Product</button>

<script>

    function Register() {
        window.location = window.origin + ""\\Product\\Registration"";
    }

    function Update(Id) {
        window.location = window.origin + ""\\Product\\Registration\\"" + Id;
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SalesSystem.Entities.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
