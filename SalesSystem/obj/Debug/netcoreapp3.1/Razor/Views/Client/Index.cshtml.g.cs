#pragma checksum "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e39227a2f2834b7752220f3e5eb88f38eb382907"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index), @"mvc.1.0.view", @"/Views/Client/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39227a2f2834b7752220f3e5eb88f38eb382907", @"/Views/Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b351feabe87694adb8125608e2a69c1d3455e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SalesSystem.Entities.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml"
  
    ViewData["Title"] = "Clients";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Customers</h2>

<hr />

<table class=""table table-bordered"">

    <thead>
        <tr style=""background-color:#f977"">

            <th>Id</th>
            <th>Name</th>
            <th>CPF/CNPJ</th>
            <th>Phone</th>
            <th>Email</th>

        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 26 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 467, "\"", 493, 3);
            WriteAttributeValue("", 477, "Update(", 477, 7, true);
#nullable restore
#line 28 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml"
WriteAttributeValue("", 484, item.Id, 484, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 492, ")", 492, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer;\">\r\n            <td>");
#nullable restore
#line 29 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml"
           Write(item.CNPJ_CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml"
           Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Estudo DDD Com aspnet core\SalesSystem\SalesSystem\Views\Client\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<br />

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""Register()""> Register Customer</button>

<script>

    function Register() {
        window.location = window.origin + ""\\Client\\Registration"";
    }

    function Update(Id) {
        window.location = window.origin + ""\\Client\\Registration\\"" + Id;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SalesSystem.Entities.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
