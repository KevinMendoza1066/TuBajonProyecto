#pragma checksum "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcc3d56127e1e214dd3aee929d352dc59cc654f0"
// <auto-generated/>
#pragma warning disable 1591
namespace TuBajonUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using TuBajonUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\_Imports.razor"
using TuBajonUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Registro")]
    public partial class Registro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<link rel=""preconnect"" href=""https://fonts.googleapis.com"" b-a3h5o89fh0>
<link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin b-a3h5o89fh0>
<link href=""https://fonts.googleapis.com/css2?family=Tilt+Neon&display=swap"" rel=""stylesheet"" b-a3h5o89fh0>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddAttribute(3, "b-a3h5o89fh0");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row vh-100 p-5 justify-content-center");
            __builder.AddAttribute(6, "b-a3h5o89fh0");
            __builder.AddMarkupContent(7, @"<div id=""ImageLogin"" class=""col-sm-12 col-md-8 col-lg-4 p-5 text-center"" b-a3h5o89fh0><h1 b-a3h5o89fh0>Tu Bajon <strong style=""color:white"" b-a3h5o89fh0>SV</strong></h1>
            <img class=""m-4"" src=""images/registro.svg"" width=""200"" height=""200"" alt srcset b-a3h5o89fh0>
            <h4 class=""m-4 text-black"" b-a3h5o89fh0>Registrate</h4></div>
        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "id", "FormLogin");
            __builder.AddAttribute(10, "class", "col-sm-12 col-md-8 col-lg-4  shadow ");
            __builder.AddAttribute(11, "b-a3h5o89fh0");
            __builder.OpenComponent<Radzen.Blazor.RadzenTemplateForm<RegistroModel>>(12);
            __builder.AddAttribute(13, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<RegistroModel>(
#nullable restore
#line 18 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                            Registrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<RegistroModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<RegistroModel>(this, 
#nullable restore
#line 18 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                              OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "InvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.FormInvalidSubmitEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.FormInvalidSubmitEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                                      OnInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "class", "h-100 ");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenFieldset>(18);
                __builder2.AddAttribute(19, "Text", "Registro Tu Bajon");
                __builder2.AddAttribute(20, "class", "Field");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "row mb-5");
                    __builder3.AddAttribute(24, "b-a3h5o89fh0");
                    __builder3.OpenElement(25, "div");
                    __builder3.AddAttribute(26, "class", "col-md-4 ");
                    __builder3.AddAttribute(27, "b-a3h5o89fh0");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(28);
                    __builder3.AddAttribute(29, "Text", "Usuario");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\r\n                        ");
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "class", "col");
                    __builder3.AddAttribute(33, "b-a3h5o89fh0");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(34);
                    __builder3.AddAttribute(35, "style", "display: block");
                    __builder3.AddAttribute(36, "Name", "Usuario");
                    __builder3.AddAttribute(37, "class", "w-100");
                    __builder3.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                              Registrar.Nombre

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Registrar.Nombre = __value, Registrar.Nombre))));
                    __builder3.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Registrar.Nombre));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(42);
                    __builder3.AddAttribute(43, "Component", "Usuario");
                    __builder3.AddAttribute(44, "Text", "Campo es requerido");
                    __builder3.AddAttribute(45, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                                          popup

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "Style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n                    ");
                    __builder3.OpenElement(48, "div");
                    __builder3.AddAttribute(49, "class", "row mb-5");
                    __builder3.AddAttribute(50, "b-a3h5o89fh0");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-4 ");
                    __builder3.AddAttribute(53, "b-a3h5o89fh0");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Text", "Contraseña");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\r\n                        ");
                    __builder3.OpenElement(57, "div");
                    __builder3.AddAttribute(58, "class", "col");
                    __builder3.AddAttribute(59, "b-a3h5o89fh0");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(60);
                    __builder3.AddAttribute(61, "style", "display: block");
                    __builder3.AddAttribute(62, "Name", "Contrasenia");
                    __builder3.AddAttribute(63, "class", "w-100");
                    __builder3.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                                   Registrar.Contrasenia

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Registrar.Contrasenia = __value, Registrar.Contrasenia))));
                    __builder3.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Registrar.Contrasenia));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(68);
                    __builder3.AddAttribute(69, "Component", "Contrasenia");
                    __builder3.AddAttribute(70, "Text", "Campo es requerido");
                    __builder3.AddAttribute(71, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                                              popup

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "Style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\r\n                    ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "class", "row mb-5");
                    __builder3.AddAttribute(76, "b-a3h5o89fh0");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col-md-4 ");
                    __builder3.AddAttribute(79, "b-a3h5o89fh0");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(80);
                    __builder3.AddAttribute(81, "Text", "Repetir Contraseña");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\r\n                        ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "class", "col");
                    __builder3.AddAttribute(85, "b-a3h5o89fh0");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(86);
                    __builder3.AddAttribute(87, "style", "display: block");
                    __builder3.AddAttribute(88, "Name", "RepContrasenia");
                    __builder3.AddAttribute(89, "class", "w-100");
                    __builder3.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                                      Registrar.RepContrasenia

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Registrar.RepContrasenia = __value, Registrar.RepContrasenia))));
                    __builder3.AddAttribute(92, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Registrar.RepContrasenia));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(94);
                    __builder3.AddAttribute(95, "Component", "RepContrasenia");
                    __builder3.AddAttribute(96, "Text", "Campo es requerido");
                    __builder3.AddAttribute(97, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                                                 popup

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(98, "Style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCompareValidator>(100);
                    __builder3.AddAttribute(101, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                              !string.IsNullOrEmpty(Registrar.RepContrasenia)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 52 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                                                      Registrar.Contrasenia

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(103, "Component", "RepContrasenia");
                    __builder3.AddAttribute(104, "Text", "Contraseñas deben ser iguales");
                    __builder3.AddAttribute(105, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                                                                                                                                                   popup

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "Style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(107, "\r\n                    ");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "class", "row mb-3");
                    __builder3.AddAttribute(110, "b-a3h5o89fh0");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-4 ");
                    __builder3.AddAttribute(113, "b-a3h5o89fh0");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(114);
                    __builder3.AddAttribute(115, "Text", "Correo Electrónico");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\r\n                        ");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "col");
                    __builder3.AddAttribute(119, "b-a3h5o89fh0");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(120);
                    __builder3.AddAttribute(121, "style", "display: block");
                    __builder3.AddAttribute(122, "Name", "Correo");
                    __builder3.AddAttribute(123, "class", "w-100");
                    __builder3.AddAttribute(124, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                             Registrar.Correo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(125, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Registrar.Correo = __value, Registrar.Correo))));
                    __builder3.AddAttribute(126, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Registrar.Correo));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(127, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(128);
                    __builder3.AddAttribute(129, "Component", "Correo");
                    __builder3.AddAttribute(130, "Text", "Campo es requerido");
                    __builder3.AddAttribute(131, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                                                                         popup

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(132, "Style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenEmailValidator>(134);
                    __builder3.AddAttribute(135, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 64 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                                         popup

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(136, "Component", "Correo");
                    __builder3.AddAttribute(137, "Text", "Ingrese un email valido ");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(138, "\r\n                    \r\n                    ");
                    __builder3.OpenElement(139, "div");
                    __builder3.AddAttribute(140, "class");
                    __builder3.AddAttribute(141, "b-a3h5o89fh0");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLink>(142);
                    __builder3.AddAttribute(143, "Path", "/");
                    __builder3.AddAttribute(144, "Text", "Ya tienes cuenta? Ingresa desde acá");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(145, "\r\n\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(146);
                    __builder3.AddAttribute(147, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 73 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
                                              ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(148, "Text", "Ingresar");
                    __builder3.AddAttribute(149, "class", "rz-danger");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\USER\Source\Repos\TuBajonProyecto\TuBajonUI\Pages\Registro.razor"
               
            bool popup = true;

            RegistroModel Registrar = new RegistroModel();


            void Log(string eventName, string value)
            {

            }

            void OnSubmit(RegistroModel Ingreso)
            {

            }

            void OnInvalidSubmit(FormInvalidSubmitEventArgs args)
            {

            }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
