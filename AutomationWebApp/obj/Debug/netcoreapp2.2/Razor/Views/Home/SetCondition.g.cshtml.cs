#pragma checksum "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2093ec56cdb311f78998c48bba8d710b260eab5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SetCondition), @"mvc.1.0.view", @"/Views/Home/SetCondition.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SetCondition.cshtml", typeof(AspNetCore.Views_Home_SetCondition))]
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
#line 1 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\_ViewImports.cshtml"
using AutomationWebApp;

#line default
#line hidden
#line 2 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\_ViewImports.cshtml"
using AutomationWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2093ec56cdb311f78998c48bba8d710b260eab5e", @"/Views/Home/SetCondition.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380adbb424684c971c6150ad03f3aee44650a0b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SetCondition : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutomationWebApp.Models.TriggerCondition>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetCondition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
  
    ViewData["title"] = "Trigger condition";

#line default
#line hidden
            BeginContext(103, 29, true);
            WriteLiteral("<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(132, 3945, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2093ec56cdb311f78998c48bba8d710b260eab5e6079", async() => {
                BeginContext(164, 164, true);
                WriteLiteral("\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-1-12 col-form-label\">Title</label>\r\n            <div class=\"col-sm-1-12\">\r\n                ");
                EndContext();
                BeginContext(328, 140, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2093ec56cdb311f78998c48bba8d710b260eab5e6637", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 10 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Trigger.Title);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 10 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
                                                                                 WriteLiteral(Model.Trigger.Title);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 10 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
AddHtmlAttributeValue("", 431, Model.Trigger.Title, 431, 20, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(468, 104, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <div class=\"form-group row\">\r\n            <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 572, "\"", 604, 1);
#line 15 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
WriteAttributeValue("", 578, Model.Trigger.Description, 578, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(605, 112, true);
                WriteLiteral(" class=\"col-sm-1-12 col-form-label\">Description</label>\r\n            <div class=\"col-sm-1-12\">\r\n                ");
                EndContext();
                BeginContext(717, 158, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2093ec56cdb311f78998c48bba8d710b260eab5e10455", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 17 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Trigger.Description);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 17 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
                                                                                       WriteLiteral(Model.Trigger.Description);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
AddHtmlAttributeValue("", 832, Model.Trigger.Description, 832, 26, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(875, 104, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <div class=\"form-group row\">\r\n            <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 979, "\"", 1011, 1);
#line 22 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
WriteAttributeValue("", 985, Model.Trigger.IsNotActive, 985, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1012, 112, true);
                WriteLiteral(" class=\"col-sm-1-12 col-form-label\">IsNotActive</label>\r\n            <div class=\"col-sm-1-12\">\r\n                ");
                EndContext();
                BeginContext(1124, 162, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2093ec56cdb311f78998c48bba8d710b260eab5e14301", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 24 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Trigger.IsNotActive);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 24 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
                                                                                           WriteLiteral(Model.Trigger.IsNotActive);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
AddHtmlAttributeValue("", 1243, Model.Trigger.IsNotActive, 1243, 26, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1286, 104, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <div class=\"form-group row\">\r\n            <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 1390, "\"", 1419, 1);
#line 29 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
WriteAttributeValue("", 1396, Model.Trigger.Position, 1396, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1420, 109, true);
                WriteLiteral(" class=\"col-sm-1-12 col-form-label\">Position</label>\r\n            <div class=\"col-sm-1-12\">\r\n                ");
                EndContext();
                BeginContext(1529, 151, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2093ec56cdb311f78998c48bba8d710b260eab5e18151", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 31 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Trigger.Position);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 31 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
                                                                                      WriteLiteral(Model.Trigger.Position);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
AddHtmlAttributeValue("", 1640, Model.Trigger.Position, 1640, 23, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1680, 104, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <div class=\"form-group row\">\r\n            <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 1784, "\"", 1810, 1);
#line 36 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
WriteAttributeValue("", 1790, Model.Trigger.Table, 1790, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1811, 106, true);
                WriteLiteral(" class=\"col-sm-1-12 col-form-label\">Table</label>\r\n            <div class=\"col-sm-1-12\">\r\n                ");
                EndContext();
                BeginContext(1917, 140, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2093ec56cdb311f78998c48bba8d710b260eab5e21981", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 38 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Trigger.Table);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 38 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
                                                                                 WriteLiteral(Model.Trigger.Table);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 38 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
AddHtmlAttributeValue("", 2020, Model.Trigger.Table, 2020, 20, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2057, 191, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n          <label for=\"\">Condition</label>\r\n          <select class=\"form-control\" name=\"\" id=\"Condition\">\r\n            ");
                EndContext();
                BeginContext(2248, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2093ec56cdb311f78998c48bba8d710b260eab5e25348", async() => {
                    BeginContext(2265, 10, true);
                    WriteLiteral("Choose one");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2284, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
             foreach (var item in Model.Conditions)
            {

#line default
#line hidden
                BeginContext(2354, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(2370, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2093ec56cdb311f78998c48bba8d710b260eab5e27147", async() => {
                    BeginContext(2396, 7, false);
#line 47 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
                                    Write(item.Id);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 47 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
                   WriteLiteral(item.Id);

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
                BeginContext(2412, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
            }

#line default
#line hidden
                BeginContext(2429, 1641, true);
                WriteLiteral(@"          </select>
        </div>
        <div class=""form-group"" hidden>
          <label for="""">Operator</label>
          <input type=""text"" name=""cId"" id=""cId"" class=""form-control"" placeholder=""Operator"" aria-describedby=""helpId"">
          <small id=""helpId"" class=""text-muted"">Help text</small>
        </div>
        <div class=""form-group"">
          <label for="""">Operator</label>
          <input type=""text"" name=""Operator"" id=""Operator"" class=""form-control"" placeholder=""Operator"" aria-describedby=""helpId"">
          <small id=""helpId"" class=""text-muted"">Help text</small>
        </div>
        <div class=""form-group"">
          <label for="""">Type</label>
          <input type=""text"" name=""Type"" id=""Type"" class=""form-control"" placeholder=""Type"" aria-describedby=""helpId"">
          <small id=""helpId"" class=""text-muted"">Help text</small>
        </div>
        <div class=""form-group"">
          <label for="""">Threshold</label>
          <input type=""text"" name=""Threshold"" id=""Threshold");
                WriteLiteral(@""" class=""form-control"" placeholder=""Threshold"" aria-describedby=""helpId"">
          <small id=""helpId"" class=""text-muted"">Help text</small>
        </div>
        <div class=""form-check"">
          <label class=""form-check-label"">
            <input type=""checkbox"" class=""form-check-input"" name=""All"" id=""All"" value=""true"" checked>
            All (Any if not checked)
          </label>
        </div>
        <div class=""form-group row"">
            <div class=""offset-sm-2 col-sm-10"">
                <button type=""submit"" class=""btn btn-primary"">Save</button>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4077, 53, true);
            WriteLiteral("\r\n</div>\r\n<script>\r\n    var conditions = JSON.parse(\'");
            EndContext();
            BeginContext(4131, 42, false);
#line 85 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\SetCondition.cshtml"
                            Write(Html.Raw(Json.Serialize(Model.Conditions)));

#line default
#line hidden
            EndContext();
            BeginContext(4173, 323, true);
            WriteLiteral(@"');
    $('#Condition').change(function(){
        var condition = conditions.find(c => c.Id === parseInt($(this).val()));
        $('#Operator').val(condition.Operator);
        $('#Type').val(condition.Type);
        $('#Threshold').val(condition.Threshold);
        $('#cId').val(condition.Id);
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutomationWebApp.Models.TriggerCondition> Html { get; private set; }
    }
}
#pragma warning restore 1591
