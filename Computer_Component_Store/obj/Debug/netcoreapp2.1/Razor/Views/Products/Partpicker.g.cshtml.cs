#pragma checksum "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ab56d1c1784e1cb609b394ad9c7d582eeb5a240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Partpicker), @"mvc.1.0.view", @"/Views/Products/Partpicker.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Partpicker.cshtml", typeof(AspNetCore.Views_Products_Partpicker))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab56d1c1784e1cb609b394ad9c7d582eeb5a240", @"/Views/Products/Partpicker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd87db14b2a08139b09f4bdeb77b5c29411ca7f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Partpicker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Computer_Component_Store.Data.ComputerComponentProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
  
    ViewData["Title"] = "Part Picker";

#line default
#line hidden
            BeginContext(123, 257, true);
            WriteLiteral(@"
<h2>Part Picker</h2>

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <select class=""form-control form-control-lg"" onchange=""setMotherboardValue(event)"">
                    ");
            EndContext();
            BeginContext(380, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c99fbbcaf5004592a3972d75915aa26d", async() => {
                BeginContext(397, 18, true);
                WriteLiteral("Choose Motherboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(424, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                     foreach (var product in Model.Where(x => x.Category == "MOTHERBOARD"))
                    {

#line default
#line hidden
            BeginContext(542, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(566, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e7dbe27cee0491787d6cc9b0aa42bd6", async() => {
                BeginContext(595, 12, false);
#line 16 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                                               Write(product.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                           WriteLiteral(product.ID);

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
            BeginContext(616, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                    }

#line default
#line hidden
            BeginContext(641, 45, true);
            WriteLiteral("                </select>\r\n\r\n                ");
            EndContext();
            BeginContext(686, 604, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f81f1a8d1646bc8d92b8a8561e88a2", async() => {
                BeginContext(712, 227, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\" value=\"\" id=\"motherboardID\"/>\r\n                    <label for=\"quantity\">How many would you like?</label>\r\n                    <select name=\"quantity\" class=\"form-control\">\r\n");
                EndContext();
#line 24 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                         for (int i = 1; i <= 10; i++)
                        {

#line default
#line hidden
                BeginContext(1022, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1050, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04d6f700f3eb486cb0693afc8b07ed8f", async() => {
                    BeginContext(1070, 1, false);
#line 26 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                                          Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 26 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
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
                BeginContext(1080, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                        }

#line default
#line hidden
                BeginContext(1109, 174, true);
                WriteLiteral("                    </select>\r\n                    <input type=\"submit\" class=\"btn btn-primary\" id=\"motherboardSubmitButton\" value=\"Add To Cart\"  disabled/>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1290, 283, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <select class=""form-control form-control-lg"" onchange=""setCableValue(event)"">
                    ");
            EndContext();
            BeginContext(1573, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d7317622164017a17ffb5333ef147c", async() => {
                BeginContext(1590, 12, true);
                WriteLiteral("Choose Cable");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1611, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                     foreach (var product in Model.Where(x => x.Category == "CABLE"))
                    {

#line default
#line hidden
            BeginContext(1723, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1747, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85619d66ff0948d28919de85ebb6c12b", async() => {
                BeginContext(1776, 12, false);
#line 43 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                                               Write(product.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                           WriteLiteral(product.ID);

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
            BeginContext(1797, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                    }

#line default
#line hidden
            BeginContext(1822, 45, true);
            WriteLiteral("                </select>\r\n\r\n                ");
            EndContext();
            BeginContext(1867, 605, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71f09b8143c841ca88aa90ed37391aef", async() => {
                BeginContext(1906, 222, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\" value=\"\" id=\"cableID\" />\r\n                    <label for=\"quantity\">How many would you like?</label>\r\n                    <select name=\"quantity\" class=\"form-control\">\r\n");
                EndContext();
#line 51 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                         for (int i = 1; i <= 10; i++)
                        {

#line default
#line hidden
                BeginContext(2211, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2239, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c7c1362e0fe45ca93aed707b4e55216", async() => {
                    BeginContext(2259, 1, false);
#line 53 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                                          Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 53 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
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
                BeginContext(2269, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 54 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                        }

#line default
#line hidden
                BeginContext(2298, 167, true);
                WriteLiteral("                    </select>\r\n                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Add To Cart\" id=\"cableSubmitButton\" disabled/>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2472, 293, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <select class=""form-control form-control-lg"" onchange=""setCoolingSystemValue(event)"">
                    ");
            EndContext();
            BeginContext(2765, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17aabace59d463daa68ba68b032962e", async() => {
                BeginContext(2782, 21, true);
                WriteLiteral("Choose Cooling System");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2812, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 69 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                     foreach (var product in Model.Where(x => x.Category == "COOLINGSYSTEM"))
                    {

#line default
#line hidden
            BeginContext(2932, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2956, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c0968593a75409788e45432ad6f7816", async() => {
                BeginContext(2985, 12, false);
#line 71 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                                               Write(product.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                           WriteLiteral(product.ID);

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
            BeginContext(3006, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 72 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                    }

#line default
#line hidden
            BeginContext(3031, 45, true);
            WriteLiteral("                </select>\r\n\r\n                ");
            EndContext();
            BeginContext(3076, 622, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8e2ce55f8e48509237e23bb89e73fb", async() => {
                BeginContext(3115, 230, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\" value=\"\" id=\"CoolingSystemID\" />\r\n                    <label for=\"quantity\">How many would you like?</label>\r\n                    <select name=\"quantity\" class=\"form-control\">\r\n");
                EndContext();
#line 79 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                         for (int i = 1; i <= 10; i++)
                        {

#line default
#line hidden
                BeginContext(3428, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(3456, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a235e44cccc841718f32550395c56874", async() => {
                    BeginContext(3476, 1, false);
#line 81 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                                          Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 81 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
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
                BeginContext(3486, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 82 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\Products\Partpicker.cshtml"
                        }

#line default
#line hidden
                BeginContext(3515, 176, true);
                WriteLiteral("                    </select>\r\n                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Add To Cart\" id=\"coolingSystemSubmitButton\" disabled />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3698, 1596, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>


<script type=""text/javascript"">
    //$(document).ready(function () {
    //    $('#motherboardbLabel').change((e) => {
    //        console.log(""changed drop-down"");
    //        if ($(e.target).val() == ""Choose Motherboard"") {
    //            $(""#motherboardSubmitButton"").prop('disabled', 'disabled');
    //        }
    //        else {
    //            $(""#motherboardSubmitButton"").removeAttr('disabled');
    //        }
    //    });
    //});

    function setMotherboardValue(e)
    {
        document.getElementById(""motherboardID"").value = e.target.value;
        console.log(e.target.value);
        e.target.value == ""Choose Motherboard"" ? document.getElementById(""motherboardSubmitButton"").disabled = true : document.getElementById(""motherboardSubmitButton"").disabled = false;
    }
       
     
    



    function setCableValue(e) {
        document.getElementById(""cableID"").value = e.target.value;
        co");
            WriteLiteral(@"nsole.log(e.target.value);
        e.target.value == ""Choose Cable"" ? document.getElementById(""cableSubmitButton"").disabled = true : document.getElementById(""cableSubmitButton"").disabled = false;
    }
    function setCoolingSystemValue(e) {
        document.getElementById(""CoolingSystemID"").value = e.target.value;
        console.log(e.target.value);
        e.target.value == ""Choose Cooling System"" ? document.getElementById(""coolingSystemSubmitButton"").disabled = true : document.getElementById(""coolingSystemSubmitButton"").disabled = false;
    } 
</script>");
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
