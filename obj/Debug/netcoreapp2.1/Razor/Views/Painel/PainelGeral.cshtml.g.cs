#pragma checksum "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7596612fd5b2db21c0dfd5905ed703b299013469"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Painel_PainelGeral), @"mvc.1.0.view", @"/Views/Painel/PainelGeral.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Painel/PainelGeral.cshtml", typeof(AspNetCore.Views_Painel_PainelGeral))]
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
#line 1 "C:\Dev\Painel\RelatoriosWeb\Views\_ViewImports.cshtml"
using RelatoriosWeb;

#line default
#line hidden
#line 2 "C:\Dev\Painel\RelatoriosWeb\Views\_ViewImports.cshtml"
using RelatoriosWeb.Models;

#line default
#line hidden
#line 1 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7596612fd5b2db21c0dfd5905ed703b299013469", @"/Views/Painel/PainelGeral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e35d188b2773f722c997f0b76470afbf6f40be2", @"/Views/_ViewImports.cshtml")]
    public class Views_Painel_PainelGeral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<RelatoriosWeb.Models.Painel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Painel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RelatorioErros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Painel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmpresasAtivas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsEmp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(91, 679, true);
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-dark bg-primary"">
    <center class=""nomenav"">Monitoramento de Notas Fiscais Eletrônicas</center>
    <div class=""container"">
        <div class=""navbar-header"">
            <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                <span class=""sr-only"">Toggle navigation</span>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
            </button>
        </div>
        <div class=""navbar-collapse collapse"">
            <ul class=""nav navbar-nav"">
                <li>");
            EndContext();
            BeginContext(770, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b9edc5e036248bf97b35a159480572c", async() => {
                BeginContext(816, 4, true);
                WriteLiteral("Home");
                EndContext();
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
            EndContext();
            BeginContext(824, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(851, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aef0cb9b7b4e432ca63404fa655d8603", async() => {
                BeginContext(906, 15, true);
                WriteLiteral("Notas Com Erros");
                EndContext();
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
            EndContext();
            BeginContext(925, 64, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 25 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
  
    ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(1182, 115, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-inverse-expand-lg navbar-dark bg-primary\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(1297, 656, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92334e2c32d54944b2812032c8eb5cec", async() => {
                BeginContext(1349, 220, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"minDate\">\r\n                    <span>Dt Inicial</span>\r\n                </label>\r\n                <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1569, "", 1596, 1);
#line 38 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
WriteAttributeValue("", 1576, ViewData["minDate"], 1576, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1596, 201, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"maxDate\"><span>Dt Final</span></label>\r\n                <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1797, "", 1824, 1);
#line 42 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
WriteAttributeValue("", 1804, ViewData["maxDate"], 1804, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1824, 122, true);
                WriteLiteral(" />\r\n            </div>\r\n            <button type=\"submit\" id=\"filtrar\" class=\"btn btn-success\">Filtrar</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1953, 138, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"panel panel-default\">\r\n    <ul class=\"nav nav-pills\">\r\n        <li role=\"presentation\" class=\"active\">");
            EndContext();
            BeginContext(2091, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "512d23c020ad4c39a0bd58df361dce25", async() => {
                BeginContext(2114, 16, true);
                WriteLiteral("Painel Detalhado");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2134, 56, true);
            WriteLiteral("</li>\r\n\r\n        <li role=\"presentation\" class=\"active\">");
            EndContext();
            BeginContext(2190, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9ef51b95cb4425a8dbbc875fe183edd", async() => {
                BeginContext(2221, 15, true);
                WriteLiteral("Empresas Ativas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2240, 317, true);
            WriteLiteral(@"</li>

        <li role=""presentation"" onCLick=""window.open('https://www.nfe.fazenda.gov.br/portal/disponibilidade.aspx?versao=0.00&tipoConteudo=Skeuqr8PQBY=','_blank');"" class=""active""><a>Consultar Status Receita</a></li>
    </ul>
</div>



<tr>
    <td>
        <span>
            Listando registros de ");
            EndContext();
            BeginContext(2558, 21, false);
#line 64 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                             Write(Model.FirstItemOnPage);

#line default
#line hidden
            EndContext();
            BeginContext(2579, 16, true);
            WriteLiteral("\r\n            a ");
            EndContext();
            BeginContext(2596, 20, false);
#line 65 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
         Write(Model.LastItemOnPage);

#line default
#line hidden
            EndContext();
            BeginContext(2616, 16, true);
            WriteLiteral(" de um total de ");
            EndContext();
            BeginContext(2633, 20, false);
#line 65 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                                              Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(2653, 825, true);
            WriteLiteral(@"
        </span>
    </td>
</tr>

<div class=""panel panel-primary"">
    <div class=""panel-heading"">
    </div>
    <div class=""panel-body"">
        <table class=""table table-hover"">
            <thead>
                <tr class=""active"">
                    <th>
                        Cnpj
                    </th>
                    <th>
                        Série
                    </th>
                    <th>
                        Data
                    </th>
                    <th>
                        Nota
                    </th>
                    <th>
                        Retorno
                    </th>
                    <th>
                        Movimento
                    </th>
                </tr>
            </thead>
            <tbody>

");
            EndContext();
#line 99 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3543, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3628, 39, false);
#line 103 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                       Write(Html.DisplayFor(modelItem => item.cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(3667, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3697, 182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca09743fa35412ea3d61409fd52425a", async() => {
                BeginContext(3784, 91, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-home\"></i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cnpj", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 105 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                                   WriteLiteral(item.cnpj);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cnpj"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cnpj", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cnpj"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3879, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3971, 43, false);
#line 110 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                       Write(Html.DisplayFor(modelItem => item.nr_serie));

#line default
#line hidden
            EndContext();
            BeginContext(4014, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4106, 45, false);
#line 113 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                       Write(Html.DisplayFor(modelItem => item.dt_termino));

#line default
#line hidden
            EndContext();
            BeginContext(4151, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4243, 43, false);
#line 116 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                       Write(Html.DisplayFor(modelItem => item.nfnumero));

#line default
#line hidden
            EndContext();
            BeginContext(4286, 63, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 119 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                             if (item.status == "E")
                            {
                                

#line default
#line hidden
            BeginContext(4467, 109, false);
#line 121 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                           Write(Html.TextBoxFor(m => item.retorno, new { @style = "color: red;", @class = "form-control", @readonly = true }));

#line default
#line hidden
            EndContext();
#line 121 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                                                                                                                                              
                            }
                            else
                            {
                                

#line default
#line hidden
            BeginContext(4707, 114, false);
#line 125 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                           Write(Html.TextBoxFor(model => item.retorno, new { @class = "form-control", @style = "width:400px;", @readonly = true }));

#line default
#line hidden
            EndContext();
#line 125 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                                                                                                                                                   
                            }

#line default
#line hidden
            BeginContext(4854, 89, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4944, 44, false);
#line 129 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                       Write(Html.DisplayFor(modelItem => item.movimento));

#line default
#line hidden
            EndContext();
            BeginContext(4988, 121, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5109, 331, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ef0841fcfab449db47def358b96c473", async() => {
                BeginContext(5364, 72, true);
                WriteLiteral("\r\n                                Detalhar\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cnpj", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 134 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                                   WriteLiteral(item.cnpj);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cnpj"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cnpj", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cnpj"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 135 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                                       WriteLiteral(item.nfnumero);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nfnumero"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-nfnumero", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nfnumero"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 136 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                                         WriteLiteral(item.dt_termino);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dt_termino"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dt_termino", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dt_termino"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5440, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 141 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
                }

#line default
#line hidden
            BeginContext(5519, 130, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"row\">\r\n                <span class=\"pull-right\">\r\n                    ");
            EndContext();
            BeginContext(5650, 93, false);
#line 146 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\PainelGeral.cshtml"
               Write(Html.PagedListPager(Model, page => Url.Action("PainelGeral", new { page, minDate, maxDate })));

#line default
#line hidden
            EndContext();
            BeginContext(5743, 171, true);
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n<style>\r\n    .nomenav {\r\n        padding-top: 50px;\r\n        font-size: 20px;\r\n    }\r\n</style>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<RelatoriosWeb.Models.Painel>> Html { get; private set; }
    }
}
#pragma warning restore 1591