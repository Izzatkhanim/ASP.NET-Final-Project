#pragma checksum "C:\Users\nrzayeva\source\repos\Themegeniuslab\Themegeniuslab\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "677257fa1dcc3316d50d0443b9997fefaa94aa94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"677257fa1dcc3316d50d0443b9997fefaa94aa94", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0971ad585d0e5f1117a142dcf25988c766e98b4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partials/_Loader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partials/_Pagetitle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\nrzayeva\source\repos\Themegeniuslab\Themegeniuslab\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "677257fa1dcc3316d50d0443b9997fefaa94aa944224", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "677257fa1dcc3316d50d0443b9997fefaa94aa945340", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- start blog-pg-section -->
<section class=""blog-pg-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-md-8"">
                <div class=""blog-content"">
                    <div class=""post format-standard-image"">
                        <div class=""entry-media"">
                            <img src=""assets/images/blog/img-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 526, "\"", 532, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <ul class=""entry-meta"">
                            <li><a href=""#""><i class=""fi flaticon-user""></i> By: Admin</a></li>
                            <li><a href=""#""><i class=""fi flaticon-tag-1""></i> Insurance, company</a></li>
                            <li><a href=""#""><i class=""fi flaticon-calendar""></i>11 March 2020</a></li>
                        </ul>
                        <h3><a href=""#"">And you can design with tons of artwork and fonts you won’t find anywhere</a></h3>
                        <p>Samma game samples lay spread out on the table samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with</p>
                        <a href=""#"" class=""theme-btn-s3"">Read More</a>
                    </div>
                    <div class=""post format-standard"">
                        <ul class=""entry-meta"">
");
            WriteLiteral(@"                            <li><a href=""#""><i class=""fi flaticon-user""></i> By: Admin</a></li>
                            <li><a href=""#""><i class=""fi flaticon-tag-1""></i> Insurance, company</a></li>
                            <li><a href=""#""><i class=""fi flaticon-calendar""></i>11 March 2020</a></li>
                        </ul>
                        <h3><a href=""#"">your insurance company looking for a catchy nowadays</a></h3>
                        <p>Samma game samples lay spread out on the table samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with</p>
                        <a href=""#"" class=""theme-btn-s3"">Read More</a>
                    </div>
                    <div class=""post format-gallery"">
                        <div class=""entry-media post-slider"">
                            <img src=""assets/images/blog/img-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2556, "\"", 2562, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img src=\"assets/images/blog/img-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2633, "\"", 2639, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <ul class=""entry-meta"">
                            <li><a href=""#""><i class=""fi flaticon-user""></i> By: Admin</a></li>
                            <li><a href=""#""><i class=""fi flaticon-tag-1""></i> Insurance, company</a></li>
                            <li><a href=""#""><i class=""fi flaticon-calendar""></i>11 March 2020</a></li>
                        </ul>
                        <h3><a href=""#"">And you can design with tons of artwork and fonts you won’t find anywhere</a></h3>
                        <p>Samma game samples lay spread out on the table samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with</p>
                        <a href=""#"" class=""theme-btn-s3"">Read More</a>
                    </div>
                    <div class=""post format-quote"">
                        <ul class=""entry-meta"">
   ");
            WriteLiteral(@"                         <li><a href=""#""><i class=""fi flaticon-user""></i> By: Admin</a></li>
                            <li><a href=""#""><i class=""fi flaticon-tag-1""></i> Insurance, company</a></li>
                            <li><a href=""#""><i class=""fi flaticon-calendar""></i>11 March 2020</a></li>
                        </ul>
                        <h3><a href=""#"">Insurance company looking for a dash</a></h3>
                        <p>Samma game samples lay spread out on the table samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with</p>
                        <a href=""#"" class=""theme-btn-s3"">Read More</a>
                    </div>
                    <div class=""post format-video"">
                        <div class=""entry-media video-holder"">
                            <img src=""assets/images/blog/img-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4643, "\"", 4649, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <a href=""https://www.youtube.com/embed/7e90gBu4pas?autoplay=1"" class=""video-btn"" data-type=""iframe"">
                                <i class=""fi flaticon-play""></i>
                            </a>
                        </div>
                        <ul class=""entry-meta"">
                            <li><a href=""#""><i class=""fi flaticon-user""></i> By: Admin</a></li>
                            <li><a href=""#""><i class=""fi flaticon-tag-1""></i> Insurance, company</a></li>
                            <li><a href=""#""><i class=""fi flaticon-calendar""></i>11 March 2020</a></li>
                        </ul>
                        <h3><a href=""#"">And you can design with tons of artwork and fonts you won’t find anywhere</a></h3>
                        <p>Samma game samples lay spread out on the table samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a l");
            WriteLiteral(@"ady fitted out with</p>
                        <a href=""#"" class=""theme-btn-s3"">Read More</a>
                    </div>
                    <div class=""pagination-wrapper pagination-wrapper-left"">
                        <ul class=""pg-pagination"">
                            <li>
                                <a href=""#"" aria-label=""Previous"">
                                    <i class=""fi flaticon-back""></i>
                                </a>
                            </li>
                            <li class=""active""><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li>
                                <a href=""#"" aria-label=""Next"">
                                    <i class=""fi flaticon-next""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div");
            WriteLiteral(@">
            <div class=""col col-md-4"">
                <div class=""blog-sidebar"">
                    <div class=""widget about-widget"">
                        <h3>About us</h3>
                        <div class=""img-holder"">
                            <img src=""assets/images/blog/about-widget.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7007, "\"", 7013, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <p>Samples lay spread out on the Samsa was a travelling salesman and above it there hung and null about  that he</p>
                        <div class=""social"">
                            <ul class=""clearfix"">
                                <li><a href=""#""><i class=""ti-facebook""></i></a></li>
                                <li><a href=""#""><i class=""ti-twitter-alt""></i></a></li>
                                <li><a href=""#""><i class=""ti-linkedin""></i></a></li>
                                <li><a href=""#""><i class=""ti-pinterest""></i></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""widget search-widget"">
                        <h3>Search</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677257fa1dcc3316d50d0443b9997fefaa94aa9415171", async() => {
                WriteLiteral(@"
                            <div>
                                <input type=""text"" class=""form-control"" placeholder=""Search Post.."">
                                <button type=""submit""><i class=""ti-search""></i></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""widget category-widget"">
                        <h3>Categories</h3>
                        <ul>
                            <li><a href=""#"">Life Insurance <span>(2)</span></a></li>
                            <li><a href=""#"">Home Insurance <span>(5)</span></a></li>
                            <li><a href=""#"">Health Insurance <span>(12)</span></a></li>
                            <li><a href=""#"">Property insurance  <span>(5)</span></a></li>
                            <li><a href=""#"">Fire Insurance <span>(8)</span></a></li>
                        </ul>
                    </div>
                    <div class=""widget recent-post-widget"">
                        <h3>Recent post</h3>
                        <div class=""posts"">
                            <div class=""post"">
                                <div class=""img-holder"">
                                    <img src=""assets/images/recent-posts/img-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9155, "\"", 9161, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""details"">
                                    <h4><a href=""#"">For your insurance business, employees, or clients</a></h4>
                                    <span class=""date"">11 March 2020</span>
                                </div>
                            </div>
                            <div class=""post"">
                                <div class=""img-holder"">
                                    <img src=""assets/images/recent-posts/img-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9715, "\"", 9721, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""details"">
                                    <h4><a href=""#"">Once you’ve picked your vorite, be sure to outfit your</a></h4>
                                    <span class=""date"">11 March 2020</span>
                                </div>
                            </div>
                            <div class=""post"">
                                <div class=""img-holder"">
                                    <img src=""assets/images/recent-posts/img-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10279, "\"", 10285, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""details"">
                                    <h4><a href=""#"">Be prepared for life’s Once you’ve picked your vorite</a></h4>
                                    <span class=""date"">11 March 2020</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""widget tag-widget"">
                        <h3>Tags</h3>
                        <ul>
                            <li><a href=""#"">People</a></li>
                            <li><a href=""#"">Business</a></li>
                            <li><a href=""#"">Life insurance</a></li>
                            <li><a href=""#"">Poll insurance</a></li>
                            <li><a href=""#"">Car insurance</a></li>
                            <li><a href=""#"">Manfacturing</a></li>
                        </ul>
                    </div>
                   ");
            WriteLiteral(" <div class=\"widget ad-widget\">\r\n                        <h3>Advertising Spot</h3>\r\n                        <div class=\"img-holder\">\r\n                            <a href=\"#\"><img src=\"assets/images/blog/ad-img.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11524, "\"", 11530, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end blog-pg-section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
