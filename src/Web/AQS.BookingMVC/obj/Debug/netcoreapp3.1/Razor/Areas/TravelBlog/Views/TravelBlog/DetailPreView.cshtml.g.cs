#pragma checksum "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d88700535003005ddb160992a0742c654523e2fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TravelBlog_Views_TravelBlog_DetailPreView), @"mvc.1.0.view", @"/Areas/TravelBlog/Views/TravelBlog/DetailPreView.cshtml")]
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
#line 2 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\_ViewImports.cshtml"
using AQS.BookingMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\_ViewImports.cshtml"
using AQS.BookingMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\_ViewImports.cshtml"
using AQS.BookingMVC.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\_ViewImports.cshtml"
using AQS.BookingMVC.Infrastructure.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\_ViewImports.cshtml"
using AQS.BookingMVC.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
using AQS.BookingMVC.Areas.TravelBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88700535003005ddb160992a0742c654523e2fa", @"/Areas/TravelBlog/Views/TravelBlog/DetailPreView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80aa667d007b9049a0f5a67a3b6f5ec59bf5bda5", @"/Areas/TravelBlog/Views/_ViewImports.cshtml")]
    public class Areas_TravelBlog_Views_TravelBlog_DetailPreView : AQS.BookingMVC.Infrastructure.Mvc.AQSRazorPage<TravelBlogDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pages/travelblog/TravelBlogDetail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
  
    ViewBag.Title = Model.PostDetail.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Header", async() => {
                WriteLiteral("\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 227, "\"", 270, 1);
#nullable restore
#line 8 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
WriteAttributeValue("", 237, Model.PostDetail.MetaDescription, 237, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            WriteLiteral("<div class=\"aq-main-content\" id=\"newsPageDetail\">\r\n    <h2 class=\"text-center text-danger font-weight-bold py-2\">\r\n        Preview Mode - ");
#nullable restore
#line 12 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
                  Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h2>\r\n    <section class=\"coming-soon-banner blog-banner have-bg\"");
            BeginWriteAttribute("style", " style=\"", 503, "\"", 580, 3);
            WriteAttributeValue("", 511, "background-image:url(", 511, 21, true);
#nullable restore
#line 14 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
WriteAttributeValue("", 532, Url.Content("~/images/banner-coming-soon.jpg"), 532, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 579, ")", 579, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"content\">\r\n            <h1 class=\"title\" data-aos=\"fade-up\" data-aos-duration=\"800\" data-aos-delay=\"200\">");
#nullable restore
#line 16 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
                                                                                         Write(R("LAUNCHINGSOON"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h2 class=\"text\" data-aos=\"fade-up\" data-aos-duration=\"1000\" data-aos-delay=\"400\">AQbooking.com - ");
#nullable restore
#line 17 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
                                                                                                         Write(R("SLOGAN"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n    </section>\r\n    <div class=\"article-detail\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n                    <a class=\"btn-blog left\"");
            BeginWriteAttribute("href", " href=\"", 1082, "\"", 1123, 1);
#nullable restore
#line 24 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
WriteAttributeValue("", 1089, Url.Action("Index", "TravelBlog"), 1089, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <svg width=""49"" height=""24"" viewBox=""0 0 49 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                            <path d=""M11.9639 0.988465C12.3701 0.980653 12.7412 1.22284 12.9053 1.59393C13.0654 1.96893 12.9834 2.40253 12.6982 2.69159L4.72168 11.0002H47.9756C48.335 10.9963 48.6709 11.1838 48.8506 11.4963C49.0342 11.8088 49.0342 12.1916 48.8506 12.5041C48.6709 12.8166 48.335 13.0041 47.9756 13.0002H4.72168L12.6982 21.3088C13.0811 21.7072 13.0654 22.34 12.667 22.7228C12.2686 23.1057 11.6357 23.0939 11.2529 22.6916L0.987305 12.0002L11.2529 1.30878C11.4365 1.10956 11.6943 0.996278 11.9639 0.988465Z"" fill=""black""></path>
                        </svg>");
#nullable restore
#line 27 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
                         Write(R("BACK_TO_LIST"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <br />\r\n                    <div class=\"content-blog-detail\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
                   Write(Html.Raw(Model.PostDetail.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""btn-bottom"" id=""divNavigation"">
                    </div>
                </div>
            </div>
        </div>
    </div>
    ");
#nullable restore
#line 43 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Areas\TravelBlog\Views\TravelBlog\DetailPreView.cshtml"
Write(await Component.InvokeAsync("FooterBlogBox"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        img {\r\n            max-width: 100%;\r\n        }\r\n    </style>\r\n");
            }
            );
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88700535003005ddb160992a0742c654523e2fa10817", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'a\').attr(\'href\', \'#\');\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelBlogDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591