#pragma checksum "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab5c536ad6181d8f0362b7f8ed87f50365dc70da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Details.cshtml", typeof(AspNetCore.Views_User_Details))]
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
#line 1 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#line 2 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab5c536ad6181d8f0362b7f8ed87f50365dc70da", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.Entities.Orders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 31, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(118, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab5c536ad6181d8f0362b7f8ed87f50365dc70da3952", async() => {
                BeginContext(141, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(155, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(248, 38, false);
#line 16 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(286, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(342, 45, false);
#line 19 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderTime));

#line default
#line hidden
            EndContext();
            BeginContext(387, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(443, 46, false);
#line 22 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UsernameId));

#line default
#line hidden
            EndContext();
            BeginContext(489, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(545, 43, false);
#line 25 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PizzaId));

#line default
#line hidden
            EndContext();
            BeginContext(588, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(706, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(755, 37, false);
#line 34 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(792, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(848, 44, false);
#line 37 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderTime));

#line default
#line hidden
            EndContext();
            BeginContext(892, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(948, 45, false);
#line 40 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.UsernameId));

#line default
#line hidden
            EndContext();
            BeginContext(993, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1049, 42, false);
#line 43 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.PizzaId));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1147, 65, false);
#line 46 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1233, 71, false);
#line 47 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1325, 69, false);
#line 48 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Nathan\GitHub\Woodruff_Nathan_Project1\Woodruff_Nathan_Project1\WebApplication\Views\User\Details.cshtml"
}

#line default
#line hidden
            BeginContext(1433, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.Entities.Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
