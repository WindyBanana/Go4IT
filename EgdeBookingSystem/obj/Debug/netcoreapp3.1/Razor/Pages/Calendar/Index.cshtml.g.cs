#pragma checksum "F:\Codes\Repos\Bachelor\EgdeBookingSystem\Pages\Calendar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e6254d81704439fc6bb6c4b2b46cc4ea5d59eed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EgdeBookingSystem.Pages.Calendar.Pages_Calendar_Index), @"mvc.1.0.razor-page", @"/Pages/Calendar/Index.cshtml")]
namespace EgdeBookingSystem.Pages.Calendar
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
#line 1 "F:\Codes\Repos\Bachelor\EgdeBookingSystem\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Codes\Repos\Bachelor\EgdeBookingSystem\Pages\_ViewImports.cshtml"
using EgdeBookingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Codes\Repos\Bachelor\EgdeBookingSystem\Pages\_ViewImports.cshtml"
using EgdeBookingSystem.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e6254d81704439fc6bb6c4b2b46cc4ea5d59eed", @"/Pages/Calendar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267f5f1be834f8b263b45d0c738c3ac2050a3a35", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Calendar_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Codes\Repos\Bachelor\EgdeBookingSystem\Pages\Calendar\Index.cshtml"
  
    ViewData["Title"] = "Calendar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Calendar</h1>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
