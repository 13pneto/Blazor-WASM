#pragma checksum "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc1185cc4d1b0271bc9abe650fc88c1a5c1dfd1"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_WebAssembly1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using Blazor_WebAssembly1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using Blazor_WebAssembly1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\_Imports.razor"
using Blazor_WebAssembly1.Entities;

#line default
#line hidden
#nullable disable
    public partial class Modal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor"
 if (ShowModal)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"modal-backdrop show\"></div>");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.AddAttribute(5, "aria-hidde", "true");
            __builder.AddAttribute(6, "style", "display: block;");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-header");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "modal-title");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor"
                                             ModalTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "data-dismiss", "modal");
            __builder.AddAttribute(22, "aria-label", "Close");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor"
                                                                                                          OnCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "modal-body");
            __builder.AddContent(28, 
#nullable restore
#line 16 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor"
                     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "modal-footer");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor"
                                                                            OnConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, 
#nullable restore
#line 19 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor"
                                                                                        ButtonConfirmText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "class", "btn btn-secondary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor"
                                                                              OnCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "data-dismiss", "modal");
            __builder.AddContent(43, "Fechar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Modal.razor"
       
    private bool ShowModal { get; set; } = false;

    [Parameter] public string ModalTitle { get; set; } = "Confirmação";
    [Parameter] public string ButtonConfirmText { get; set; } = "Confirmar";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public EventCallback OnConfirm { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }

    public void Show() => ShowModal = true;
    public void Hide() => ShowModal = false;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
