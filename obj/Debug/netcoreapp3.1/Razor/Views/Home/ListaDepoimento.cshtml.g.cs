#pragma checksum "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "905f4f26c28d0a88c72348322f6a526881e2e7ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaDepoimento), @"mvc.1.0.view", @"/Views/Home/ListaDepoimento.cshtml")]
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
#line 1 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\_ViewImports.cshtml"
using ProjetoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\_ViewImports.cshtml"
using ProjetoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905f4f26c28d0a88c72348322f6a526881e2e7ab", @"/Views/Home/ListaDepoimento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9614e30ac05eda474dd37096940e5ebaae5c83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaDepoimento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Depoimento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
  
    ViewData["Title"] = "Lista de Depoimentos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--<div class=\"Depoimentos\">\r\n");
#nullable restore
#line 7 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
     foreach (Depoimento d in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"Depoimento-box\">\r\n                                                    <p>");
#nullable restore
#line 10 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
                                                  Write(d.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p>");
#nullable restore
#line 11 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
                                                  Write(d.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p>\"");
#nullable restore
#line 12 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
                                                   Write(d.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</p>\r\n                                                </div>\r\n");
#nullable restore
#line 14 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>-->\r\n");
#nullable restore
#line 16 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
 foreach (Depoimento d in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-group\" style=\"padding-top: 10px;\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 21 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
                                  Write(d.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 22 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
                                Write(d.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">");
#nullable restore
#line 23 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
                                Write(d.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 27 "E:\Users\leand\Documents\TI Senac\Projeto_Integrador\ProjetoMVC\Views\Home\ListaDepoimento.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Depoimento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
