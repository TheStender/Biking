#pragma checksum "C:\Projects\Biking\Biking\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23de3b16ca786117191bcde10340fbec6bbd9394"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Projects\Biking\Biking\Views\_ViewImports.cshtml"
using Biking;

#line default
#line hidden
#line 2 "C:\Projects\Biking\Biking\Views\_ViewImports.cshtml"
using Biking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23de3b16ca786117191bcde10340fbec6bbd9394", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac23396998d02b12fa6bea901821a980908529e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "BreakArea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Projects\Biking\Biking\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Projects\Biking\Biking\Views\Home\About.cshtml"
   
    DateTime raamChallengeDate = new DateTime(2020, 3, 28);
    DateTime almanzoDate = new DateTime(2020, 5, 2);
    DateTime transAmDate = new DateTime(2020, 6, 6);
    DateTime mn650Date = new DateTime(2020, 6, 19);
    DateTime steensDate = new DateTime(2020, 7, 5);
    DateTime damnDate = new DateTime(2020, 8, 3);
    DateTime hoodooDate = new DateTime(2020, 8, 23);
    DateTime incaDivideDate = new DateTime(2020, 8, 14);
    DateTime silverStateDate = new DateTime(2020, 9, 11);

    var raamCountdown = Math.Abs(Math.Floor((DateTime.Today - raamChallengeDate).TotalDays / 7));
    var almanzoCountdown = Math.Abs(Math.Floor((DateTime.Today - almanzoDate).TotalDays / 7));
    var transAmCountdown = Math.Abs(Math.Floor((DateTime.Today - transAmDate).TotalDays / 7));
    var mn650Countdown = Math.Abs(Math.Floor((DateTime.Today - mn650Date).TotalDays / 7));
    var steensCountdown = Math.Abs(Math.Floor((DateTime.Today - steensDate).TotalDays / 7));
    var damnCountdown = Math.Abs(Math.Floor((DateTime.Today - damnDate).TotalDays / 7));
    var hoodooCountdown = Math.Abs(Math.Floor((DateTime.Today - hoodooDate).TotalDays / 7));
    var incaCountdown = Math.Abs(Math.Floor((DateTime.Today - incaDivideDate).TotalDays / 7));
    var silverStateCountdown = Math.Abs(Math.Floor((DateTime.Today - silverStateDate).TotalDays / 7));

#line default
#line hidden
            BeginContext(1413, 2205, true);
            WriteLiteral(@"
<h2>About Me</h2>

<p>I live and bike in the southwest suburbs on Minneapolis</p>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-6"">
            <p>My dream biking goals are:</p>
            <ul>
                <li><a href=""http://www.raamchallenge.com/"">TX RAAM Challenge</a> - 200 Miles - March 28, 2020</li>
                <li><a href=""https://www.almanzo.com/"">Almanzo Bike Ride</a> - 100 Miles - May 2, 2020</li>
                <li><a href=""https://transambikerace.com/"">TransAm Bike Race</a> - 4300 Miles - June 6, 2020</li>
                <li><a href=""https://www.facebook.com/events/227053444848919/"">650 B Race</a> - 650 Miles - June 19, 2020</li>
                <li><a href=""http://www.steensmazama1000.com/"">Steens Mazema Bike Race</a> - 1000 Miles - July 5, 2020</li>
                <li><a href=""https://the-damn.com/"">DaMN Ride</a> - 240 Miles - August 3, 2020</li>
                <li><a href=""https://hoodoo500.com/"">HooDoo 500</a> - 300 or 500 Miles - Au");
            WriteLiteral(@"gust 23, 2020</li>
                <li><a href=""https://bikingman.com/en/incadivide-2019-en/"">Inca Divide</a> - 1100 Miles - August 14, 2020</li>
                <li><a href=""https://www.the508.net"">Silver State 508</a> - 508 Miles - September 11, 2020</li>
                <li><a href=""https://www.heckofthenorth.com/heck-about"">Heck of the North</a> - 100 Miles - September 26, 2020</li>
            </ul>
            <p>Some dates are approximate as they haven't been selected yet</p>
        </div>
        <div class=""col-lg-6"">
            <p>I also want to up my mountain biking game in 2020, some goals are:</p>
            <ul>
                <li>Complete Lebanon Loop</li>
                <li>Complete Murphy-Hanrehan Loop</li>
                <li>Complete Elm Creek Loop</li>
                <li>Learn how to jump</li>
                <li>Complete a drop</li>
                <li>Bike at Spirit Mountain / Duluth area</li>
                <li>Bike at Cuyuna</li>
                <li>Possible Tre");
            WriteLiteral("stle/Whistler Trip?</li>\r\n            </ul>\r\n            <p>Nothing too fancy, just want to do more mountain biking</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(3618, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "812fcc90224747eb9efca63753dcfedc", async() => {
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
            EndContext();
            BeginContext(3646, 64, true);
            WriteLiteral("\r\n<h4>Weeks until each race</h4>\r\n<ul>\r\n    <li>RAAM Challenge: ");
            EndContext();
            BeginContext(3711, 13, false);
#line 68 "C:\Projects\Biking\Biking\Views\Home\About.cshtml"
                   Write(raamCountdown);

#line default
#line hidden
            EndContext();
            BeginContext(3724, 28, true);
            WriteLiteral("</li>\r\n    <li>Almanzo 100: ");
            EndContext();
            BeginContext(3753, 16, false);
#line 69 "C:\Projects\Biking\Biking\Views\Home\About.cshtml"
                Write(almanzoCountdown);

#line default
#line hidden
            EndContext();
            BeginContext(3769, 23, true);
            WriteLiteral("</li>\r\n    <li>MN 650: ");
            EndContext();
            BeginContext(3793, 14, false);
#line 70 "C:\Projects\Biking\Biking\Views\Home\About.cshtml"
           Write(mn650Countdown);

#line default
#line hidden
            EndContext();
            BeginContext(3807, 26, true);
            WriteLiteral("</li>\r\n    <li>DaMN Ride: ");
            EndContext();
            BeginContext(3834, 13, false);
#line 71 "C:\Projects\Biking\Biking\Views\Home\About.cshtml"
              Write(damnCountdown);

#line default
#line hidden
            EndContext();
            BeginContext(3847, 27, true);
            WriteLiteral("</li>\r\n    <li>HooDoo 500: ");
            EndContext();
            BeginContext(3875, 15, false);
#line 72 "C:\Projects\Biking\Biking\Views\Home\About.cshtml"
               Write(hoodooCountdown);

#line default
#line hidden
            EndContext();
            BeginContext(3890, 28, true);
            WriteLiteral("</li>\r\n    <li>Inca Divide: ");
            EndContext();
            BeginContext(3919, 13, false);
#line 73 "C:\Projects\Biking\Biking\Views\Home\About.cshtml"
                Write(incaCountdown);

#line default
#line hidden
            EndContext();
            BeginContext(3932, 33, true);
            WriteLiteral("</li>\r\n    <li>Silver State 508: ");
            EndContext();
            BeginContext(3966, 20, false);
#line 74 "C:\Projects\Biking\Biking\Views\Home\About.cshtml"
                     Write(silverStateCountdown);

#line default
#line hidden
            EndContext();
            BeginContext(3986, 12, true);
            WriteLiteral("</li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
