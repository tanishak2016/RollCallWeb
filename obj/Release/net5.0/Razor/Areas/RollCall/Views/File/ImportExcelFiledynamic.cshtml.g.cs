#pragma checksum "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5aa762dd26890dabbc0c4fc6a030820f0bae642"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_RollCall_Views_File_ImportExcelFiledynamic), @"mvc.1.0.view", @"/Areas/RollCall/Views/File/ImportExcelFiledynamic.cshtml")]
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
#line 1 "G:\RollCall\Areas\RollCall\Views\_ViewImports.cshtml"
using RollCall;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\RollCall\Areas\RollCall\Views\_ViewImports.cshtml"
using RollCall.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aa762dd26890dabbc0c4fc6a030820f0bae642", @"/Areas/RollCall/Views/File/ImportExcelFiledynamic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5891ee3185a2b4ebc1b32fc1c65a94a517da5870", @"/Areas/RollCall/Views/_ViewImports.cshtml")]
    public class Areas_RollCall_Views_File_ImportExcelFiledynamic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "File", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ImportExcelFiledynamic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 4 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
  
    ViewData["Title"] = "Import Excel File Dynamically";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid\">\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5aa762dd26890dabbc0c4fc6a030820f0bae6425354", async() => {
                WriteLiteral("\n\n        <div class=\"container_1\">\n");
                WriteLiteral("           \n            <div class=\"block\">\n                <input type=\"file\" id=\"fileUpload\" name=\"fileUpload\" class=\"form-control-file inline-element\">\n            </div>\n");
                WriteLiteral(@"        <div class=""block""> <button type=""submit"" id=""btnUpload"" name=""Upload"" class=""btn btn-info inline-element"">Upload</button></div>
           
        </div>
        <div align=""right"">
            <button type=""submit"" id=""btnExport"" name=""Export"" class=""btn btn-info"" formaction=""ExportDynamicExcelFile"">Export data to Excel</button>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <br />\n\n    <div class=\"row\">\n        <!--Show Message if file is uploaded or not-->\n        <span style=\"color:green;\"><b>");
#nullable restore
#line 32 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                                 Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\n\n        <div class=\"table-responsive text-nowrap\">\n\n");
#nullable restore
#line 36 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
             if (ViewBag.dynamicdt != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-hover table-striped"">
                    <thead class=""thead-dark"">
                        <tr>
                            <td>
                                <button type=""submit"" id=""btnExport"" name=""Export"" class=""btn btn-info"" formaction=""ExportDynamicExcelFile"">Export data to Excel</button>

                            </td>
                        </tr>
                        <tr>
");
#nullable restore
#line 47 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                             foreach (DataColumn col in ViewBag.dynamicDt.Columns)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th>");
#nullable restore
#line 49 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                               Write(col.ColumnName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n");
#nullable restore
#line 50 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </tr>\n                    </thead>\n                    <tbody>\n");
#nullable restore
#line 55 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                         foreach (DataRow row in ViewBag.dynamicDt.Rows)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n");
#nullable restore
#line 58 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                                 foreach (DataColumn col in ViewBag.dynamicDt.Columns)
                                {
                                    if (col.ColumnName.ToString().Contains("Url") == true || col.ColumnName.ToString().Contains("URL") == true)
                                    {
                                        //string image = @row[col.ColumnName].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\n");
            WriteLiteral("\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 2932, "\"", 2958, 1);
#nullable restore
#line 68 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
WriteAttributeValue("", 2938, row[col.ColumnName], 2938, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                                                 class=\"rounded-circle\"\n                                                 height=\"50\" width=\"50\" />\n                                        </td>\n");
#nullable restore
#line 72 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 75 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                                       Write(row[col.ColumnName]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 76 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\n");
#nullable restore
#line 80 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n");
#nullable restore
#line 83 "G:\RollCall\Areas\RollCall\Views\File\ImportExcelFiledynamic.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>


<script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>

<script type=""text/javascript"">
    var fileExtension;
    $(function () {
        $('#btnUpload').on('click', function () {
            fileExtension = ['xls', 'xlsx'];
            var filename = $('#fileUpload').val();
            if (filename.length == 0) {

                alert(""Please select a file."");
                return false;
            }
            else {
                var extension = filename.replace(/^.*\./, '');
                if ($.inArray(extension, fileExtension) == -1) {
                    alert(""Please select only excel files."");
                    return false;
                }
            }
        });

        $('#btnExport').on('click', function () {
            fileExtension = ['xls', 'xlsx'];
            var filename = $('#fileupload').val();
            if (filename.length == 0) {
                alert(""Please select a file then Import"");
          ");
            WriteLiteral("      return false;\n            }\n        });\n\n    });\n\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591