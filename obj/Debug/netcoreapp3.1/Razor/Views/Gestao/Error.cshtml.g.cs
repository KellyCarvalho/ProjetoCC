#pragma checksum "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeb01138e62409c3be64b13789ac85b6f0bb1a1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Error), @"mvc.1.0.view", @"/Views/Gestao/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb01138e62409c3be64b13789ac85b6f0bb1a1a", @"/Views/Gestao/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"714cb9faff6a0a8af863b352349015eb452619f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Kelly Carvalho\projetocc\Views\Gestao\Error.cshtml"
  

    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""error"" value=""1"">
    <script>

        alert('Ação não pôde ser concluída');
    </script>

    <span>Existe  ordem de serviço ativas com este serviço inserido para corrigir delete a OS ou mude o nome do serviço na OS</span>


    <button class=""btn-light"" href=""/Gestao/OS"">Voltar Para OS</button>
    <button class=""btn-light"" href=""/Gestao/Cliente"">Ir para Clientes</button>
</div>");
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
