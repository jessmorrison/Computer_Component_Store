#pragma checksum "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddd52c1d9052fe2bf49a856ec10edbffa75b7011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_CoolingSystems), @"mvc.1.0.view", @"/Views/Products/CoolingSystems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/CoolingSystems.cshtml", typeof(AspNetCore.Views_Products_CoolingSystems))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd52c1d9052fe2bf49a856ec10edbffa75b7011", @"/Views/Products/CoolingSystems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd87db14b2a08139b09f4bdeb77b5c29411ca7f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_CoolingSystems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Computer_Component_Store.Data.ComputerComponentProduct>>
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
#line 2 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
  
    ViewData["Title"] = "Cooling Systems";

#line default
#line hidden
            BeginContext(127, 19, true);
            WriteLiteral("<div class=\"row\">\r\n");
            EndContext();
#line 6 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
     foreach (var product in Model.Where(x => x.Category == "COOLINGSYSTEMS"))
    {

#line default
#line hidden
            BeginContext(233, 84, true);
            WriteLiteral("        <div class=\"col-xs-4\">\r\n            <div class=\"well\">\r\n                <h2>");
            EndContext();
            BeginContext(318, 12, false);
#line 10 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(330, 50, true);
            WriteLiteral("</h2>\r\n                <img class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 380, "\"", 416, 1);
#line 11 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
WriteAttributeValue("", 386, Url.Content(product.ImageURL), 386, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(417, 24, true);
            WriteLiteral(" />\r\n                <p>");
            EndContext();
            BeginContext(442, 19, false);
#line 12 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
              Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(461, 22, true);
            WriteLiteral("</p>\r\n                ");
            EndContext();
            BeginContext(483, 572, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d94408bc2cb94e1cacf1fde90b27bfb2", async() => {
                BeginContext(522, 52, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 574, "\"", 593, 1);
#line 14 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
WriteAttributeValue("", 582, product.ID, 582, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(594, 148, true);
                WriteLiteral(" />\r\n                    <label for=\"quantity\">How many would you like?</label>\r\n                    <select name=\"quantity\" class=\"form-control\">\r\n");
                EndContext();
#line 17 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
                         for (int i = 1; i <= 10; i++)
                        {

#line default
#line hidden
                BeginContext(825, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(853, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61481ad4b74d4068849079b066a1b107", async() => {
                    BeginContext(873, 1, false);
#line 19 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
                                          Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 19 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
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
                BeginContext(883, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 20 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
                        }

#line default
#line hidden
                BeginContext(912, 136, true);
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
            BeginContext(1055, 40, true);
            WriteLiteral("\r\n            </div>\r\n        </div>  \r\n");
            EndContext();
#line 26 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\CoolingSystems.cshtml"
    }

#line default
#line hidden
            BeginContext(1102, 14, true);
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
