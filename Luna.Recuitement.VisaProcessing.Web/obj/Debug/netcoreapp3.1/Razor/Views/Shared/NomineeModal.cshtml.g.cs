#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\NomineeModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NomineeModal), @"mvc.1.0.view", @"/Views/Shared/NomineeModal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d", @"/Views/Shared/NomineeModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NomineeModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmNominee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    <a href=""#!"" class=""btn btn-primary float-right"" data-toggle=""modal"" onclick=""showNominee('N', this);"">Add</a>
    <div class=""modal fade"" id=""nomineeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""nomineeModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Nominee Detail</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d6058", async() => {
                WriteLiteral(@"
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"" style=""display:none;"">
                                <label>Id</label>
                                <input type=""hidden"" id=""nomineeId"" class=""form-control"" />
                            </div>

                            <div class=""form-group col-md-6"">
                                <label>First Name</label>
                                <input type=""text"" id=""nomineeFirstName"" max=""25"" required class=""form-control"" />
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Last Name</label>
                                <input type=""text"" id=""nomineeLastName"" max=""25"" required class=""form-control"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                    ");
                WriteLiteral(@"            <label>Arabic Name</label>
                                <input type=""text"" id=""arabicName"" class=""form-control ArabicEntry"" dir=""rtl"" lang=""ar"">
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Relationship</label>
                                <select id=""relationship"" class=""form-control "">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d7865", async() => {
                    WriteLiteral("Spouse");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d9447", async() => {
                    WriteLiteral("Father");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d10706", async() => {
                    WriteLiteral("Mother");
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
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d11966", async() => {
                    WriteLiteral("Brother");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d13227", async() => {
                    WriteLiteral("Sister");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label>Date Of Birth</label>
                                <input type=""date"" id=""dob"" class=""form-control"" />
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>CNIC</label>
                                <input type=""text"" id=""cnic"" class=""form-control"" pattern=""^\d{5}-\d{7}-\d{1}$"" required autocomplete=""off"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label>Gender</label>
                                <select id=""gender"" class=""form-control DDFilter"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d15497", async() => {
                    WriteLiteral("Male");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feeec4d4fc9372efe22bf89d2f5ffbea9a6633d17078", async() => {
                    WriteLiteral("Female");
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
                WriteLiteral("\r\n                                </select>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                    <button type=""button"" class=""btn btn-secondary"" id=""NomineebtnClose"">Close</button>
                    <button type=""button"" class=""btn btn-success"" id=""btnSaveNomineeModal"" onclick=""saveNominee()"">Save</button>
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
            <th>First Name</th>
            <th>Last Name</th>
            <th>Arabic Name</th>
            <th>Relationship</th>
            <th>DOB</th>
            <th>CNIC</th>
            <th></th>
        </tr>
    </thead>
    <tbody id=""nomineeDetail"">
    </tbody>
</table>
<script type=""text/javascript"">
        //function showNominee(type, button) {
        //    debugger;
        //    if (type == ""U"") {
        //        $(");
            WriteLiteral(@"""#nomineeId"").val($(button).closest('tr').children('td:nth(0)').text());
        //        $(""#nomineeFirstName"").val($(button).closest('tr').children('td:nth(1)').text());
        //        $(""#nomineeLastName"").val($(button).closest('tr').children('td:nth(2)').text());
        //        $(""#arabicName"").val($(button).closest('tr').children('td:nth(3)').text());
        //        $(""#relationship"").val($(button).closest('tr').children('td:nth(4)').text());
        //        document.getElementById(""dob"").valueAsDate = new Date($(button).closest('tr').children('td:nth(5)').text());
        //        $(""#cnic"").val($(button).closest('tr').children('td:nth(6)').text());
        //    }
        //    else  {
        //        debugger;
        //        $(""#nomineeId"").val(0);
        //        $(""#nomineeFirstName"").val("""")
        //        $(""#nomineeLastName"").val("""");
        //        $(""#arabicName"").val("""");
        //        $(""#relationship"").val("""");
        //        $(""#dob"").val("""")");
            WriteLiteral(@"
        //        $(""#cnic"").val("""")
        //        $(""#gender"").val(1)
        //    }
        //    $('#nomineeModal').modal('show');
        //}
        //function saveNominee() {

        //    debugger;
        //    var data = {
        //        ""id"": $(""#nomineeId"").val(),
        //        ""candidateProfileId"": $('.pkid').val(),
        //        ""firstName"": $(""#nomineeFirstName"").val(),
        //        ""lastName"": $(""#nomineeLastName"").val(),
        //        ""arabicName"": $(""#arabicName"").val(),
        //        ""relationship"": $(""#relationship"").val(),
        //        ""dob"": $(""#dob"").val(),
        //        ""cnic"": $(""#cnic"").val(),
        //        ""gender"": $(""#gender"").val()
        //    };
        //    //if (!$(""#nomineeFirstName"").val()) {
        //    //    alert(""First name is mandatory."");
        //    //    $(""#nomineeFirstName"").setCustomValidity(""First name should contian only characters!"");
        //    //    return false;
        //    //}
  ");
            WriteLiteral(@"      //    //if (!$(""#nomineeLastName"").val()) {
        //    //    alert(""Last name is mandatory."");
        //    //    $(""#nomineeLastName"").setCustomValidity(""Last name should contian only characters!"");
        //    //    return false;
        //    //}
        //    if (!$(""#cnic"").val()) {
        //        alert(""CNIC is mandatory."");
        //        $(""#cnic"").setCustomValidity(""CNIC should be in valid format.!"");
        //        return false;
        //    }
        //    if (!$(""#dob"").val()) {
        //        alert(""Date of birth is mandatory."");
        //        $(""#dob"").setCustomValidity(""DOB is mandatory."");
        //        return false;
        //    }
        //    //if (!document.forms['frmNominee'].reportValidity()) {
        //    //    if ($(""#nomineeLastName"").validity.typeMismatch) {
        //    //        $(""#nomineeLastName"").setCustomValidity(""Last name should contian only characters!"");
        //    //    }
        //    //    return false;
       ");
            WriteLiteral(@" //    //}
        //    $.ajax({
        //        type: ""POST"",
        //        url: '/CandidateProfile/UpdateNominee',
        //        data: data,
        //        dataType: ""json"",
        //        success: function (data) {
        //            toastr.success('Nominee added successfuly.')
        //            var html = '<tr>' +
        //                '<td style=""display:none;"">' + data.id + '</td>' +
        //                '<td>' + $('#nomineeFirstName').val() + '</td>' +
        //                '<td>' + $('#nomineeLastName').val() + '</td>' +
        //                '<td>' + $('#arabicName').val() + '</td>' +
        //                '<td>' + $('#relationship').val() + '</td>' +
        //                '<td>' + $('#dob').val() + '</td>' +
        //                '<td>' + $('#cnic').val() + '</td>' +
        //                '<td><a href=""#"" onclick=""showNominee(""U"",this)""><i class=""fas fa-edit""></i></a></td>' +
        //                '</tr>';
        //     ");
            WriteLiteral(@"       if ($('#nomineeId').val() == ""0"")
        //            {
        //                $('#nomineeDetail').append(html);
        //            } else {
        //                $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(1)').text($('#nomineeFirstName').val());
        //                $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(2)').text($('#nomineeLastName').val());
        //                $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(3)').text($('#arabicName').val());
        //                $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(4)').text($('#relationship').val());
        //                $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(5)').text($('#dob').val());
        //                $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(6)').text($('#cnic').val());                }
        //        },
        //        error: function () {
        //            toastr.error('while occured while saving no");
            WriteLiteral("minee.\')\r\n        //        }\r\n        //    });\r\n        //    return false;\r\n        //}\r\n    </script>\r\n\r\n");
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
