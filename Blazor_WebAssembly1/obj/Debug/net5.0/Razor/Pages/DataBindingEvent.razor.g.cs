#pragma checksum "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Pages\DataBindingEvent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e197df0fa589079b9f1753281a971d24db208ac1"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_WebAssembly1.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/databinding-event")]
    public partial class DataBindingEvent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DataBindingEvent</h3>\r\n\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Pages\DataBindingEvent.razor"
     Mensagem

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "<label>Event onChange</label>\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "placeholder", "Digite a mensagem...");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Pages\DataBindingEvent.razor"
                                                                           Mensagem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Mensagem = __value, Mensagem));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label>Event onInput</label>\r\n    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "placeholder", "Digite a mensagem...");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Pages\DataBindingEvent.razor"
                                                                           Mensagem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Mensagem = __value, Mensagem));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Pages\DataBindingEvent.razor"
       
    public string Mensagem { get; set; } = "Mensagem";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
