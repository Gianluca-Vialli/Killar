#pragma checksum "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68b3d6ef55a7eb0e884553d03fa73c9d95493723"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserProfile), @"mvc.1.0.view", @"/Views/Users/UserProfile.cshtml")]
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
#line 1 "C:\Users\Ufo\Desktop\Killar\Views\_ViewImports.cshtml"
using Killar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ufo\Desktop\Killar\Views\_ViewImports.cshtml"
using Killar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68b3d6ef55a7eb0e884553d03fa73c9d95493723", @"/Views/Users/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2aebbec4851d18054b903206198c868fbf9425", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Users>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_UserDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
  
    ViewData["Title"] = "Seu Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68b3d6ef55a7eb0e884553d03fa73c9d954937234070", async() => {
                WriteLiteral("\r\n\r\n    <main role=\"main\"");
                BeginWriteAttribute("class", " class=\"", 121, "\"", 129, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 10 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
         foreach (Users u in Model)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container col-md-8 profileContainer p-5 border-primary\">\r\n\r\n                <h1 class=\" text-center mb-4\">Olá ");
#nullable restore
#line 15 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
                                             Write(u.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@", <span> este são seus dados.</span></h1>

                <hr class=""mb-4 mt-3"">

                <img class=""rounded-circle mb-2 border-primary"" src=""../images/perfil.png"" alt=""Imagem de perfil"">

                <div class="" mt-3 mb-3"">

                    <a class=""btn btn-md btn-primary buttonProfile""");
                BeginWriteAttribute("href", " href=\"", 640, "\"", 678, 2);
                WriteAttributeValue("", 647, "/Users/UserProfileEdit?Id=", 647, 26, true);
#nullable restore
#line 23 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 673, u.Id, 673, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i\r\n                        class=\"fa-solid fa-user-pen\"></i> Editar Perfil</a>\r\n\r\n                    <button type=\"button\" data-toggle=\"modal\" class=\"btn btn-md btn-primary buttonProfile\" data-target=\"#exampleModalCenter-");
#nullable restore
#line 26 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
                                                                                                                                       Write(u.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"><i class=\"fa-solid fa-user-xmark\"></i> Excluir Perfil</button>\r\n\r\n                    <!--Start UserDelete Modal-->\r\n\r\n                <div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 1068, "\"", 1097, 2);
                WriteAttributeValue("", 1073, "exampleModalCenter-", 1073, 19, true);
#nullable restore
#line 30 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 1092, u.Id, 1092, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog""
                    aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">

                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">

                            <div class=""modal-content"">

                                <div class=""modal-header"">

                                    <h1 class=""modal-title text-danger text-center bold"" id=""exampleModalLongTitle"">Alerta!
                                    </h1>

                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">

                                        <span aria-hidden=""true"">&times;</span>

                                    </button>

                                </div>

                                <div class=""modal-body"">

                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68b3d6ef55a7eb0e884553d03fa73c9d954937237960", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 52 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = u;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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

                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                                </div>

                            </div>

                        </div>

                    </div>

                    <!--Finish UserDelete Modal-->

            </div>

                <hr class=""mb-4"">

                <div class=""row"">

                    <div class=""col-md-6"">

                        <label");
                BeginWriteAttribute("for", " for=\"", 2624, "\"", 2630, 0);
                EndWriteAttribute();
                WriteLiteral(">Nome:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2698, "\"", 2719, 1);
#nullable restore
#line 79 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 2712, u.Name, 2712, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 2766, "\"", 2772, 0);
                EndWriteAttribute();
                WriteLiteral(">Nick Wr(aaaa#0000):</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2854, "\"", 2878, 1);
#nullable restore
#line 82 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 2868, u.LoginWr, 2868, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 2925, "\"", 2931, 0);
                EndWriteAttribute();
                WriteLiteral(">Nick Name</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3003, "\"", 3029, 1);
#nullable restore
#line 85 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 3017, u.LoginName, 3017, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 3076, "\"", 3082, 0);
                EndWriteAttribute();
                WriteLiteral(">Data de Nascimento:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3164, "\"", 3213, 1);
#nullable restore
#line 88 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 3178, u.BirthDate.ToString("dd/MM/yyyy"), 3178, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                    </div>\r\n\r\n                    <div class=\" col-md-6\">\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 3337, "\"", 3343, 0);
                EndWriteAttribute();
                WriteLiteral(">Sua senha:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3416, "\"", 3448, 1);
#nullable restore
#line 95 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 3430, u.CheckedPassword, 3430, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 3495, "\"", 3501, 0);
                EndWriteAttribute();
                WriteLiteral(">Elo Atual:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3574, "\"", 3594, 1);
#nullable restore
#line 98 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 3588, u.Elo, 3588, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 3641, "\"", 3647, 0);
                EndWriteAttribute();
                WriteLiteral(">Lane Principal:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3725, "\"", 3746, 1);
#nullable restore
#line 101 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 3739, u.Lane, 3739, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 3793, "\"", 3799, 0);
                EndWriteAttribute();
                WriteLiteral(">Tipo:</label>\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3867, "\"", 3899, 1);
#nullable restore
#line 104 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"
WriteAttributeValue("", 3881, u.Tipo.ToString(), 3881, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 112 "C:\Users\Ufo\Desktop\Killar\Views\Users\UserProfile.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </main>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Users>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
