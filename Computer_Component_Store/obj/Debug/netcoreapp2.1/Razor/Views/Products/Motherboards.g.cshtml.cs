#pragma checksum "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d6f3fa3a10a94cf57c2eb2a2a414784aee344ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Motherboards), @"mvc.1.0.view", @"/Views/Products/Motherboards.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Motherboards.cshtml", typeof(AspNetCore.Views_Products_Motherboards))]
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
#line 1 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\_ViewImports.cshtml"
using Computer_Component_Store;

#line default
#line hidden
#line 2 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\_ViewImports.cshtml"
using Computer_Component_Store.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6f3fa3a10a94cf57c2eb2a2a414784aee344ab", @"/Views/Products/Motherboards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd87db14b2a08139b09f4bdeb77b5c29411ca7f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Motherboards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Computer_Component_Store.Data.ComputerComponentProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
  
    ViewData["Title"] = "Motherboards";

#line default
#line hidden
            BeginContext(124, 19, true);
            WriteLiteral("<div class=\"row\">\r\n");
            EndContext();
#line 6 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
     foreach (var product in Model.Where(x => x.Category == "MOTHERBOARD"))
    {

#line default
#line hidden
            BeginContext(227, 122, true);
            WriteLiteral("    <div class=\"col-12 col-sm-4\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 349, "\"", 383, 2);
            WriteAttributeValue("", 356, "/products/index/", 356, 16, true);
#line 11 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
WriteAttributeValue("", 372, product.ID, 372, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(384, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(386, 12, false);
#line 11 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
                                                     Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(398, 29, true);
            WriteLiteral("</a></h2>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 427, "\"", 461, 2);
            WriteAttributeValue("", 434, "/products/index/", 434, 16, true);
#line 12 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
WriteAttributeValue("", 450, product.ID, 450, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(462, 23, true);
            WriteLiteral("><img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 485, "\"", 521, 1);
#line 12 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
WriteAttributeValue("", 491, Url.Content(product.ImageURL), 491, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(522, 28, true);
            WriteLiteral(" /></a>\r\n                <p>");
            EndContext();
            BeginContext(551, 19, false);
#line 13 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
              Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(570, 22, true);
            WriteLiteral("</p>\r\n                ");
            EndContext();
            BeginContext(592, 572, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc0c851bfc694124925f03807440aa8b", async() => {
                BeginContext(631, 52, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 683, "\"", 702, 1);
#line 15 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
WriteAttributeValue("", 691, product.ID, 691, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(703, 148, true);
                WriteLiteral(" />\r\n                    <label for=\"quantity\">How many would you like?</label>\r\n                    <select name=\"quantity\" class=\"form-control\">\r\n");
                EndContext();
#line 18 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
                         for (int i = 1; i <= 10; i++)
                        {

#line default
#line hidden
                BeginContext(934, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(962, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74bd11e3ab64aac9569ea13fcb27c7c", async() => {
                    BeginContext(982, 1, false);
#line 20 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
                                          Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 20 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
                               WriteLiteral(i);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(992, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
                        }

#line default
#line hidden
                BeginContext(1021, 136, true);
                WriteLiteral("                    </select>\r\n                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Add To Cart\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1164, 52, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Motherboards.cshtml"
    }

#line default
#line hidden
            BeginContext(1223, 14, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Computer_Component_Store.Data.ComputerComponentProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
