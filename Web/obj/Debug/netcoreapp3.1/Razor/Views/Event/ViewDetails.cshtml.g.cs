#pragma checksum "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe9a6db0763ff81f102e27a6793d69e3c73faef2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_ViewDetails), @"mvc.1.0.view", @"/Views/Event/ViewDetails.cshtml")]
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
#line 1 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9a6db0763ff81f102e27a6793d69e3c73faef2", @"/Views/Event/ViewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Event_ViewDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.EventModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
  
    ViewData["Title"] = "View Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12"" align=""center"">
    <div class=""card mb-12 shadow-sm"" style=""width: 50%;"" align=""center"">
        <img class=""bd-placeholder-img card-img-top"" width=""100"" height=""225"" src=""https://www.austinmacauley.com/us/sites/default/files/amanda_friedman_read_aloud_at_the_monessori_schools_-_flatiron_pic_1_0.jpg"" alt=""Card image cap"">
        <div class=""card-body"">
            <h3 class=""card-title font-weight-bold text-dark"">");
#nullable restore
#line 12 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n            <div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                 if (Model.Description != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <p class=\"card-text\"> <p class=\"text-info d-inline\">Description :</p> ");
#nullable restore
#line 19 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                                                         Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 21 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <p class=\"card-text\"> <p class=\"text-info d-inline\">Venue</p> : ");
#nullable restore
#line 23 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                                               Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div>\r\n                    <p class=\"card-text\"> <p class=\"text-info d-inline\">Event Date</p> : ");
#nullable restore
#line 27 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                                                    Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div>\r\n                    <p class=\"card-text\"> <p class=\"text-info d-inline\">Start Time :</p> ");
#nullable restore
#line 31 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                                                    Write(Model.Date.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                 if (Model.Duration != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <p class=\"card-text\"> <p class=\"text-info d-inline\">Duration :</p> ");
#nullable restore
#line 36 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                                                      Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hrs\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                 if (Model.Invitees != null)
                {
                    var count = Model.Invitees.Split(',').Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <p class=\"card-text\"> <p class=\"text-info d-inline\">Total Invitees :</p> ");
#nullable restore
#line 44 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                                                            Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div>It\'s a <p class=\"font-weight-bold d-inline text-info\">");
#nullable restore
#line 52 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                                          Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>Event</div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div>Organised by <p class=\"font-weight-bold d-inline text-info\">");
#nullable restore
#line 55 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                                                Write(Model.Organiser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                </div>\r\n            </div>\r\n            <p></p>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9a6db0763ff81f102e27a6793d69e3c73faef210677", async() => {
                WriteLiteral("<p class=\"font-weight-bold d-inline\">Back to Event Page</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <p></p>\r\n\r\n    <hr style=\"height:2px; width:80%; border-width:0; color:black; background-color:black\">\r\n    <div class=\"container\">\r\n        <div class=\"col-md-12\" align=\"center\" style=\"width: 50%;\">\r\n");
#nullable restore
#line 69 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
             using (Html.BeginForm("PostComment", "Comment", new { EventId = Model.Id }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-group"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <textarea class=""form-control""  name =""Comments"" id=""Comments"" placeholder=""Post Comments here....."" rows=""5""></textarea>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9a6db0763ff81f102e27a6793d69e3c73faef213066", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 75 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comments);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>

                </div>
                <div class=""form-group"">
                    <div class=""col-sm-offset-2 col-sm-10"">
                        <button class=""btn btn-success btn-circle text-uppercase"" type=""submit"" value=""Post"" id=""submitComment""><span class=""glyphicon glyphicon-send""></span> Post comment</button>
                    </div>
                </div>
");
#nullable restore
#line 85 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 90 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
     if (@Model.Comments.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4 class=\"display-4 text-dark \">Previous Comments!!</h4>\r\n");
#nullable restore
#line 93 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
         foreach (var i in Model.Comments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""container"">
                <div class=""card mb-12 shadow-sm"" style=""width: 50%;"" align=""center"">
                    <div class=""container"">
                        <div class=""col-12"">
                            <p class=""font-weight-bold"">");
#nullable restore
#line 99 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                   Write(i.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <small align=\"right\" class=\"text-muted\">");
#nullable restore
#line 103 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
                                                   Write(i.TimeStamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 106 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Event\ViewDetails.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.EventModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
