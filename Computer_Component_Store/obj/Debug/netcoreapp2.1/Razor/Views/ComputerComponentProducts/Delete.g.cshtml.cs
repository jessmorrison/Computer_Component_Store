#pragma checksum "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd18ee1f95ac97b5cedfddda0cb7b7e3457a52cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComputerComponentProducts_Delete), @"mvc.1.0.view", @"/Views/ComputerComponentProducts/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ComputerComponentProducts/Delete.cshtml", typeof(AspNetCore.Views_ComputerComponentProducts_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd18ee1f95ac97b5cedfddda0cb7b7e3457a52cd", @"/Views/ComputerComponentProducts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd87db14b2a08139b09f4bdeb77b5c29411ca7f9", @"/Views/_ViewImports.cshtml")]
    public class Views_ComputerComponentProducts_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Computer_Component_Store.Data.ComputerComponentProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(107, 185, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ComputerComponentProduct</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(293, 40, false);
#line 15 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(333, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(377, 36, false);
#line 18 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(457, 47, false);
#line 21 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(504, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(548, 43, false);
#line 24 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(635, 44, false);
#line 27 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageURL));

#line default
#line hidden
            EndContext();
            BeginContext(679, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(723, 40, false);
#line 30 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImageURL));

#line default
#line hidden
            EndContext();
            BeginContext(763, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(807, 41, false);
#line 33 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(848, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(892, 37, false);
#line 36 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(929, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(973, 44, false);
#line 39 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1061, 40, false);
#line 42 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1145, 43, false);
#line 45 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1232, 39, false);
#line 48 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1315, 48, false);
#line 51 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastModified));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1407, 44, false);
#line 54 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastModified));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1489, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6595d750471c410d8869f9960415a591", async() => {
                BeginContext(1515, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1525, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1942de737c9f4f16b1cd3ea8423804c5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\jessm\Documents\CodingTemple\Computer_Component_Store\Computer_Component_Store\Views\ComputerComponentProducts\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1561, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1645, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8726aab7b2444d419215cf42d38f964f", async() => {
                    BeginContext(1667, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1683, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1696, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Computer_Component_Store.Data.ComputerComponentProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
