#pragma checksum "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\ViewComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4a4cb207b3e8af7761aab3b615ebbdd23714a30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_ViewComment), @"mvc.1.0.view", @"/Views/Comment/ViewComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4a4cb207b3e8af7761aab3b615ebbdd23714a30", @"/Views/Comment/ViewComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_ViewComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.CommentModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\ViewComment.cshtml"
   ViewData["Title"] = "ViewComment"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewComment</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayFor(model => model.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.CommentModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
