#pragma checksum "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\Account\Formularz.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a32397c29d7a0691377aa93489be27b4ee60cde2a86a6a5379b65d8f3a0fb6ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Account_Formularz), @"mvc.1.0.view", @"/Views/Account/Formularz.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\_ViewImports.cshtml"
using Strona_testowa

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\_ViewImports.cshtml"
using Strona_testowa.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a32397c29d7a0691377aa93489be27b4ee60cde2a86a6a5379b65d8f3a0fb6ef", @"/Views/Account/Formularz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f389da0452d662b07da2053ed82f3a4443c23a576953421c93727049f706b793", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Account_Formularz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Account/Formularz"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\Account\Formularz.cshtml"
  
    ViewData["Title"] = "Formularz";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a32397c29d7a0691377aa93489be27b4ee60cde2a86a6a5379b65d8f3a0fb6ef4635", async() => {
                WriteLiteral("\r\n    <title>Formularz studenta</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a32397c29d7a0691377aa93489be27b4ee60cde2a86a6a5379b65d8f3a0fb6ef5666", async() => {
                WriteLiteral(@"
    <div style=""width:100%;text-align:center;"">
    <div style=""width: 100%;
        height: 100px;
        background-color: rgba(26, 60, 106); 
        border-radius:100px;
        "">
    <br/><h1 style=""color:white;"">Formularz studenta</h1>
    </div><br /><br />
    <div style=""width: 50%;
        height: 500px;
        background-color: rgba(26, 60, 106, 0.8); 
        border-radius:100px;
        margin-left:25%;
        "">
    
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a32397c29d7a0691377aa93489be27b4ee60cde2a86a6a5379b65d8f3a0fb6ef6413", async() => {
                    WriteLiteral(@"
        <br/><br/><br/>
        <h1 style=""color:white;"">Wypełnij dane</h1>
        <br/>
        <div style=""color:white; font-size: 20px;"" >
            <label for=""name"">Imie:</label>
            <input type=""text"" id=""name"" name=""name"" />
        </div>
        <br />
        <div style=""color:white; font-size: 20px;"" >
            <label for=""secname"">Nazwisko:</label>
            <input type=""text"" id=""secname"" name=""secname"" />
        </div>
        <br />
        <div style=""color:white; font-size: 20px;"" >
            <label for=""mail"">E-mail:</label>
            <input type=""text"" id=""mail"" name=""mail"" />
        </div>
        <br />
        <div style=""color:white; font-size: 20px;"" >
            <label for=""phone"">Numer telefonu:</label>
            <input type=""text"" id=""phone"" name=""phone""/>
        </div>
        <br />
        <div>
            <input type=""submit"" value=""Wyślij"" />
        </div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 55 "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\Account\Formularz.cshtml"
     if (ViewData["Mess"] != null)
    {

#line default
#line hidden
#nullable disable

                WriteLiteral("        <div style=\"color: white; font-weight: bold;\">");
                Write(
#nullable restore
#line 57 "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\Account\Formularz.cshtml"
                                                       ViewData["Mess"]

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</div>\r\n");
#nullable restore
#line 58 "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\Account\Formularz.cshtml"
    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 59 "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\Account\Formularz.cshtml"
     if (ViewData["ErrorMess"] != null)
    {

#line default
#line hidden
#nullable disable

                WriteLiteral("        <div style=\"color: white; font-weight: bold;\">");
                Write(
#nullable restore
#line 61 "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\Account\Formularz.cshtml"
                                                       ViewData["ErrorMess"]

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</div>\r\n");
#nullable restore
#line 62 "C:\Users\rager\Desktop\Strona testowa\Strona testowa\Views\Account\Formularz.cshtml"
    }

#line default
#line hidden
#nullable disable

                WriteLiteral("    </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
