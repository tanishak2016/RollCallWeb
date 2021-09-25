#pragma checksum "G:\RollCallWeb\Areas\evening\Views\Candidate\CandidateDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc334c0677c5e167d3150aa28368c5dccdec69d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_evening_Views_Candidate_CandidateDisplay), @"mvc.1.0.view", @"/Areas/evening/Views/Candidate/CandidateDisplay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc334c0677c5e167d3150aa28368c5dccdec69d8", @"/Areas/evening/Views/Candidate/CandidateDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5891ee3185a2b4ebc1b32fc1c65a94a517da5870", @"/Areas/evening/Views/_ViewImports.cshtml")]
    public class Areas_evening_Views_Candidate_CandidateDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RollCall.Areas.evening.Data.DAL>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.25/css/jquery.dataTables.min.css"" />
<div class=""text-center"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table id=""tableId"" class=""table table-responsive cell-border row-border table-hover compact stripe nowrap"" cellspacing=""0"" cellpadding=""5"" width=""100%"" style=""background-color: lavender;"">
                        <tbody>
                        <thead>
                            <tr>
");
            WriteLiteral(@"                                <th>RollNumber</th>
                                <th>Name</th>
                                <th>FatherName</th>
                                <th>Gender</th>
                                <th>FaceImage</th>
                                <th>FPTemplate</th>
                                <th>FPImage</th>
                                <th>FingerID</th>
                                <th>FPReaderID</th>
                                <th>IrisTemplate</th>
                                <th>IrisImage</th>
                                <th>IrisLR</th>
                                <th>IrisReaderID</th>
                                <th>QRCodeValid</th>
                                <th>QRText</th>
                                <th>FaceVerified</th>
                                <th>ExamID</th>
                                <th>CenterID</th>
                                <th>Remarks</th>
                                <th>LastUpda");
            WriteLiteral(@"ted</th>
                                <th>ApplicationInfoAppID</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>



");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.10.25/js/jquery.dataTables.min.js""></script>


    <script>


        $(function () {
            LoadTable();
            //$(document).keypress(function (e) {
            //    if (e.which == 13) {
            //        LoadTable();
            //    }
            //});


        })
        function LoadTable() {
            var baseUrl = window.location.origin;
            $('#tableId').dataTable().fnDestroy();
          var table = $('#tableId').DataTable({
                ""pageLength"":10,
                ""serverSide"": true,
                ""filter"": true,
                ""processing"": true,
              ""searching"": true,
              ""ordering"": true,
                ""deferRender"": true,
                 ""drawCallback"": function () {
                    $(""#dataTable_wrapper"").children().eq(1).css(""overflow"", ""auto"");
              },
              ""initComplete"": function () {
                  $('.dataTables_filter input'");
                WriteLiteral(@").unbind();
                  $('.dataTables_filter input').bind('keyup', function (e) {
                          table.search(this.value).draw();
                  });
              },
              ""ajax"": {
                    ""type"": ""POST"",
                    //""url"": baseUrl + ""Home/_GetList"",
                    ""url"":baseUrl+""");
#nullable restore
#line 87 "G:\RollCallWeb\Areas\evening\Views\Candidate\CandidateDisplay.cshtml"
                              Write(Url.Action("CandidateDisplay", "Candidate", new { area="RollCall"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                     ""contentType"": ""application/json; charset=utf-8"",
                    //""headers"": { 'RequestVerificationToken': $('#__RequestVerificationToken').val() },
                    ""data"": function (data) {
                        return JSON.stringify(data);
                    }
                },
                //""columnDefs"": [
                //    {
                //        ""searchable"": true,
                //        ""orderable"": true,
                //        ""targets"": [0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,]
                //    }, {
                //        ""targets"": [],
                //        ""render"": $.fn.dataTable.render.text()
                //    }, {
                //        ""targets"": 1,
                //        ""visible"": false
                //    }

                //],

              ""columns"": [
                  /*{ ""data"": ""rollnumber"" },*/
                    { ""data"": ""rollnumber""},
                    { ""data""");
                WriteLiteral(@": ""name"" },
                    { ""data"": ""fathername"" },
                    { ""data"": ""gender"" },
                    { ""data"": ""faceimage"" },
                    { ""data"": ""fptemplate"" },
                    { ""data"": ""fpimage"" },
                    { ""data"": ""fingerid"" },
                    { ""data"": ""fpreaderid"" },
                    { ""data"": ""iristemplate"" },
                    { ""data"": ""irisimage"" },
                    { ""data"": ""irislr"" },
                    { ""data"": ""irisreaderid"" },
                    { ""data"": ""qrcodevalid"" },
                    { ""data"": ""qrtext"" },
                    { ""data"": ""faceverified"" },
                    { ""data"": ""examid"" },
                    { ""data"": ""centerid"" },
                    { ""data"": ""remarks"" },
                    { ""data"": ""lastupdated"" },
                    { ""data"": ""applicationinfoappid""}
            ],

                //""fnRowCallback"" : function(nRow, aData, iDisplayIndex){
                //$(""td:first"", nRow)");
                WriteLiteral(".html(iDisplayIndex +1);\r\n                // return nRow;\r\n                //},\r\n                \"order\": [1, \"desc\"]\r\n          })\r\n\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 149 "G:\RollCallWeb\Areas\evening\Views\Candidate\CandidateDisplay.cshtml"
  
    if (TempData["msg"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\nalert(\'");
#nullable restore
#line 153 "G:\RollCallWeb\Areas\evening\Views\Candidate\CandidateDisplay.cshtml"
  Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \');\r\n        </script>\r\n");
#nullable restore
#line 155 "G:\RollCallWeb\Areas\evening\Views\Candidate\CandidateDisplay.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RollCall.Areas.evening.Data.DAL> Html { get; private set; }
    }
}
#pragma warning restore 1591