#pragma checksum "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "799b91b1c98ec97fd8d4ee77f09b99b8944fbc24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_jogos_list), @"mvc.1.0.view", @"/views/jogos/list.cshtml")]
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
#line 1 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"799b91b1c98ec97fd8d4ee77f09b99b8944fbc24", @"/views/jogos/list.cshtml")]
    public class views_jogos_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
  
    Layout = "layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom\">\r\n    <h1 class=\"h2\">Jogos Cadastrados</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
 if (ViewData["Message"] is string Message){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\r\n        ");
#nullable restore
#line 12 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
   Write(Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive\">\r\n\r\n    <a href=\"/jogos/insert\" class=\"btn btn-dark\">Adicionar Novo Jogo</a>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
     if (ViewData["Data"] is DataTable data && data.Rows.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped table-sm"">
            <thead>
                <tr>
                    <th>Nome</th>
                    <th>Categoria</th>
                    <th>Já Joguei?</th>
                    <th>Editar</th>
                    <th>Excluir</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 33 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
             foreach (DataRow Registry in data.Rows){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 35 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
                    Write(Registry["Nome"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 36 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
                    Write(Registry["Categoria"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 37 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
                     Write(Registry["Joguei"].ToString() == "1" ? "Sim" : "Não");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1243, "\"", 1293, 2);
            WriteAttributeValue("", 1250, "/jogos/edit/", 1250, 12, true);
#nullable restore
#line 39 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
WriteAttributeValue("", 1262, Registry["id_jogo"].ToString(), 1262, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1386, "\"", 1438, 2);
            WriteAttributeValue("", 1393, "/jogos/delete/", 1393, 14, true);
#nullable restore
#line 42 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
WriteAttributeValue("", 1407, Registry["id_jogo"].ToString(), 1407, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 48 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> Nenhum Jogo Cadastrado! </p>\r\n");
#nullable restore
#line 52 "C:\Users\Andre\Documents\Projetos\catalogo-jogos\src\views\jogos\list.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
