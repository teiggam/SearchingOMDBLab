#pragma checksum "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b24c144cde39f9254aa1967e9deb955d135c6cca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieNight), @"mvc.1.0.view", @"/Views/Home/MovieNight.cshtml")]
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
#line 1 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\_ViewImports.cshtml"
using OMDBAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\_ViewImports.cshtml"
using OMDBAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b24c144cde39f9254aa1967e9deb955d135c6cca", @"/Views/Home/MovieNight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"908012135969493c7ffbbd9d271fa82cc7e96344", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieNight : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"padding-left: 15%; padding-right: 15%\">\r\n\r\n    <p>\r\n        So you\'re looking to fill up your whole night?  Right on! <br />\r\n        Give me THREE titles to search below:\r\n    </p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b24c144cde39f9254aa1967e9deb955d135c6cca3767", async() => {
                WriteLiteral(@"
        <p>
            <input value=""Title 1"" type=""text"" name=""title"" />
        </p>
        <p>
            <input value=""Title 2"" type=""text"" name=""title2"" />
        </p>
        <p>
            <input value=""Title 3"" type=""text"" name=""title3"" />
        </p>

        <input type=""submit"" value=""Search"" />
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br /><br />\r\n    <hr /><hr />\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
     try
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
         foreach (Movie m in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"padding-left: 10%; padding-right: 10%\">\r\n                <div style=\"scroll-snap-align:center; border:2px solid double;\">\r\n\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 859, "\"", 874, 1);
#nullable restore
#line 35 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
WriteAttributeValue("", 865, m.Poster, 865, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:250px; height: auto\" />\r\n                </div>\r\n                    <p> <h2>");
#nullable restore
#line 37 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
                       Write(m.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2> </p><hr />\r\n                <small class=\"text-muted\">\r\n                    <p>\r\n                        <b>Runtime:</b> ");
#nullable restore
#line 40 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
                                   Write(m.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b> Rated:</b> ");
#nullable restore
#line 43 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
                                  Write(m.Rated);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b> Genre:</b> ");
#nullable restore
#line 46 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
                                  Write(m.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Released:</b> ");
#nullable restore
#line 49 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
                                    Write(m.Released);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Starring:</b> ");
#nullable restore
#line 52 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
                                    Write(m.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <b>Plot:</b> ");
#nullable restore
#line 55 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
                                Write(m.Plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </small>\r\n                <br /><br /><br />\r\n            </div>\r\n");
            WriteLiteral("            <br />\r\n            <br />\r\n");
#nullable restore
#line 63 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Maggie\Documents\Grand Circus\Week 6\OMDBAPI\OMDBAPI\Views\Home\MovieNight.cshtml"
         

    }
    catch (NullReferenceException)
    {

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
