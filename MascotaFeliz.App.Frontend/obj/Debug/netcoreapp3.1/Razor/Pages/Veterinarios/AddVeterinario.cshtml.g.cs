#pragma checksum "C:\Mascotas2\mascotaFeliz\MascotaFeliz.App.Frontend\Pages\Veterinarios\AddVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a49f8daaac5ee285924de9fbd62660abe115f817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_AddVeterinario), @"mvc.1.0.razor-page", @"/Pages/Veterinarios/AddVeterinario.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Veterinarios
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
#line 1 "C:\Mascotas2\mascotaFeliz\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49f8daaac5ee285924de9fbd62660abe115f817", @"/Pages/Veterinarios/AddVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_AddVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container_16"">
    <div class=""wrapper"">

        <div>
            <section class=""FormularioVeterinario"">
                <h4>Registrar Veterinario</h4>
                <input class=""controls"" type=""int"" name=""Id"" id=""Id"" placeholder=""Ingrese su Cedula"">
                <input class=""controls"" type=""text"" name=""Nombre"" id=""Nombre"" placeholder=""Ingrese su Nombre"">
                <input class=""controls"" type=""text"" name=""Apellidos"" id=""Apellidos"" placeholder=""Ingrese Apellidos"">
                <input class=""controls"" type=""text"" name=""Direccion"" id=""Direccion"" placeholder=""Ingrese su Direccion"">
                <input class=""controls"" type=""text"" name=""Telefono"" id=""Telefono"" placeholder=""Ingrese Telefono"">
                <input class=""controls"" type=""text"" name=""TarjetaProfesional"" id=""TarjetaProfesional"" placeholder=""Ingrese Tarjeta Profesional"">
        
                <p>Estoy de acuerdo con <a href=""#"">Terminos y Condiciones</a></p>
                <input class=""botons"" ty");
            WriteLiteral("pe=\"submit\" value=\"Registrar\">\r\n                <p><a href=\"#\">??Ya tengo Cuenta?</a></p>\r\n            </section>\r\n        </div>\r\n    </div><!--the end of wrapper-->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.AddVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.AddVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.AddVeterinarioModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.AddVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
