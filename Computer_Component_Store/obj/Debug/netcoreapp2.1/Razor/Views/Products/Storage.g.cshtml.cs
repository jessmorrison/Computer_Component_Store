#pragma checksum "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb173353bb0e0f2ed17e4b0450de1c549fa6edd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Storage), @"mvc.1.0.view", @"/Views/Products/Storage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Storage.cshtml", typeof(AspNetCore.Views_Products_Storage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb173353bb0e0f2ed17e4b0450de1c549fa6edd", @"/Views/Products/Storage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd87db14b2a08139b09f4bdeb77b5c29411ca7f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Storage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Computer_Component_Store.Data.ComputerComponentProduct>>
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
#line 2 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
  
    ViewData["Title"] = "Storage";

#line default
#line hidden
            BeginContext(119, 75, true);
            WriteLiteral("<h2>STORAGE</h2>\r\n<div class=\"btn-text-divider\"></div>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 8 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
     foreach (var product in Model.Where(x => x.Category == "STORAGE"))
    {

#line default
#line hidden
            BeginContext(274, 138, true);
            WriteLiteral("        <div class=\"col-12 col-sm-4\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 412, "\"", 446, 2);
            WriteAttributeValue("", 419, "/products/index/", 419, 16, true);
#line 13 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
WriteAttributeValue("", 435, product.ID, 435, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(449, 12, false);
#line 13 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
                                                         Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(461, 33, true);
            WriteLiteral("</a></h2>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 494, "\"", 528, 2);
            WriteAttributeValue("", 501, "/products/index/", 501, 16, true);
#line 14 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
WriteAttributeValue("", 517, product.ID, 517, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(529, 23, true);
            WriteLiteral("><img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 552, "\"", 588, 1);
#line 14 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
WriteAttributeValue("", 558, Url.Content(product.ImageURL), 558, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(589, 32, true);
            WriteLiteral(" /></a>\r\n                    <p>");
            EndContext();
            BeginContext(622, 19, false);
#line 15 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
                  Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(641, 30, true);
            WriteLiteral("</p>\r\n                    <p>$");
            EndContext();
            BeginContext(672, 13, false);
#line 16 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
                   Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(685, 26, true);
            WriteLiteral("</p>\r\n                    ");
            EndContext();
            BeginContext(711, 611, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc949d6f93c04895835a739e748738f2", async() => {
                BeginContext(750, 56, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 806, "\"", 825, 1);
#line 18 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
WriteAttributeValue("", 814, product.ID, 814, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(826, 156, true);
                WriteLiteral(" />\r\n                        <label for=\"quantity\">How many would you like?</label>\r\n                        <select name=\"quantity\" class=\"form-control\">\r\n");
                EndContext();
#line 21 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
                             for (int i = 1; i <= 10; i++)
                            {

#line default
#line hidden
                BeginContext(1073, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1105, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0ba402e3cdb46e7936f55ed0b6aa19d", async() => {
                    BeginContext(1125, 1, false);
#line 23 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
                                              Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 23 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
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
                BeginContext(1135, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 24 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
                            }

#line default
#line hidden
                BeginContext(1168, 147, true);
                WriteLiteral("                        </select>\r\n                        <input type=\"submit\" class=\"btn btn-danger\" value=\"Add To Cart\" />\r\n                    ");
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
            BeginContext(1322, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 31 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Storage.cshtml"
    }

#line default
#line hidden
            BeginContext(1391, 8, true);
            WriteLiteral("</div>\r\n");
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
