#pragma checksum "F:\2021\PROG\MemeGenerator\Views\Memes\GetMemes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d51ef246e72cb7a946f8d87c936acd9482df3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Memes_GetMemes), @"mvc.1.0.view", @"/Views/Memes/GetMemes.cshtml")]
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
#line 1 "F:\2021\PROG\MemeGenerator\Views\_ViewImports.cshtml"
using MemeGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\2021\PROG\MemeGenerator\Views\_ViewImports.cshtml"
using MemeGenerator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d51ef246e72cb7a946f8d87c936acd9482df3d", @"/Views/Memes/GetMemes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bdd28fe52b8efe6ca8bcf6b1881c30d9cc5bcd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Memes_GetMemes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MemeGenerator.Models.Meme>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\2021\PROG\MemeGenerator\Views\Memes\GetMemes.cshtml"
  
    ViewBag.Title = "Memes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table>\n    <tr>\n        <th>Name</th>\n        <th>Image</th>\n        <th>Choose</th>\n    </tr>\n");
#nullable restore
#line 12 "F:\2021\PROG\MemeGenerator\Views\Memes\GetMemes.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 15 "F:\2021\PROG\MemeGenerator\Views\Memes\GetMemes.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 303, "\"", 318, 1);
#nullable restore
#line 16 "F:\2021\PROG\MemeGenerator\Views\Memes\GetMemes.cshtml"
WriteAttributeValue("", 309, item.url, 309, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70px\"></td>\n            <td>");
#nullable restore
#line 17 "F:\2021\PROG\MemeGenerator\Views\Memes\GetMemes.cshtml"
           Write(Html.ActionLink("Generate", "Generate", new { id = item.id, url = item.url}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td\n        </tr>\n");
#nullable restore
#line 19 "F:\2021\PROG\MemeGenerator\Views\Memes\GetMemes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MemeGenerator.Models.Meme>> Html { get; private set; }
    }
}
#pragma warning restore 1591
