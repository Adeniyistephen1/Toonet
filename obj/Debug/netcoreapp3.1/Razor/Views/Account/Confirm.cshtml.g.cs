#pragma checksum "c:\Users\Adeniyi Mary A\source\repos\Toonet\Views\Account\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b50fbdb568411c3f8d289983f91185ac79cc7f86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Confirm), @"mvc.1.0.view", @"/Views/Account/Confirm.cshtml")]
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
#line 1 "c:\Users\Adeniyi Mary A\source\repos\Toonet\Views\_ViewImports.cshtml"
using Toonet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Adeniyi Mary A\source\repos\Toonet\Views\_ViewImports.cshtml"
using Toonet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Adeniyi Mary A\source\repos\Toonet\Views\_ViewImports.cshtml"
using Toonet.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Adeniyi Mary A\source\repos\Toonet\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b50fbdb568411c3f8d289983f91185ac79cc7f86", @"/Views/Account/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66fdce71e219b13be88460ca5830ee1c812015f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "c:\Users\Adeniyi Mary A\source\repos\Toonet\Views\Account\Confirm.cshtml"
  
    ViewBag.Title = "Confirm Email Address Sent";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 4 "c:\Users\Adeniyi Mary A\source\repos\Toonet\Views\Account\Confirm.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        Please check your Email Inbox, a confirm Email is Sent to ");
#nullable restore
#line 8 "c:\Users\Adeniyi Mary A\source\repos\Toonet\Views\Account\Confirm.cshtml"
                                                             Write(ViewBag.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
