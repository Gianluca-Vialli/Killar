#pragma checksum "E:\Killar\Views\Users\_CommentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6b689e00e4deb8f96301eaa037ee7792e19ff0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__CommentList), @"mvc.1.0.view", @"/Views/Users/_CommentList.cshtml")]
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
#line 1 "E:\Killar\Views\_ViewImports.cshtml"
using Killar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Killar\Views\_ViewImports.cshtml"
using Killar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b689e00e4deb8f96301eaa037ee7792e19ff0f", @"/Views/Users/_CommentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2aebbec4851d18054b903206198c868fbf9425", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users__CommentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Comments>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Killar\Views\Users\_CommentList.cshtml"
 foreach (Comments c in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12 comment-container\">\r\n\r\n        <div class=\"row comment-head\">\r\n\r\n            <h5 class=\"ml-2\"><b>feito por: ");
#nullable restore
#line 10 "E:\Killar\Views\Users\_CommentList.cshtml"
                                      Write(c.Author.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> -</h5>\r\n\r\n            <p class=\"post-date\">");
#nullable restore
#line 12 "E:\Killar\Views\Users\_CommentList.cshtml"
                            Write(c.CommentDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n\r\n        <div class=\"text-justify  post-content\">\r\n\r\n            <p");
            BeginWriteAttribute("class", " class=\"", 399, "\"", 407, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "E:\Killar\Views\Users\_CommentList.cshtml"
                   Write(c.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n\r\n        <hr class=\"mb-4\">\r\n\r\n    </div>\r\n");
#nullable restore
#line 25 "E:\Killar\Views\Users\_CommentList.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Comments>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
