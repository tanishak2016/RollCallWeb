#pragma checksum "G:\RollCallWeb\Areas\evening\Views\Candidate\FARIDABAD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a33187d58e1de042f15ffb2605cd60ff5118823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_evening_Views_Candidate_FARIDABAD), @"mvc.1.0.view", @"/Areas/evening/Views/Candidate/FARIDABAD.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a33187d58e1de042f15ffb2605cd60ff5118823", @"/Areas/evening/Views/Candidate/FARIDABAD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5891ee3185a2b4ebc1b32fc1c65a94a517da5870", @"/Areas/evening/Views/_ViewImports.cshtml")]
    public class Areas_evening_Views_Candidate_FARIDABAD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"" id=""containerTop"">
    <div class=""row"">
        <div class=""col-3"">
            <div id=""districtDiv""><label id=""districtlabel"" class=lbl></label></div>
        </div>
        <div class=""col-3"">
            <div id=""totaldiv""><label id=""total"" class=lbl></label></div>
        </div>
        <div class=""col-3"">
            <div id=""presentdiv""><label id=""totalPresent"" class=lbl></label></div>
        </div>
        <div class=""col-3"">
            <div id=""absentdiv""><label id=""totalAbsent"" class=lbl></label></div>
        </div>
    </div>
</div>

");
            WriteLiteral(@"<div id=""container"" class=""container"">

</div>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<script type=""text/javascript"">

       $(document).ready(function () {
    });
    $(function () {

            $.ajax({
                url: '");
#nullable restore
#line 36 "G:\RollCallWeb\Areas\evening\Views\Candidate\FARIDABAD.cshtml"
                 Write(Url.Action("pie", "Candidate", new { area="RollCall"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                dataType: ""json"",
                type: ""POST"",
                contentType: 'application/json; charset=utf-8',
                async: false,
                processData: false,
                cache: false,
                delay: 15,
                success: function (data) {

                    var totalStrenght = 0;
                    var totalPresent = 0;
                    var totalAbsent = 0;
                    var totalPercentage = 0;
                   let series = [];
                    let presentSeries = [];
                    let absentSeries = [];
                    for (let i in data) {
                            //let pieData = {};
                            //pieData.name = data[i].name;
                            //pieData.y = data[i].y;
                            //series.push(pieData);


                            if (data[i].location == 'FARIDABAD') {
                                debugger;
                                let pieDa");
            WriteLiteral(@"taTotal = {};
                                let pieDataPresent = {};
                                let pieDataAbsent = {};
                                let presentData = {};
                                totalStrenght += data[i].total;
                                pieDataTotal.name = 'Total';
                                pieDataTotal.y = data[i].total;
                                series.push(pieDataTotal);
                                pieDataPresent.name = 'Present';
                                pieDataPresent.y = data[i].present;
                                series.push(pieDataPresent);
                                pieDataAbsent.name = 'Absent';
                                pieDataAbsent.y = data[i].absent;
                                series.push(pieDataAbsent);
                               // presentSeries.push(data[i].present);
                                totalPresent += data[i].present;
                                //absentSeries.push(data[i].");
            WriteLiteral(@"absent)
                                totalAbsent += data[i].absent;


                                $('#districtlabel').text(data[i].location);

                            }
                            else {

                            }

                    }
                    totalPercentage = ((totalPresent / totalStrenght) * 100).toFixed(2);
                    var TotalStrenght = 'Total ' + ':' + totalStrenght + '';
                    var TotalPresent = 'Present ' + ':' + totalPresent + '(' + totalPercentage + '%' + ')';
                    var TotalAbsent = 'Absent' + ':' + totalAbsent + '';
                    $('#total').text(TotalStrenght);
                    $('#totalPresent').text(TotalPresent);
                    $('#totalAbsent').text(TotalAbsent);



                    DrawPieChart(series);
                },
                error: function (xhr) {
                    alert('error');
                }
            });
    });

    function DrawPieChart(");
            WriteLiteral(@"series) {
        //$('#lblPresent').text(series[3].y);
        //$('#lblAbsent').text(series[3].y - series[0].y);

        $('#container').highcharts({
            chart: {
                plotBackgroundColor: null,
                plotBorderWidth: 1, //null,
                plotShadow: true
            },
            title: {
                text: ''
            },
            tooltip: {
            //    pointFormat: '{series.name}: <b>{point.y}</b>'
            },
            plotOptions: {
                pie: {
                    allowPointSelect: true,
                    cursor: 'pointer',
                    dataLabels: {
                        enabled: true,
                        format: '<span style=color:red;font-size:15px><b>{point.name}</b>: {point.y}</span>',

                    },
                    showInLegend: true
                }
            },
            series: [{
                type: 'pie',
                colorByPoint: true,
                name");
            WriteLiteral(": \'Task Status\',\r\n                data: series\r\n            }]\r\n            });\r\n        }\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral(@"














<style>
   

    .highcharts-figure, .highcharts-data-table table {
        min-width: 310px;
        max-width: 800px;
        margin: 1em auto;
    }

    .highcharts-data-table table {
        font-family: Verdana, sans-serif;
        border-collapse: collapse;
        border: 1px solid #EBEBEB;
        margin: 10px auto;
        text-align: center;
        width: 100%;
        max-width: 500px;
    }

    .highcharts-data-table caption {
        padding: 1em 0;
        font-size: 1.2em;
        color: #555;
    }

    .highcharts-data-table th {
        font-weight: 600;
        padding: 0.5em;
    }

    .highcharts-data-table td, .highcharts-data-table th, .highcharts-data-table caption {
        padding: 0.5em;
    }

    .highcharts-data-table thead tr, .highcharts-data-table tr:nth-child(even) {
        background: #f8f8f8;
    }

    .highcharts-data-table tr:hover {
        background: #f1f7ff;
    }
</style>");
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
