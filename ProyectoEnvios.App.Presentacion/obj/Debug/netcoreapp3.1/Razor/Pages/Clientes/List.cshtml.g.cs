#pragma checksum "C:\projects\ProyectoEnvios.App\TEAM\ProyectoEnvios.App.Presentacion\Pages\Clientes\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfd31c51451a6dbf32f7425a9a8f60314d328f3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoEnvios.App.Presentacion.Pages.Clientes.Pages_Clientes_List), @"mvc.1.0.razor-page", @"/Pages/Clientes/List.cshtml")]
namespace ProyectoEnvios.App.Presentacion.Pages.Clientes
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
#line 1 "C:\projects\ProyectoEnvios.App\TEAM\ProyectoEnvios.App.Presentacion\Pages\_ViewImports.cshtml"
using ProyectoEnvios.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfd31c51451a6dbf32f7425a9a8f60314d328f3a", @"/Pages/Clientes/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9bdc8c618bef45170b18ff5bc0c272d42a72cdd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de Clientes</h1>\r\n<button>Revisar estado de pedido</button>\r\n<button>Hacer pedido</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoEnvios.App.Presentacion.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoEnvios.App.Presentacion.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoEnvios.App.Presentacion.ListModel>)PageContext?.ViewData;
        public ProyectoEnvios.App.Presentacion.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
