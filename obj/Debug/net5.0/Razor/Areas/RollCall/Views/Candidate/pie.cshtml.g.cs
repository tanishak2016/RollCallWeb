#pragma checksum "G:\RollCallWeb\Areas\RollCall\Views\Candidate\pie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f046a89713b07d6def150199e5f61b6011776f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_RollCall_Views_Candidate_pie), @"mvc.1.0.view", @"/Areas/RollCall/Views/Candidate/pie.cshtml")]
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
#line 1 "G:\RollCallWeb\Areas\RollCall\Views\_ViewImports.cshtml"
using RollCall;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\RollCallWeb\Areas\RollCall\Views\_ViewImports.cshtml"
using RollCall.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f046a89713b07d6def150199e5f61b6011776f1", @"/Areas/RollCall/Views/Candidate/pie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5891ee3185a2b4ebc1b32fc1c65a94a517da5870", @"/Areas/RollCall/Views/_ViewImports.cshtml")]
    public class Areas_RollCall_Views_Candidate_pie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<figure class=""highcharts-figure"">
    <div id=""container""></div>
    <p class=""highcharts-description"">
        RollCall 3D Pie Chart
    </p>
</figure>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<script type=""text/javascript"">

    $(document).ready(function () {

    });


    $(function () {
        debugger;
        //alert();
            $.ajax({
                url: '");
#nullable restore
#line 24 "G:\RollCallWeb\Areas\RollCall\Views\Candidate\pie.cshtml"
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
                     //alert(data);
                    debugger;
                    var series = new Array();
                    for (var i in data) {
                        var serie = new Array(data[i].Value, data[i].Item);
                        series.push(serie);
                    }
                    DrawPieChart(series);
                },
                error: function (xhr) {
                    alert('error');
                }
            });
        });
        function DrawPieChart(series) {
            $('#container').highcharts({

                chart: {
                    plotBackgroundColor: null,
                    plotBorderWidth: 1, //null,
                 ");
            WriteLiteral(@"   plotShadow: false
                },
                title: {
                    text: 'Roll Call Data'
                },
                tooltip: {
                    pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                },
                plotOptions: {
                    pie: {
                        allowPointSelect: true,
                        cursor: 'pointer',
                        dataLabels: {
                            enabled: false
                        },
                        showInLegend: true
                    }
                },
                series: [{
                    type: 'pie',
                    name: 'Task Status',
                    data: series
                }]
            });
        }
</script>










");
            WriteLiteral(@"














<style>
    #container {
        height: 400px;
    }

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
        background: #");
            WriteLiteral("f1f7ff;\r\n    }\r\n</style>");
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
