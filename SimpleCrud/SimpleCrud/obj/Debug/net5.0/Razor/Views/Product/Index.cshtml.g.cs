#pragma checksum "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf6f2045c11f5898c82108656c0e43dfa8f3b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\_ViewImports.cshtml"
using SimpleCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\_ViewImports.cshtml"
using SimpleCrud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf6f2045c11f5898c82108656c0e43dfa8f3b9e", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0227bab89a8ed7b1e147351f808ffd4cbb152a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimpleCrud.Models.ProductModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf6f2045c11f5898c82108656c0e43dfa8f3b9e3816", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"container d-flex flex-wrap\">\r\n");
#nullable restore
#line 8 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\Product\Index.cshtml"
     foreach(var item in Model)
    {
        var fullName = item.Name;
        var firstWord = fullName.IndexOf(" ") > 0 ? fullName.Substring(0, fullName.IndexOf(" ")) : fullName;

        //get substring of Description

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card m-3 border-0 bg-light\" style=\"width: 18rem;\">\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 499, "\"", 561, 4);
            WriteAttributeValue("", 505, "https://loremflickr.com/320/250/", 505, 32, true);
#nullable restore
#line 15 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\Product\Index.cshtml"
WriteAttributeValue("", 537, firstWord, 537, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 547, "?lock=", 547, 6, true);
#nullable restore
#line 15 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\Product\Index.cshtml"
WriteAttributeValue("", 553, item.Id, 553, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 562, "\"", 578, 1);
#nullable restore
#line 15 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\Product\Index.cshtml"
WriteAttributeValue("", 568, item.Name, 568, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\Product\Index.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">$");
#nullable restore
#line 18 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\Product\Index.cshtml"
                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            \r\n            <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\Product\Index.cshtml"
                            Write(item.Description.Substring(0, 60));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\HIEU NGUYEN\source\repos\simple-crud\SimpleCrud\SimpleCrud\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimpleCrud.Models.ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
