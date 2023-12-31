#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6411153ec71a2ab7e810b903e0f2221aa216522c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CandidateSelection_ProtectorList), @"mvc.1.0.view", @"/Views/CandidateSelection/ProtectorList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6411153ec71a2ab7e810b903e0f2221aa216522c", @"/Views/CandidateSelection/ProtectorList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_CandidateSelection_ProtectorList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Luna.Recruitment.VisaProcessing.Data.Models.VisaProcess>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CandidateSelection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Protector", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
  
    ViewData["Title"] = "Protector List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div ");
            WriteLiteral(@">
    <h1>Visa Stamping List</h1>
    <hr />
    
    <div class=""panel panel-info"">
        <div class=""panel-body"">
            <table class=""table datatableHideFirstThree"" id=""tableSelectionList"" style=""border:2px solid black"">
                <thead>
                    <tr>
                        <th style=""display:none;"" id=""tdCandidateSelectionDetailId"">CandidateSelectionDetailId</th>
                        <th style=""display:none;"" id=""tdCandidateSelectionId"">CandidateSelectionId</th>
                        <th style=""display:none;"" id=""tdCandidateProfileId"">CandidateProfileId</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Father Name</th>
                        <th>Passport</th>
                        <th>CNIC</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody id=""tbSelection"">
");
#nullable restore
#line 28 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td style=\"display:none;\">");
#nullable restore
#line 31 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                                                 Write(item.CandidateSelectionDetail.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"display:none;\">");
#nullable restore
#line 32 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                                                 Write(item.CandidateSelectionDetail.CandidateSelectionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"display:none;\">");
#nullable restore
#line 33 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                                                 Write(item.CandidateSelectionDetail.CandidateProfileId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                           Write(item.CandidateSelectionDetail.CandidateProfile.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                           Write(item.CandidateSelectionDetail.CandidateProfile.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                           Write(item.CandidateSelectionDetail.CandidateProfile.FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                                 if (@item.CandidateSelectionDetail.CandidateProfile.Passport != null && item.CandidateSelectionDetail.CandidateProfile.Passport.Any())
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                               Write(item.CandidateSelectionDetail.CandidateProfile.Passport.FirstOrDefault().PassportNo);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                                                                                                                        ;
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                                Write("N/A");

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                                            
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>");
#nullable restore
#line 48 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                           Write(item.CandidateSelectionDetail.CandidateProfile.Cnic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6411153ec71a2ab7e810b903e0f2221aa216522c10178", async() => {
                WriteLiteral("<i class=\"fas fa-umbrella\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-candidateSelectionDetailId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                                                                                                                        WriteLiteral(item.CandidateSelectionDetail.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["candidateSelectionDetailId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-candidateSelectionDetailId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["candidateSelectionDetailId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 53 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 60 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\CandidateSelection\ProtectorList.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Luna.Recruitment.VisaProcessing.Data.Models.VisaProcess>> Html { get; private set; }
    }
}
#pragma warning restore 1591
