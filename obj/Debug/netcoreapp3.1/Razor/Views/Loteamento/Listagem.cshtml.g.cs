#pragma checksum "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "880e369087c3c256c34f9a513613c8f5bf37fd15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loteamento_Listagem), @"mvc.1.0.view", @"/Views/Loteamento/Listagem.cshtml")]
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
#line 1 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\_ViewImports.cshtml"
using Etapa_No._2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\_ViewImports.cshtml"
using Etapa_No._2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880e369087c3c256c34f9a513613c8f5bf37fd15", @"/Views/Loteamento/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2972a7280bcbea6bf78e31b9a10507de4f982efd", @"/Views/_ViewImports.cshtml")]
    public class Views_Loteamento_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Loteamento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
  
  ViewData["Title"] = "Listagem de Loteamentos";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive-sm"">
  <table class=""table"">
    <tr>
      <th>Id</th>
      <th>Nome Loteamento</th>
      <th>Nome Cliente</th>
      <th>CPF</th>
      <th>Valor Lote</th>
      <th>Entrada R$</th>
      <th>Qtd Prestações</th>
      <th>Valor Prestação</th>
      <th>Data Contrato</th>
      <th>Operações</th>

    </tr>

");
#nullable restore
#line 24 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
     foreach (Loteamento l in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
       Write(l.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
       Write(l.Nome_Lote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
       Write(l.Nome_Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
       Write(l.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
       Write(l.Valor_Lote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
       Write(l.Entrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
       Write(l.Qtd_Parcelas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
       Write(l.Valor_Parcela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
       Write(l.Data_Contrato.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td>\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 831, "\"", 865, 2);
            WriteAttributeValue("", 838, "/Loteamento/Editar?Id=", 838, 22, true);
#nullable restore
#line 38 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
WriteAttributeValue("", 860, l.Id, 860, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>|\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 893, "\"", 928, 2);
            WriteAttributeValue("", 900, "/Loteamento/Excluir?Id=", 900, 23, true);
#nullable restore
#line 39 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
WriteAttributeValue("", 923, l.Id, 923, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Desesaja remover esse item?\');\">Remover</a>\r\n        </td>\r\n\r\n      </tr>\r\n");
#nullable restore
#line 43 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Loteamento\Listagem.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </table>\r\n</div>  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Loteamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
