#pragma checksum "C:\Users\miniar\Desktop\Bon-appetit\Views\Shared\DisplayElement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceb0cbac0e7c1a1eeb00ad0d52a8742e4ad1226f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayElement), @"mvc.1.0.view", @"/Views/Shared/DisplayElement.cshtml")]
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
#line 8 "C:\Users\miniar\Desktop\Bon-appetit\Views\Shared\DisplayElement.cshtml"
using System.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\miniar\Desktop\Bon-appetit\Views\Shared\DisplayElement.cshtml"
using System.Security.Policy;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb0cbac0e7c1a1eeb00ad0d52a8742e4ad1226f", @"/Views/Shared/DisplayElement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb541c320414ce714eec680fb76206107069c8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayElement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Food>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img  m-0 p-0 w-100 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n <div class=\"card m-3 pl-0 pr-0\">  \r\n            \r\n               \r\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ceb0cbac0e7c1a1eeb00ad0d52a8742e4ad1226f4213", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 293, "~/data/images/ProductsImages/", 293, 29, true);
#nullable restore
#line 14 "C:\Users\miniar\Desktop\Bon-appetit\Views\Shared\DisplayElement.cshtml"
AddHtmlAttributeValue("", 322, Model.Image, 322, 12, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 334, "", 335, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 14 "C:\Users\miniar\Desktop\Bon-appetit\Views\Shared\DisplayElement.cshtml"
AddHtmlAttributeValue("", 374, Model.Name, 374, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n           \r\n            <div class=\"card-body\">\r\n                <div class=\"d-flex\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\miniar\Desktop\Bon-appetit\Views\Shared\DisplayElement.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                   \r\n                   <h5 class=\"ml-auto price\">");
#nullable restore
#line 20 "C:\Users\miniar\Desktop\Bon-appetit\Views\Shared\DisplayElement.cshtml"
                                        Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" dt  &nbsp;</h5>\r\n\r\n                </div>\r\n                <div class=\"card-footer pl-0 pr-0 ml-0 mr-0\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceb0cbac0e7c1a1eeb00ad0d52a8742e4ad1226f7139", async() => {
                WriteLiteral("\r\n                        \r\n                <div class=\"d-flex\">\r\n                    <button");
                BeginWriteAttribute("id", " id=", 844, "", 859, 1);
#nullable restore
#line 27 "C:\Users\miniar\Desktop\Bon-appetit\Views\Shared\DisplayElement.cshtml"
WriteAttributeValue("", 848, Model.Name, 848, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""Button"" type=""button"" >See more</button>
                     <div class=""container"">
    <div class=""modal fade"" tabindex=""-1"" id=""loginModal""
         data-keyboard=""false"" data-backdrop=""static"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">
                        ×
                    </button>
                    <h4 class=""modal-title"">Login</h4>
                </div>
                <div class=""modal-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceb0cbac0e7c1a1eeb00ad0d52a8742e4ad1226f8500", async() => {
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <input class=""form-control"" type=""text""
                                   placeholder=""Login Username"" id=""inputUserName"" />
                        </div>
                        <div class=""form-group"">
                            <input class=""form-control"" placeholder=""Login Password""
                                   type=""password"" id=""inputPassword"" />
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary button button4"">Sign</button>
                    <button type=""button"" id=""btnHideModal"" class=""btn btn-primary button button4"">
                        Hide
                    </button>
                </div>
            </div>
        </div>
    </div>
</div>
        
                   
                   <h5 class=""ml-auto btn btn-primary w-25"">Buy </h5>

                </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n                \r\n");
            WriteLiteral(@"            </div>
            
            
        </div>
       



<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"">

</script>
<script src=""bootstrap/js/bootstrap.min.js""></script>

<script type=""text/javascript"">
");
            WriteLiteral("j");
            WriteLiteral("\r\n</script>\r\n\r\n        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Food> Html { get; private set; }
    }
}
#pragma warning restore 1591