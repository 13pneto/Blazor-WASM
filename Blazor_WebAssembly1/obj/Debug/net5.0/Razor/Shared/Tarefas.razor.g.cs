#pragma checksum "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f6820f3e30ae43900d1063dd1f136847dfc7ad"
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
    public partial class Tarefas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 2 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
     Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 4 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
 if (!tarefas.Any())
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazor_WebAssembly1.Shared.Alerta>(2);
            __builder.AddAttribute(3, "Mensagem", "Erro ao consultar tarefas");
            __builder.AddAttribute(4, "TipoAlerta", "alert alert-danger");
            __builder.CloseComponent();
#nullable restore
#line 7 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
}
else if (tarefas == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazor_WebAssembly1.Shared.Alerta>(5);
            __builder.AddAttribute(6, "Mensagem", "Ainda não há tarefas cadastradas");
            __builder.AddAttribute(7, "TipoAlerta", "alert alert-danger");
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th scope=\"col\">Ações</th>\r\n            <th scope=\"col\">Data</th>\r\n            <th scope=\"col\">Descrição</th>\r\n            <th scope=\"col\">Concluida</th></tr></thead>\r\n    ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 23 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
         foreach (var item in tarefas)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenComponent<Blazor_WebAssembly1.Shared.TarefaIndividual>(13);
            __builder.AddAttribute(14, "item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor_WebAssembly1.Entities.Tarefa>(
#nullable restore
#line 26 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
                                        item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "RemoverTarefa", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazor_WebAssembly1.Entities.Tarefa>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazor_WebAssembly1.Entities.Tarefa>(this, 
#nullable restore
#line 26 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
                                                             RemoveTarefa

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
 if (tarefas != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.AddMarkupContent(18, "<label>Tarefa</label>\r\n        ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "placeholder", "Informe a tarefa");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
                                                                 novaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => novaTarefa = __value, novaTarefa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
                                                  AdicionarNovaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Adicionar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
       


    [Parameter] public string Titulo { get; set; } = "Tarefas";
    [Parameter] public List<Tarefa> tarefas { get; set; }

    private string novaTarefa;

    private void AdicionarNovaTarefa()
    {
        if (!VerificaTarefaJaExiste(novaTarefa) && !String.IsNullOrWhiteSpace(novaTarefa))
        {
            Tarefa tarefa = new Tarefa();
            tarefa.Concluida = false;
            tarefa.DataCriacao = DateTime.Now;
            tarefa.Descricao = novaTarefa;

            tarefas.Add(tarefa);
            novaTarefa = "";
        }
    }

    private void RemoveTarefa(Tarefa tarefa)
    {
        tarefas.Remove(tarefa);
    }

    private bool VerificaTarefaJaExiste(string tarefaDescricao)
    {
        Tarefa t = tarefas.Find(e => e.Descricao.Equals(tarefaDescricao, StringComparison.CurrentCultureIgnoreCase));
        Console.WriteLine(t == null ? false : true);
        return t == null ? false : true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
