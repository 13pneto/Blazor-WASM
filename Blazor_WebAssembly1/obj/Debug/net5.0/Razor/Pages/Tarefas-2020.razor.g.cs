#pragma checksum "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Pages\Tarefas-2020.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ba81ec4fb211ddb5b84a1693e8e10e9afb4276"
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
#nullable restore
#line 2 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Pages\Tarefas-2020.razor"
using Blazor_WebAssembly1.Repositories;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tarefas")]
    public partial class Tarefas_2020 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazor_WebAssembly1.Shared.Tarefas>(0);
            __builder.AddAttribute(1, "tarefas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Blazor_WebAssembly1.Entities.Tarefa>>(
#nullable restore
#line 5 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Pages\Tarefas-2020.razor"
                  GetTarefas()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Titulo", "Tarefas-2020");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Pages\Tarefas-2020.razor"
       

    private List<Tarefa> tarefas = new List<Tarefa>();

    protected override void OnInitialized()
    {
        tarefas = repository.GetTarefas();
    }

    private List<Tarefa> GetTarefas()
    {
        return tarefas;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
