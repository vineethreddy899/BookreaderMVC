#pragma checksum "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\GetComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "925956a514d2717074907e5d5f4f6024ec592c4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_GetComments), @"mvc.1.0.view", @"/Views/Comment/GetComments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925956a514d2717074907e5d5f4f6024ec592c4e", @"/Views/Comment/GetComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_GetComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.CommentModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\GetComments.cshtml"
   ViewData["Title"] = "FetchComment"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 8 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\GetComments.cshtml"
           Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\GetComments.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\GetComments.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n   \r\n                <td>\r\n                    ");
#nullable restore
#line 22 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\GetComments.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\GetComments.cshtml"
               Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n   \r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\VINEETH\Desktop\CompanyN\Web\Views\Comment\GetComments.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.CommentModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591