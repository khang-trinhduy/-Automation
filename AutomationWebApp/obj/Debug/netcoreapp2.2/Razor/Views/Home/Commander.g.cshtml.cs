#pragma checksum "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\Commander.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ff8ef736526be8a69d81efa6e5b8f8301e7318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Commander), @"mvc.1.0.view", @"/Views/Home/Commander.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Commander.cshtml", typeof(AspNetCore.Views_Home_Commander))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ff8ef736526be8a69d81efa6e5b8f8301e7318", @"/Views/Home/Commander.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380adbb424684c971c6150ad03f3aee44650a0b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Commander : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SharedLibrary.TriggerModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExecuteOne", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExecuteAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\Commander.cshtml"
  
    ViewData["title"] = "Commander";
    if (ViewBag.IsNotActive != null)
    {

#line default
#line hidden
            BeginContext(135, 313, true);
            WriteLiteral(@"        <div class=""alert alert-warning alert-dismissible fade show"" role=""alert"">
          <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
          </button>
          <strong>Trigger is not active</strong> 
        </div>
");
            EndContext();
            BeginContext(458, 69, true);
            WriteLiteral("        <script>\r\n          $(\".alert\").alert();\r\n        </script>\r\n");
            EndContext();
#line 16 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\Commander.cshtml"
    }

#line default
#line hidden
            BeginContext(537, 6, true);
            WriteLiteral("<ul>\r\n");
            EndContext();
#line 19 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\Commander.cshtml"
     foreach (var item in Model.OrderBy(t => t.Position))
    {

#line default
#line hidden
            BeginContext(609, 53, true);
            WriteLiteral("        <li>\r\n            <div>\r\n                <h4>");
            EndContext();
            BeginContext(663, 10, false);
#line 23 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\Commander.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(673, 26, true);
            WriteLiteral("</h4>\r\n                <i>");
            EndContext();
            BeginContext(700, 16, false);
#line 24 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\Commander.cshtml"
              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(716, 22, true);
            WriteLiteral("</i>\r\n                ");
            EndContext();
            BeginContext(738, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ff8ef736526be8a69d81efa6e5b8f8301e73185900", async() => {
                BeginContext(789, 3, true);
                WriteLiteral("Run");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\Commander.cshtml"
                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(796, 37, true);
            WriteLiteral("\r\n            </div>\r\n        </li>\r\n");
            EndContext();
#line 28 "C:\Users\trinh\source\WTF\API\Automation\AutomationWebApp\Views\Home\Commander.cshtml"
        
    }

#line default
#line hidden
            BeginContext(850, 7, true);
            WriteLiteral("</ul>\r\n");
            EndContext();
            BeginContext(857, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ff8ef736526be8a69d81efa6e5b8f8301e73188504", async() => {
                BeginContext(884, 7, true);
                WriteLiteral("Run all");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SharedLibrary.TriggerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
