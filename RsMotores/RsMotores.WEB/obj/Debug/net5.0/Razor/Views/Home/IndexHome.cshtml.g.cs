#pragma checksum "C:\Users\21550\Desktop\RsMotores\RsMotores.WEB\Views\Home\IndexHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093c6b37737893e0390bd64ad21b936d2ed943af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexHome), @"mvc.1.0.view", @"/Views/Home/IndexHome.cshtml")]
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
#line 1 "C:\Users\21550\Desktop\RsMotores\RsMotores.WEB\Views\_ViewImports.cshtml"
using RsMotores.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\21550\Desktop\RsMotores\RsMotores.WEB\Views\_ViewImports.cshtml"
using RsMotores.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093c6b37737893e0390bd64ad21b936d2ed943af", @"/Views/Home/IndexHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e173621eea024fc620804c64a2adbbeebca619", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RsMotores.WEB.Models.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h1");
            BeginWriteAttribute("style", " style=\"", 77, "\"", 105, 2);
            WriteAttributeValue("", 85, "color:", 85, 6, true);
#nullable restore
#line 6 "C:\Users\21550\Desktop\RsMotores\RsMotores.WEB\Views\Home\IndexHome.cshtml"
WriteAttributeValue("", 91, ViewBag.Color, 91, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"display-4\">Seja Bem Vindo!!</h1>\r\n    <p>Bem vindo ");
#nullable restore
#line 7 "C:\Users\21550\Desktop\RsMotores\RsMotores.WEB\Views\Home\IndexHome.cshtml"
            Write(Model.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RsMotores.WEB.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
