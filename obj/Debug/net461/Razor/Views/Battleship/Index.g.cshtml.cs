#pragma checksum "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe780ee6a2d37ff4a36088a4d574c2064a306a4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Battleship_Index), @"mvc.1.0.view", @"/Views/Battleship/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Battleship/Index.cshtml", typeof(AspNetCore.Views_Battleship_Index))]
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
#line 1 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe780ee6a2d37ff4a36088a4d574c2064a306a4b", @"/Views/Battleship/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Battleship_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Battleship>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shipicon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(98, 111, true);
            WriteLiteral("\r\n<div class=\"active\">\r\n    <h2>Deploy your fleet!</h2><br />\r\n    <p> Place your 5 ships to start!</p>\r\n    \r\n");
            EndContext();
#line 11 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
      
        int cnt = 0;
    

#line default
#line hidden
            BeginContext(246, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 14 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
         using (Html.BeginForm("clickShipPos", "Battleship"))
        {

#line default
#line hidden
            BeginContext(320, 35, true);
            WriteLiteral("            <div class=\"wrapper\">\r\n");
            EndContext();
#line 17 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
             foreach (var item in Model.grid)
            {
                        

#line default
#line hidden
#line 19 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
                         if (item==1)
                        {

#line default
#line hidden
            BeginContext(483, 78, true);
            WriteLiteral("                            <button class=\"box boxs\" type=\"submit\" name=\"cell\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 561, "", 572, 1);
#line 21 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
WriteAttributeValue("", 568, cnt, 568, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(572, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(607, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a46f1ce12398474d9616a683f83135f7", async() => {
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
            EndContext();
            BeginContext(641, 41, true);
            WriteLiteral("\r\n                            </button>\r\n");
            EndContext();
#line 24 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(766, 73, true);
            WriteLiteral("                            <button class=\"box\" type=\"submit\" name=\"cell\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 839, "", 850, 1);
#line 27 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
WriteAttributeValue("", 846, cnt, 846, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(850, 85, true);
            WriteLiteral(">\r\n                                <p>Bs</p>\r\n                            </button>\r\n");
            EndContext();
#line 30 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
                        }

#line default
#line hidden
#line 30 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
                         
                    
                cnt++;
            }

#line default
#line hidden
            BeginContext(1023, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 35 "C:\Users\USER 15\source\repos\WebApplication1\WebApplication1\Views\Battleship\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1054, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Battleship> Html { get; private set; }
    }
}
#pragma warning restore 1591
