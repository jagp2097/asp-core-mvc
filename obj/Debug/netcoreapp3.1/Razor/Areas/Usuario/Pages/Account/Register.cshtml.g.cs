#pragma checksum "/home/jagp/Desktop/aspcoremvc/usuarios/Areas/Usuario/Pages/Account/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63590b9bb1c8cab3adae9c176e877e7a14667685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(usuarios.Areas.Usuario.Pages.Account.Account.Areas_Usuario_Pages_Account_Register), @"mvc.1.0.razor-page", @"/Areas/Usuario/Pages/Account/Register.cshtml")]
namespace usuarios.Areas.Usuario.Pages.Account.Account
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
#line 1 "/home/jagp/Desktop/aspcoremvc/usuarios/Areas/Usuario/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Usuario/Register/{data?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63590b9bb1c8cab3adae9c176e877e7a14667685", @"/Areas/Usuario/Pages/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb13fa8f47d993564de560b49fb151dc9593f65b", @"/Areas/Usuario/Pages/_ViewImports.cshtml")]
    public class Areas_Usuario_Pages_Account_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "/home/jagp/Desktop/aspcoremvc/usuarios/Areas/Usuario/Pages/Account/Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Register</h1>\n\n<h5>");
#nullable restore
#line 11 "/home/jagp/Desktop/aspcoremvc/usuarios/Areas/Usuario/Pages/Account/Register.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel>)PageContext?.ViewData;
        public RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591