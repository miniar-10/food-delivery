#pragma checksum "C:\Users\miniar\Desktop\Bon-appetit\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe8e71329c92452aa2cb3dc16245acf579ede044"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#line 1 "C:\Users\miniar\Desktop\Bon-appetit\Views\_ViewImports.cshtml"
using Bon_appetit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miniar\Desktop\Bon-appetit\Views\_ViewImports.cshtml"
using Bon_appetit.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\miniar\Desktop\Bon-appetit\Views\Home\Home.cshtml"
using Bon_appetit.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miniar\Desktop\Bon-appetit\Views\Home\Home.cshtml"
using Bon_appetit.Views;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8e71329c92452aa2cb3dc16245acf579ede044", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb541c320414ce714eec680fb76206107069c8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.6.1/jquery.min.js\"></script>\r\n    \r\n\r\n<div class=\"text-center pt-3\">\r\n    <h1 class=\"display-4\">Our food</h1>\r\n</div>\r\n\r\n\r\n\r\n       \r\n");
#nullable restore
#line 19 "C:\Users\miniar\Desktop\Bon-appetit\Views\Home\Home.cshtml"
Write(await Html.RenderComponentAsync<ProductList>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n<script src=\"./_framework/blazor.server.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
