#pragma checksum "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f98b419d4b09df2f7a97efa173d8d284169f8ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f98b419d4b09df2f7a97efa173d8d284169f8ef", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd87db14b2a08139b09f4bdeb77b5c29411ca7f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Computer_Component_Store.Models.ProductViewModel>
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
#line 2 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
            BeginContext(101, 101, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-8 mx-auto\">\r\n        <div class=\"card\">\r\n            <h2>");
            EndContext();
            BeginContext(203, 10, false);
#line 9 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(213, 23, true);
            WriteLiteral("</h2>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 236, "\"", 271, 1);
#line 10 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
WriteAttributeValue("", 242, Url.Content(Model.ImagePath), 242, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 272, "\"", 289, 1);
#line 10 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
WriteAttributeValue("", 278, Model.Name, 278, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(290, 38, true);
            WriteLiteral(" class=\"img-fluid\" />\r\n            <p>");
            EndContext();
            BeginContext(329, 17, false);
#line 11 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(346, 22, true);
            WriteLiteral("</p>\r\n            <h3>");
            EndContext();
            BeginContext(369, 25, false);
#line 12 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
           Write(Model.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(394, 21, true);
            WriteLiteral("</h3>\r\n\r\n            ");
            EndContext();
            BeginContext(415, 511, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ced0528a8fc41ea9da35c0bc8817fc9", async() => {
                BeginContext(435, 48, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 483, "\"", 500, 1);
#line 15 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
WriteAttributeValue("", 491, Model.ID, 491, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(501, 140, true);
                WriteLiteral(" />\r\n                <label for=\"quantity\">How many would you like?</label>\r\n                <select name=\"quantity\" class=\"form-control\">\r\n");
                EndContext();
#line 18 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
                     for (int i = 1; i <= 10; i++)
                    {

#line default
#line hidden
                BeginContext(716, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(740, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdc279c8a18b4e30ad7147219eabb27e", async() => {
                    BeginContext(760, 1, false);
#line 20 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
                                      Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 20 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
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
                BeginContext(770, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(795, 124, true);
                WriteLiteral("                </select>\r\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Add To Cart\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(926, 109, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<h1>Compatible Products :^]</h1>\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n");
            EndContext();
#line 33 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
     if (Model.ComputerComponentProducts != null && Model.ComputerComponentProducts.Any())
    {
        

#line default
#line hidden
#line 35 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
         foreach (var product in Model.ComputerComponentProducts)
        {

#line default
#line hidden
            BeginContext(1212, 154, true);
            WriteLiteral("            <div class=\"col-12 col-sm-4\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1366, "\"", 1400, 2);
            WriteAttributeValue("", 1373, "/products/index/", 1373, 16, true);
#line 40 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
WriteAttributeValue("", 1389, product.ID, 1389, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1401, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1403, 12, false);
#line 40 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
                                                             Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 37, true);
            WriteLiteral("</a></h2>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1486, 2);
            WriteAttributeValue("", 1459, "/products/index/", 1459, 16, true);
#line 41 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
WriteAttributeValue("", 1475, product.ID, 1475, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1487, 23, true);
            WriteLiteral("><img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1510, "\"", 1546, 1);
#line 41 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
WriteAttributeValue("", 1516, Url.Content(product.ImageURL), 1516, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1547, 35, true);
            WriteLiteral(" /></a>\r\n\r\n                        ");
            EndContext();
            BeginContext(1582, 652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f63e798878a94d8bade9d851237edb64", async() => {
                BeginContext(1621, 60, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1681, "\"", 1700, 1);
#line 44 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
WriteAttributeValue("", 1689, product.ID, 1689, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1701, 164, true);
                WriteLiteral(" />\r\n                            <label for=\"quantity\">How many would you like?</label>\r\n                            <select name=\"quantity\" class=\"form-control\">\r\n");
                EndContext();
#line 47 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
                                 for (int i = 1; i <= 10; i++)
                                {

#line default
#line hidden
                BeginContext(1964, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2000, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "825d184947974948a10a63852616522f", async() => {
                    BeginContext(2020, 1, false);
#line 49 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
                                                  Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 49 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
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
                BeginContext(2030, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 50 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(2067, 160, true);
                WriteLiteral("                            </select>\r\n                            <input type=\"submit\" class=\"btn btn-primary\" value=\"Add To Cart\" />\r\n                        ");
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
            BeginContext(2234, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 57 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#line 57 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Index.cshtml"
         

    }

#line default
#line hidden
            BeginContext(2328, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Computer_Component_Store.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
