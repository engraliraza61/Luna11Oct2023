#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_vaccineModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84e40509cc361a4908b944e2e2dbdfabbbe0e3c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__vaccineModal), @"mvc.1.0.view", @"/Views/Shared/_vaccineModal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84e40509cc361a4908b944e2e2dbdfabbbe0e3c1", @"/Views/Shared/_vaccineModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__vaccineModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "First", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Second", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Booster", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div>
    <a href=""#!"" class=""btn btn-primary float-right"" data-toggle=""modal"" onclick=""showVaccine('N',this)"" ;>Add</a>
    <div class=""modal fade"" id=""vaccineModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""vaccineModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Vaccine Detail</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84e40509cc361a4908b944e2e2dbdfabbbe0e3c15149", async() => {
                WriteLiteral(@"
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"" style=""display:none;"">
                                <label>Id</label>
                                <input type=""hidden"" id=""vaccineId"" class=""form-control"" />
                            </div>
                            <div class=""form-group col-md-12"">
                                <label>Type</label>
                                <select id=""vaccineType"" class=""form-control DDFilter""></select>
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Variant</label>
                                <select id=""vaccineVariant"" class=""form-control DDFilter""></select>
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Dose</label>
                                <select id=""vaccineDose"" class=""form-control DDFilter""");
                WriteLiteral(">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84e40509cc361a4908b944e2e2dbdfabbbe0e3c16534", async() => {
                    WriteLiteral("First");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84e40509cc361a4908b944e2e2dbdfabbbe0e3c18115", async() => {
                    WriteLiteral("Second");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84e40509cc361a4908b944e2e2dbdfabbbe0e3c19374", async() => {
                    WriteLiteral("Booster");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Date</label>
                                <input type=""date"" id=""vaccineDate"" required class=""form-control"" />
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Validity</label>
                                <input type=""date"" id=""vaccineValidity"" required class=""form-control"">
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" id=""closeVaccineModal"" class=""btn btn-secondary"">Close</button>
                    <button type=""button"" class=""btn btn-success"" id=""VaccinebtnSave"" onclick=""saveVaccine()"">Save</button>
                </div>
                <div id=""show_stored_data"">

                </div>

            </div>
        </div>
    </div>

</div>
<table class=""table"">
    <thead>
        <tr>
            <th style=""display:none;"">Record Id (PK)</th>
            <th>Type</th>
            <th>Variant</th>
            <th>Dose</th>
            <th>Date</th>
            <th>Validity</th>
            <th></th>
        </tr>
    </thead>
    <tbody id=""vaccineDetail"">
    </tbody>
</table>

<script type=""text/javascript"">
    //function showVaccine(type,button) {
    //    if (type == ""U"") {
    //        $(""#vaccineId"").val($(button).closest('tr').children('td:nth(0)').text());
    //    ");
            WriteLiteral(@"    $(""#vaccineType"").val($(button).closest('tr').children('td:nth(1)').text());
    //        $(""#vaccineVariant"").val($(button).closest('tr').children('td:nth(2)').text());
    //        $(""#vaccineDose"").val($(button).closest('tr').children('td:nth(3)').text());
    //        document.getElementById(""VaccineDate"").valueAsDate = new Date($(button).closest('tr').children('td:nth(4)').text());
    //        document.getElementById(""VaccineValidity"").valueAsDate = new Date($(button).closest('tr').children('td:nth(5)').text());
    //    }
    //    else //(type == ""N"") {
    //    {
    //        debugger;
    //        $(""#vaccineId"").val(0);
    //        $(""#vaccineType"").val(""0"")
    //        $(""#vaccineVariant"").val(""0"");
    //        $(""#vaccineDose"").val(""First"");
    //        $(""#vaccineDate"").val("""");
    //        $(""#vaccineValidity"").val("""");
    //    }
    //    $('#vaccineModal').modal('show');
    //}
    //function saveVaccine() {
    //    var data = {
    //        ""id");
            WriteLiteral(@""": $(""#vaccineId"").val(),
    //        ""candidateProfileId"": $("".pkid"").val(),
    //        ""vaccineType"": $(""#sponserId"").val(),
    //        ""vaccineVariant"": $(""#vaccineCenterName"").val(),
    //        ""vaccineDose"": $(""#ghccodeNo"").val(),
    //        ""vaccineDate"": $(""#dateExamined"").val(),
    //        ""vaccineValidity"": $(""#reportExpiryDate"").val()
    //    };
    //    //if (!$(""#dateExamined"").val()) {
    //    //    alert(""Date Examined is mandatory."");
    //    //    return false;
    //    //}
    //    //if (!$(""#reportExpiryDate"").val()) {
    //    //    alert(""Expiry Date is mandatory."");
    //    //    return false;
    //    //}
    //    $.ajax({
    //        type: ""POST"",
    //        url: '/CandidateProfile/UpdateVaccine',
    //        data: data,
    //        dataType: ""json"",

    //        success: function (data) {
    //            toastr.success('vaccine record saved successfully.', ""Alert"")
    //            var html = '<tr>' +
    //         ");
            WriteLiteral(@"       '<td style=""display:none;"">' + data.id + '</td>' +
    //                '<td>' + $('#vaccineType').val() + '</td>' +
    //                '<td>' + $('#vaccineVariant').val() + '</td>' +
    //                '<td>' + $('#vaccineDose').val() + '</td>' +
    //                '<td>' + $('#vaccineDate').val() + '</td>' +
    //                '<td>' + $('#vaccineValidity').val() + '</td>' +
    //                '<td><a href=""#!""  onclick=""ShowDialog(\'U\',this);""><i class=""fas fa-edit""></i></a><a href=""#"" onclick=""deleteVaccine(' + data.id +')""><i class=""fas fa-trash""></i></a></td>' +
    //                '</tr>';
    //            if ($('#vaccineId').val() == ""0"") {
    //                $('#vaccineDetail').append(html);
    //            } else {
    //                //$(""#vaccineRow"" + $('#vaccineId').val()).children('td:nth(2)').text($('#sponserId option:selected').text());
    //                $(""#vaccineRow"" + $('#vaccineId').val()).children('td:nth(1)').text($('#vaccineType').val(");
            WriteLiteral(@"));
    //                $(""#vaccineRow"" + $('#vaccineId').val()).children('td:nth(2)').text($('#vaccineVariant').val());
    //                $(""#vaccineRow"" + $('#vaccineId').val()).children('td:nth(3)').text($('#vaccineDose').val());
    //                $(""#vaccineRow"" + $('#vaccineId').val()).children('td:nth(4)').text($('#vaccineDate').val());
    //                $(""#vaccineRow"" + $('#vaccineId').val()).children('td:nth(5)').text($('#vaccineValidity').val());
    //            }
    //        },
    //        error: function () {
    //            toastr.error('Error occured while saving vaccine record.', ""Error"")
    //        }
    //    });

    //    return false;
    //}
    //function deleteVaccine(vaccineId) {
    //    var data = { ""Id"": vaccineId };
    //    if (confirm(""Are you sure to delete this vaccine info?"")) {
    //        if (!vaccineId || vaccineId == ""0"") {
    //            //Remove line from table only.
    //            $(""#vaccineRow"" + vaccineId).remove(");
            WriteLiteral(@");
    //        }
    //        else {
    //            $.ajax({
    //                type: ""POST"",
    //                url: '/CandidateProfile/DeleteVaccine',
    //                data: data,
    //                dataType: ""json"",
    //                success: function (data) {
    //                    toastr.success('vaccine info deleted.')
    //                    $(""#vaccineRow"" + vaccineId).remove();
    //                },
    //                error: function () {
    //                    toastr.error('while occured while deleting vaccine info.')
    //                }
    //            });
    //        }
    //    }
    //    return false;
    //}
</script>

");
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
