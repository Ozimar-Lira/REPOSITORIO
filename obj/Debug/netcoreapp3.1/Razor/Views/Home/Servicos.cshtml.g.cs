#pragma checksum "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "740966aac0ede016cde72bca8c84da44a85c5a37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Servicos), @"mvc.1.0.view", @"/Views/Home/Servicos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740966aac0ede016cde72bca8c84da44a85c5a37", @"/Views/Home/Servicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2972a7280bcbea6bf78e31b9a10507de4f982efd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Servicos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Loteamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Institucional", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Servicos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Loteamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">

        <div class=""header col-12"">
            <h1 style=""font-size:5vw; color:white;text-align:center;"">LOTEAMENTOS SANTA TERESA</h1>
            <p style="" font-size:3vw; color:white;text-align:center;"">Escolha o melhor local para construir sua casa.
            </p>
        </div>
        <div class=""topnav col-12"">
             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740966aac0ede016cde72bca8c84da44a85c5a375763", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740966aac0ede016cde72bca8c84da44a85c5a377135", async() => {
                WriteLiteral("Institucional");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740966aac0ede016cde72bca8c84da44a85c5a378516", async() => {
                WriteLiteral("Servicos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740966aac0ede016cde72bca8c84da44a85c5a379892", async() => {
                WriteLiteral("Cadastrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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

    <div class=""row"">
        <div class=""table.table-responsive"">
            <div class=""card"">
                <h2>Listagem de Loteamentos</h2>
                <table class=""table"">
                    <tr>
                        <th>Id</th>
                        <th>Nome Loteamento</th>
                        <th>Nome Cliente</th>
                        <th>CPF</th>
                        <th>Valor Lote</th>
                        <th>Entrada R$</th>
                        <th>Qtd Presta????es</th>
                        <th>Valor Presta????o</th>
                        <th>Data Contrato</th>
                        <th>Operacoes</th>

                    </tr>

");
#nullable restore
#line 42 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                     foreach (Loteamento l in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 45 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                           Write(l.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 46 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                           Write(l.Nome_Lote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                           Write(l.Nome_Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                           Write(l.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                           Write(l.Valor_Lote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 50 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                           Write(l.Entrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                           Write(l.Qtd_Parcelas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                           Write(l.Valor_Parcela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                           Write(l.Data_Contrato.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2149, "\"", 2183, 2);
            WriteAttributeValue("", 2156, "/Loteamento/Editar?Id=", 2156, 22, true);
#nullable restore
#line 55 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
WriteAttributeValue("", 2178, l.Id, 2178, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>|\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2233, "\"", 2268, 2);
            WriteAttributeValue("", 2240, "/Loteamento/Excluir?Id=", 2240, 23, true);
#nullable restore
#line 56 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
WriteAttributeValue("", 2263, l.Id, 2263, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                onclick=\"return confirm(\'Desesaja remover esse item?\');\">Remover</a>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa 05\Etapa No. 2\Views\Home\Servicos.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
