#pragma checksum "C:\Users\nrzayeva\source\repos\Themegeniuslab\Themegeniuslab\Views\Shared\Components\Faq\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ec0a78283f6d85027d6d13da0de2ad02ea0ddff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Faq_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Faq/Default.cshtml")]
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
#line 1 "C:\Users\nrzayeva\source\repos\Themegeniuslab\Themegeniuslab\Views\_ViewImports.cshtml"
using Themegeniuslab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nrzayeva\source\repos\Themegeniuslab\Themegeniuslab\Views\_ViewImports.cshtml"
using Themegeniuslab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec0a78283f6d85027d6d13da0de2ad02ea0ddff", @"/Views/Shared/Components/Faq/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0971ad585d0e5f1117a142dcf25988c766e98b4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Faq_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FaqViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <section class=""faq-pg-section section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col col-lg-6 col-lg-offset-3 col-md-8 col-md-offset-2 col-sm-10 col-sm-offset-1"">
                    <div class=""section-title-s2"">
                        <span>FAQ</span>
                        <h2>Frequently Asked Question</h2>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col col-xs-12"">
                    <div class=""panel-group faq-accordion theme-accordion-s1"" id=""accordion"">
");
#nullable restore
#line 16 "C:\Users\nrzayeva\source\repos\Themegeniuslab\Themegeniuslab\Views\Shared\Components\Faq\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"panel panel-default\">\r\n                                <div class=\"panel-heading\">\r\n                                    <a data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#collapse-1\" aria-expanded=\"true\">");
#nullable restore
#line 20 "C:\Users\nrzayeva\source\repos\Themegeniuslab\Themegeniuslab\Views\Shared\Components\Faq\Default.cshtml"
                                                                                                                          Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </div>\r\n                                <div id=\"collapse-1\" class=\"panel-collapse collapse in\">\r\n                                    <div class=\"panel-body\">\r\n                                        <p>");
#nullable restore
#line 24 "C:\Users\nrzayeva\source\repos\Themegeniuslab\Themegeniuslab\Views\Shared\Components\Faq\Default.cshtml"
                                      Write(item.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 28 "C:\Users\nrzayeva\source\repos\Themegeniuslab\Themegeniuslab\Views\Shared\Components\Faq\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div> <!-- end container -->\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FaqViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591