#pragma checksum "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a0016b194ec479f444fe3326ca37f3c6256f770"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_evening_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/evening/Views/Shared/_Layout.cshtml")]
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
#line 1 "G:\RollCallWeb\Areas\evening\Views\_ViewImports.cshtml"
using RollCall;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\RollCallWeb\Areas\evening\Views\_ViewImports.cshtml"
using RollCall.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0016b194ec479f444fe3326ca37f3c6256f770", @"/Areas/evening/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5891ee3185a2b4ebc1b32fc1c65a94a517da5870", @"/Areas/evening/Views/_ViewImports.cshtml")]
    public class Areas_evening_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/excelFileDynamic.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fullScreen_page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a0016b194ec479f444fe3326ca37f3c6256f7706377", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n");
                WriteLiteral("    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 286, "\"", 296, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 325, "\"", 335, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <title>");
#nullable restore
#line 10 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Roll Call - Evening</title>\r\n    <link rel=\"icon\" type=\"image/x-icon\" href=\"assets/favicon.ico\" />\r\n    <!-- Core theme CSS (includes Bootstrap)-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a0016b194ec479f444fe3326ca37f3c6256f7707572", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a0016b194ec479f444fe3326ca37f3c6256f7708750", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://code.highcharts.com/css/highcharts.css\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a0016b194ec479f444fe3326ca37f3c6256f77010766", async() => {
                WriteLiteral(@"
    <div class=""d-flex"" id=""wrapper"">
        <!-- Sidebar-->
        <div class=""border-end"" id=""sidebar-wrapper"" style=""background-color:aliceblue"">
            <div class=""sidebar-heading border-bottom bg-light"">Roll Call-Evening</div>
            <div class=""list-group list-group-flush"">
                <a class=""list-group-item list-group-item-action list-group-item-light p-3""");
                BeginWriteAttribute("href", " href=\"", 1301, "\"", 1373, 1);
#nullable restore
#line 27 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1308, Url.Action("CandidateDisplay","Candidate",new {area="evening" }), 1308, 65, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Candidates List</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 1487, "\"", 1559, 1);
#nullable restore
#line 28 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1494, Url.Action("ImportExcelFiledynamic","File",new {area="evening"}), 1494, 65, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: none\">Get Excel Images</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 1696, "\"", 1761, 1);
#nullable restore
#line 29 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1703, Url.Action("Dashboard","Candidate",new {area="evening" }), 1703, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >Bar Graph</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 1870, "\"", 1929, 1);
#nullable restore
#line 30 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1877, Url.Action("pie","Candidate",new {area="evening" }), 1877, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >Ambala</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 2035, "\"", 2102, 1);
#nullable restore
#line 31 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2042, Url.Action("KURUKSHETRA","Candidate",new {area="evening" }), 2042, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >Kurukshetra</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 2213, "\"", 2278, 1);
#nullable restore
#line 32 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2220, Url.Action("PANCHKULA","Candidate",new {area="evening" }), 2220, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none\" >Panchkula</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 2408, "\"", 2475, 1);
#nullable restore
#line 33 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2415, Url.Action("YAMUNANAGAR","Candidate",new {area="evening" }), 2415, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Yamunanagar</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 2585, "\"", 2647, 1);
#nullable restore
#line 34 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2592, Url.Action("KARNAL","Candidate",new {area="evening" }), 2592, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Karnal</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 2752, "\"", 2817, 1);
#nullable restore
#line 35 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2759, Url.Action("FARIDABAD","Candidate",new {area="evening" }), 2759, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none\">Faridabad</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 2946, "\"", 3010, 1);
#nullable restore
#line 36 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2953, Url.Action("GURUGRAM","Candidate",new {area="evening" }), 2953, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  style=\"display:none\">Gurugram</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 3139, "\"", 3207, 1);
#nullable restore
#line 37 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3146, Url.Action("MAHENDRAGARH","Candidate",new {area="evening" }), 3146, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none\" >Mahendragarh</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 3340, "\"", 3403, 1);
#nullable restore
#line 38 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3347, Url.Action("PANIPAT","Candidate",new {area="evening" }), 3347, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Panipat</a>\r\n                <a class=\"list-group-item list-group-item-action list-group-item-light p-3\"");
                BeginWriteAttribute("href", " href=\"", 3509, "\"", 3571, 1);
#nullable restore
#line 39 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3516, Url.Action("REWARI","Candidate",new {area="evening" }), 3516, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""display:none"">Rewari</a>



            </div>
        </div>
        <!-- Page content wrapper-->
        <div id=""page-content-wrapper"" style=""background-color: #eff1f7"">
            <!-- Top navigation-->
            <nav class=""navbar navbar-expand-lg navbar-light  "">
                <div class=""container-fluid"">
                    <button class=""btn btn-primary"" id=""sidebarToggle"" style=""display:none"">Full Screen</button>
                    <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
                    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"" >
                        <ul class=""navbar-nav ms-auto mt-2 mt-lg-0"" style=""display: none"">
                            <li class=""nav-item active""><a class=""nav-link"" href=""#!"">Home</a></li>
              ");
                WriteLiteral(@"              <li class=""nav-item""><a class=""nav-link"" href=""#!"">Link</a></li>
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" id=""navbarDropdown"" href=""#"" role=""button"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Dropdown</a>
                                <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""navbarDropdown"">
                                    <a class=""dropdown-item"" href=""#!"">Action</a>
                                    <a class=""dropdown-item"" href=""#!"">Another action</a>
                                    <div class=""dropdown-divider""></div>
                                    <a class=""dropdown-item"" href=""#!"">Something else here</a>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <!-- Page content-->
            <div class");
                WriteLiteral("=\" table_layout\">\r\n");
                WriteLiteral("                ");
#nullable restore
#line 72 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a0016b194ec479f444fe3326ca37f3c6256f77020681", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a0016b194ec479f444fe3326ca37f3c6256f77021781", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a0016b194ec479f444fe3326ca37f3c6256f77022881", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a0016b194ec479f444fe3326ca37f3c6256f77023981", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 86 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"



    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script src=""https://code.highcharts.com/highcharts-3d.js""></script>
    <script src=""https://code.highcharts.com/modules/exporting.js""></script>
    <script src=""https://code.highcharts.com/modules/export-data.js""></script>
    <script src=""https://code.highcharts.com/modules/accessibility.js""></script>



    ");
#nullable restore
#line 98 "G:\RollCallWeb\Areas\evening\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
