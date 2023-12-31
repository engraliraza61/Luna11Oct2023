#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b84b8078820ab29f8d53680458cde8b83eaabfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__reportStart), @"mvc.1.0.view", @"/Views/Shared/_reportStart.cshtml")]
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
#line 1 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\_ViewImports.cshtml"
using Luna.Recruitment.VisaProcessing.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\_ViewImports.cshtml"
using Luna.Recruitment.VisaProcessing.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b84b8078820ab29f8d53680458cde8b83eaabfd", @"/Views/Shared/_reportStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__reportStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Luna.Recruitment.VisaProcessing.Data.DTO.ReportDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-responsive-md applyDataTableWithExport6"" id=""datatables"">
    <thead>
        <tr>
            <th style=""display:none"">Id</th>
            <th style=""display:none"">TradeId</th>
            <th style=""display:none"">visaProcessId</th>
            <th>File Number</th>
            <th>Name</th>
            <th>Passport</th>
            <th>Trade</th>
            <th hidden>Status</th>
            <th>Status</th>
            <th>ProcessingStart</th>
");
            WriteLiteral("            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"CandidateIdStart\" style=\"display:none\">\r\n                    <span>");
#nullable restore
#line 34 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </td>\r\n                <td class=\"CanddiateTradeId\" style=\"display:none\">\r\n                    <span>");
#nullable restore
#line 37 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
                     Write(item.TradeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </td>\r\n                <td class=\"visaProcessId\" style=\"display:none\">\r\n                    <span>");
#nullable restore
#line 40 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
                     Write(item.visaProcessId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </td>\r\n                <td class=\"FileNumber\">\r\n                    <span>");
#nullable restore
#line 43 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
                     Write(item.FileNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"Name\">\r\n");
            WriteLiteral("                    <a id=\"updatedInfoStart\" style=\"cursor:pointer\">");
#nullable restore
#line 48 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"Passport\">\r\n                    <span>");
#nullable restore
#line 52 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
                     Write(item.Passport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"Trade\">\r\n                    <span>");
#nullable restore
#line 56 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
                     Write(item.Trade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </td>\r\n");
            WriteLiteral("                <td hidden id=\"statusId\">\r\n                    ");
#nullable restore
#line 63 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
               Write(item.StatusId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"ProcessingStartStatus\">\r\n");
            WriteLiteral("                    <select class=\"startStatus\"");
            BeginWriteAttribute("id", " id=\"", 2769, "\"", 2800, 2);
            WriteAttributeValue("", 2774, "startStatus_", 2774, 12, true);
#nullable restore
#line 67 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
WriteAttributeValue("", 2786, item.StatusId, 2786, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </select>\r\n                </td>\r\n                <td class=\"ProcessingStart\">\r\n                    <span>");
#nullable restore
#line 71 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
                     Write(item.ProcessingStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <input required type=\"date\"");
            BeginWriteAttribute("value", " value=\"", 3011, "\"", 3044, 1);
#nullable restore
#line 72 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
WriteAttributeValue("", 3019, item.ProcessingStartDate, 3019, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""display:none"" />
                </td>
                <td>
                    <a class=""btnEdit"" href=""javascript:;"">Edit</a>
                    <a class=""btnUpdateStart"" href=""javascript:;"" style=""display:none"">Update</a>
                    <a class=""btnCancel"" href=""javascript:;"" style=""display:none"">Cancel</a>
");
            WriteLiteral("                </td>\r\n");
            WriteLiteral("\r\n\r\n            </tr>\r\n");
#nullable restore
#line 93 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportStart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
            WriteLiteral(@"
<script type=""text/javascript"">

    $(document).ready(function () {
        var table = $('#datatables').DataTable();

        table.rows().every(function (rowIdx, tableLoop, rowLoop) {
            var row = this.node();
            var statusId2 = $(row).find('td').eq(7).html().trim();
            //var statusId3 = $(row).find('td').eq(9).html();
            var selectElement = $(row).find('select.startStatus');

            // Perform your AJAX request and populate the <select> element
            $.getJSON('/CandidateProfile/GetBVisaStatus/', function (data) {
                // Clear the current options
                selectElement.empty();

                // Add a default option
                selectElement.append('<option value=""0"">-- Select Visa Status --</option>');

                // Add options from the data
                $.each(data, function () {
                    var option = $('<option>', {
                        value: this.id,
                        text: th");
            WriteLiteral(@"is.name
                    });
                    selectElement.append(option);
                });

                // Set the selected value based on statusId2 or statusId3
                selectElement.val(statusId2); // Change this to select the appropriate value

            }).fail(function (jqXHR, textStatus, errorThrown) {
                alert('Error getting visa trades!');
            });
        });
        
    });
        function GetVisaStatus(id) {
            $.getJSON('/CandidateProfile/GetBVisaStatus/"")', function (data) {
                $('.startStatus option').remove();
                $('.startStatus').append('<option value=""0"" selected>-- Select Visa Status --</option>');
                $.each(data, function () {
                    $('.startStatus').append('<option value=' + this.id + '>' + this.name + '</b></option>');
                });
            }).fail(function (jqXHR, textStatus, errorThrown) {
                alert('Error getting visa trades!');
     ");
            WriteLiteral(@"       });
        }
    $(""body"").on(""click"", ""#updatedInfoStart"", function () {
        var row = $(this).closest(""tr"");
        Id = row.find("".CandidateIdStart"").find(""span"").html();
        var Obj = { id: Id };
        updatedCandidateInfo(Obj);
    });
    $('#updateInfoCandidate').click(function () {

        if (!$('#updatedPlaceOfBirthCountryId').val() || $('#updatedPlaceOfBirthCountryId').val() == 0) {
            alert(""Please select a country."");
            return false;
        }
        if (!$('#updatedPlaceOfBirthCityId').val() || $('#updatedPlaceOfBirthCityId').val() == 0) {
            alert(""Please select a city."");
            return false;
        }
        if (!$('#updatedDateOfBirth').val()) {
            alert(""Please enter a date of birth."");
            return false;
        }
        updateCandidateInfo();
    });
    function AppendRowAfterInsertRecord(row, ENumber, ENumberDate) {


        //Bind Country.
        $("".ENumber"", row).find(""span"").html(EN");
            WriteLiteral(@"umber);
        $("".ENumber"", row).find(""input"").val(ENumber);

        //Bind Country.
        $("".ENumberDate"", row).find(""span"").html(ENumberDate);
        $("".ENumberDate"", row).find(""input"").val(ENumberDate);
        debugger;
        row.find("".btnEdit"").show();
        row.find("".btnDelete"").show();
        $(""#datatables"").append(row);
    };

    //Edit event handler.
    $(""body"").on(""click"", ""#datatables .btnEdit"", function () {
        //debugger;
        var row = $(this).closest(""tr"");
        $(""td"", row).each(function () {
            if ($(this).find(""input"").length > 0) {
                $(this).find(""input"").show();
                $(this).find(""select"").show();
                $(this).find(""span"").hide();
            }
        });
        row.find("".btnUpdateStart"").show();
        row.find("".btnCancel"").show();
        row.find("".btnDelete"").hide();
        $(this).hide();
    });

    //Update event handler.
    $(""body"").on(""click"", ""#datatables .btnUpdateS");
            WriteLiteral(@"tart"", function () {
        var row = $(this).closest(""tr"");
        if (row.find("".ProcessingStartDate"").find(""input"").val()) {
            alert('please fill the field');
            return false;
        }
        $(""td"", row).each(function () {
            if ($(this).find(""input"")) {
                var span = $(this).find(""span"");
                var input = $(this).find(""input"");
                var select = $(this).find(""select"");
                span.html(input.val());
                span.show();
                select.hide();
                input.hide();
            }
        });
        row.find("".btnEdit"").show();
        row.find("".btnDelete"").show();
        row.find("".btnCancel"").hide();
        $(this).hide();
        var row = $(this).closest(""tr"");
        var statusId = $(row).find('select.startStatus').val();
        var Obj = {

            id: row.find("".visaProcessId"").find(""span"").html(),
            statusId: statusId,
            candidateId: row.find("".");
            WriteLiteral(@"CandidateIdStart"").find(""span"").html(),
            tradeId: row.find("".CanddiateTradeId"").val(),
            ProcessingStartDate: row.find(""input"").val(),
        };
        console.log(Obj);
        FileNumber = row.find("".FileNumber"").find(""span"").html();
        alert(FileNumber);
        $.ajax({
            type: ""POST"",
            url: '/Reports/UpdateProcessingTab',
            data: Obj,
            dataType: ""json"",
            success: function (data) {
                toastr.success('Record update successfully.', ""Alert"");
                window.location.href = '/Reports/TabReportForReloading?FileNumber=' + FileNumber;
                //$.ajax({
                //    type: ""GET"",
                //    url: '/Reports/TabReport',
                //    data: FileNumber,
                //    dataType: ""json"",
                //    success: function (data) {
                //        //('#datatable')
                //    },
                //    error: function (errormsg) {
 ");
            WriteLiteral(@"               //        toastr.success('Record update successfully.', ""Alert"");
                //    }
                //});
            },
            error: function (errormsg) {
                alert('Error');
            }
        });
        $(this).closest('tr').remove();


        ////$.ajax({
        //    type: ""POST"",
        //    data: JSON.stringify(Obj),
        //    url: '/Reports/UpdateVisaProcess',
        //    contentType: 'application/json',
        //    dataType: 'json',
        //    success: function (result) {
        //        ClearAllInput();
        //    },
        //    error: function (errormessage) {
        //        alert(errormessage.responseText);
        //    }
        //    error: function (errormsg) {
        //        prompt("""", JSON.stringify(errormsg))
        //    }
        //});
    });

    //Cancel event handler.
    $(""body"").on(""click"", ""#datatables .btnCancel"", function () {
        var row = $(this).closest(""tr"");
        $");
            WriteLiteral(@"(""td"", row).each(function () {
            if ($(this).find(""input"").length > 0) {
                var span = $(this).find(""span"");
                var input = $(this).find(""input"");
                input.val(span.html());
                span.show();
                input.hide();
            }
        });
        row.find("".btnEdit"").show();
        row.find("".btnDelete"").show();
        row.find("".btnUpdateStart"").hide();
        $(this).hide();
    });

    //Delete event handler.
    //$(""body"").on(""click"", ""#datatable .btnDelete"", function () {
    //    if (confirm(""Do you want to delete this row?"")) {
    //        var row = $(this).closest(""tr"");
    //        var FileNumber = row.find(""span"").html();
    //        $.ajax({
    //            url: ""/Reports/DeletePatient?FileNumber="" + FileNumber,
    //            type: ""POST"",
    //            contentType: ""application/json;charset=UTF-8"",
    //            dataType: ""json"",
    //            success: function (response) {
");
            WriteLiteral(@"    //                if ($(""#datatable tr"").length > 2) {
    //                    row.remove();
    //                } else {
    //                    row.find("".btnEdit"").hide();
    //                    row.find("".btnDelete"").hide();
    //                    row.find(""span"").html(' ');
    //                }
    //            }
    //        });
    //    }
    //});

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Luna.Recruitment.VisaProcessing.Data.DTO.ReportDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
