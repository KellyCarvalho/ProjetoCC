#pragma checksum "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c61fa8b79f3205d910245d4f5694cdb3784b358e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Cliente), @"mvc.1.0.view", @"/Views/Gestao/Cliente.cshtml")]
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
#line 1 "C:\Users\Kelly Carvalho\projetocc\Views\_ViewImports.cshtml"
using projetos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kelly Carvalho\projetocc\Views\_ViewImports.cshtml"
using projetos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c61fa8b79f3205d910245d4f5694cdb3784b358e", @"/Views/Gestao/Cliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"714cb9faff6a0a8af863b352349015eb452619f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Cliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projetos.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
  

    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<h2>Clientes</h2>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c61fa8b79f3205d910245d4f5694cdb3784b358e4276", async() => {
                WriteLiteral("Novo Cliente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<hr />
<script>

    $(document).ready(function () {
        $('#clientes').DataTable();
    });
</script>








<table id=""clientes"" class=""table table-striped table-bordered"" style=""width:100%"""">

    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Telefone</th>
            <th>Cidade</th>
            <th>Observacoes</th>
            <!--
    <th>Bairro</th>
    <th>CPF</th>
    <th>Ações</th>-->

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 47 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
         foreach (var cliente in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
           Write(cliente.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
           Write(cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
           Write(cliente.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
           Write(cliente.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <!--\r\n    <td>");
#nullable restore
#line 55 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
   Write(cliente.Observacoes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 56 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
   Write(cliente.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 57 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
   Write(cliente.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>-->\r\n\r\n\r\n\r\n\r\n            <td>\r\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1127, "\"", 1167, 2);
            WriteAttributeValue("", 1134, "/Gestao/EditarCliente/", 1134, 22, true);
#nullable restore
#line 63 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
WriteAttributeValue("", 1156, cliente.ID, 1156, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n\r\n\r\n\r\n                <form style=\"display: inline;\" asp-controller=\"Cliente\" asp-action=\"Deletar\">\r\n                    <input type=\"hidden\" name=\"id\" id=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1340, "\"", 1359, 1);
#nullable restore
#line 68 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
WriteAttributeValue("", 1348, cliente.ID, 1348, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <button class=\"btn btn-danger\">Deletar</button>\r\n                </form>\r\n\r\n                <form style=\"display: inline;\" asp-controller=\"Gestao\" asp-action=\"GerarOS\">\r\n                    <input type=\"hidden\" name=\"id\" id=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1611, "\"", 1630, 1);
#nullable restore
#line 73 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
WriteAttributeValue("", 1619, cliente.ID, 1619, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <button class=\"btn btn-success\">Gerar OS</button>\r\n\r\n                </form>\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Cliente.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<projetos.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
