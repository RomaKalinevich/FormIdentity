#pragma checksum "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f026ccd60a89a3776f572b7f15d3672c9db683c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\_ViewImports.cshtml"
using FormIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\_ViewImports.cshtml"
using FormIdentity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f026ccd60a89a3776f572b7f15d3672c9db683c0", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e790554de614b0003904eac84a4f8b55c37782e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomIdentityApp.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
  
    ViewBag.Title = "Список пользователей";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f026ccd60a89a3776f572b7f15d3672c9db683c04863", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"">
                    <label type=""submit"" class=""btn mr-2"" asp-action=""Block"">
                        Block
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-person-dash-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M1 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H1zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6zm5-.5a.5.5 0 0 1 .5-.5h4a.5.5 0 0 1 0 1h-4a.5.5 0 0 1-.5-.5z"" />
                        </svg>
                    </label>
                </li>
                <li class=""nav-item active"">
                    <label type=""submit"" class=""btn mr-2"" asp-action=""UnBlock"">
                    Unblock
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=");
                WriteLiteral(@"""bi bi-person-plus-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M1 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H1zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6zm7.5-3a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1 0-1H13V5.5a.5.5 0 0 1 .5-.5z"" />
                            <path fill-rule=""evenodd"" d=""M13 7.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1H14v1.5a.5.5 0 0 1-1 0v-2z"" />
                        </svg>
                    </label>
                </li>
                <li>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f026ccd60a89a3776f572b7f15d3672c9db683c06797", async() => {
                    WriteLiteral("Remove");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </li>
            </ul>
        </div>
    </nav>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
    <table class=""table form-check"">
        <tr><th><input type=""checkbox"" id=""checkAll"" class=""styled"" /></th><th>Name</th><th>Email</th><th>Date registration</th><th>Date last visit</th><th>     Status</th></tr>
");
#nullable restore
#line 35 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r\n        <td>\r\n            <input type=\"checkbox\" name=\"selectedUsers\"");
                BeginWriteAttribute("id", "\r\n                   id=\"", 2298, "\"", 2331, 1);
#nullable restore
#line 40 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
WriteAttributeValue("", 2323, user.Id, 2323, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2332, "\"", 2348, 1);
#nullable restore
#line 40 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
WriteAttributeValue("", 2340, user.Id, 2340, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                   class=\"styled\">\r\n        </td>\r\n        <td>");
#nullable restore
#line 43 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
       Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 44 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
       Write(user.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 45 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
       Write(user.registrationDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 46 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
       Write(user.lastLoginDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 47 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
         if (user.LockoutEnd == null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <td class=\"text-left\">Active</td>\r\n");
#nullable restore
#line 50 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <td>Block</td>\r\n");
#nullable restore
#line 54 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\romak\source\repos\FormIdentity\FormIdentity\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    let checkAll = document.getElementById(""checkAll"");
    checkAll.addEventListener(""click"", function () {
        $('input[name=""selectedUsers""]').prop('checked', this.checked);
    });
    let inputCheck = document.getElementById(""state"");
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomIdentityApp.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
