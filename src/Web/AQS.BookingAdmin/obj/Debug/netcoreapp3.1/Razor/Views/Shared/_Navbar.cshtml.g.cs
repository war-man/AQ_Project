#pragma checksum "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\Shared\_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b93ccd9dea052cf49d198344818dee06edc07a5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navbar), @"mvc.1.0.view", @"/Views/Shared/_Navbar.cshtml")]
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
#line 1 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin.Infrastructure.AQPagination;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b93ccd9dea052cf49d198344818dee06edc07a5e", @"/Views/Shared/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc538716caba8d61ece7bb69ee98231840614e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <!-- Navbar -->
<nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
        </li>
        <li class=""nav-item d-none d-sm-inline-block"">
");
            WriteLiteral("        </li>\r\n        <li class=\"nav-item d-none d-sm-inline-block float-sm-right\">\r\n\r\n        </li>\r\n    </ul>\r\n\r\n\r\n\r\n    <!-- Right navbar links -->\r\n    <ul class=\"navbar-nav ml-auto\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 658, "\"", 696, 1);
#nullable restore
#line 20 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\Shared\_Navbar.cshtml"
WriteAttributeValue("", 665, Url.Action("Logout","Account"), 665, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">Logout</a>\r\n        <!-- Notifications Dropdown Menu -->\r\n");
            WriteLiteral("\r\n\r\n    </ul>\r\n</nav>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AQS.BookingAdmin.Interfaces.User.IWorkContext WorkContext { get; private set; }
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