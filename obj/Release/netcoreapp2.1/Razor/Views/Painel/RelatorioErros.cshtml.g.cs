#pragma checksum "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef9d42a6cdf1d1cbf6a68f3ee0296728e48c0ecc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Painel_RelatorioErros), @"mvc.1.0.view", @"/Views/Painel/RelatorioErros.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Painel/RelatorioErros.cshtml", typeof(AspNetCore.Views_Painel_RelatorioErros))]
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
#line 1 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9d42a6cdf1d1cbf6a68f3ee0296728e48c0ecc", @"/Views/Painel/RelatorioErros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e35d188b2773f722c997f0b76470afbf6f40be2", @"/Views/_ViewImports.cshtml")]
    public class Views_Painel_RelatorioErros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<RelatoriosWeb.Models.Painel_Nfe>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Painel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Painel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RelatorioErrosDetalhe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RelatorioErrosDetalheCnpj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsEmp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(95, 683, true);
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-dark bg-primary"">
    <div class=""container"">
        <center class=""nomenav"">Monitoramento de Notas Fiscais Eletr??nicas</center>
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
            BeginContext(778, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1497c67985654254ad525fbc78e8863d", async() => {
                BeginContext(836, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(844, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(871, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c988713b11434e61ae58634c4c4672cb", async() => {
                BeginContext(930, 14, true);
                WriteLiteral("Todas as Notas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(948, 64, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 25 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
  
    ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);
    string ccnpj = ViewData["cnpjBusca"] as string;

#line default
#line hidden
            BeginContext(1258, 107, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-expand-lg navbar-dark bg-primary\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(1365, 904, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad663d04394d408db6729fca54c34a12", async() => {
                BeginContext(1417, 230, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\"><span>Dt Inicial</span></label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1647, "", 1674, 1);
#line 38 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
WriteAttributeValue("", 1654, ViewData["minDate"], 1654, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1674, 217, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\"><span>Dt Final</span></label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1891, "", 1918, 1);
#line 42 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
WriteAttributeValue("", 1898, ViewData["maxDate"], 1898, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1918, 182, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <span>Cnpj</span>\r\n                    <input type=\"text\" class=\"form-control\" name=\"ccnpj\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 2100, "", 2129, 1);
#line 46 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
WriteAttributeValue("", 2107, ViewData["cnpjBusca"], 2107, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2129, 133, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-success\">Filtrar</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2269, 138, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"panel panel-default\">\r\n    <ul class=\"nav nav-pills\">\r\n        <li role=\"presentation\" class=\"active\">");
            EndContext();
            BeginContext(2407, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55f8a6475a2443fca9d21932b8a63d30", async() => {
                BeginContext(2445, 22, true);
                WriteLiteral("Totalizadores de Erros");
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
            BeginContext(2471, 140, true);
            WriteLiteral("</li>\r\n    </ul>\r\n</div>\r\n<div class=\"panel panel-default\">\r\n    <ul class=\"nav nav-pills\">\r\n        <li role=\"presentation\" class=\"active\">");
            EndContext();
            BeginContext(2611, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c6a0d026af1486198ddb039f6570289", async() => {
                BeginContext(2653, 31, true);
                WriteLiteral("Totalizadores de Erros Por Cnpj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2688, 94, true);
            WriteLiteral("</li>\r\n    </ul>\r\n</div>\r\n\r\n<tr>\r\n    <td>\r\n        <span>\r\n            Listando registros de ");
            EndContext();
            BeginContext(2783, 21, false);
#line 68 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
                             Write(Model.FirstItemOnPage);

#line default
#line hidden
            EndContext();
            BeginContext(2804, 16, true);
            WriteLiteral("\r\n            a ");
            EndContext();
            BeginContext(2821, 20, false);
#line 69 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
         Write(Model.LastItemOnPage);

#line default
#line hidden
            EndContext();
            BeginContext(2841, 16, true);
            WriteLiteral(" de um total de ");
            EndContext();
            BeginContext(2858, 20, false);
#line 69 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
                                              Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(2878, 430, true);
            WriteLiteral(@"
        </span>
    </td>
</tr>

<table class=""table table-hover"">
    <thead>
        <tr class=""active"">
            <th>
                Cnpj
            </th>
            <th>
                Data Emiss??o
            </th>
            <th>
                Nota
            </th>
            <th>
                Retorno
            </th>

            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 94 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(3357, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3418, 39, false);
#line 98 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
               Write(Html.DisplayFor(modelItem => item.cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(3457, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3479, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da68860f31d444acad159cab93442fb9", async() => {
                BeginContext(3558, 75, true);
                WriteLiteral("\r\n                        <i class=\"fas fa-home\"></i>\r\n                    ");
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
#line 100 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
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
            BeginContext(3637, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3705, 45, false);
#line 105 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
               Write(Html.DisplayFor(modelItem => item.dt_termino));

#line default
#line hidden
            EndContext();
            BeginContext(3750, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3818, 43, false);
#line 108 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
               Write(Html.DisplayFor(modelItem => item.nfnumero));

#line default
#line hidden
            EndContext();
            BeginContext(3861, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3929, 42, false);
#line 111 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
               Write(Html.DisplayFor(modelItem => item.retorno));

#line default
#line hidden
            EndContext();
            BeginContext(3971, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 114 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"

        }

#line default
#line hidden
            BeginContext(4028, 84, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"row\">\r\n    <span class=\"pull-right\">\r\n        ");
            EndContext();
            BeginContext(4113, 103, false);
#line 121 "C:\Dev\Painel\RelatoriosWeb\Views\Painel\RelatorioErros.cshtml"
   Write(Html.PagedListPager(Model, page => Url.Action("RelatorioErros", new { minDate, maxDate , ccnpj, page})));

#line default
#line hidden
            EndContext();
            BeginContext(4216, 119, true);
            WriteLiteral("\r\n    </span>\r\n</div>\r\n\r\n<style>\r\n    .nomenav {\r\n        padding-top: 50px;\r\n        font-size: 20px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<RelatoriosWeb.Models.Painel_Nfe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
