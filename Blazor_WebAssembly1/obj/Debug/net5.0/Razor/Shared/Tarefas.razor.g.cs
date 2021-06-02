#pragma checksum "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2456376e4996f2d348f93e1bd9cbbdf9da194be6"
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
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, @"<div class=""card"" style=""width: 18rem;""><img class=""card-img-top"" src=""https://semantic-ui.com/images/wireframe/image.png"" alt=""Card image cap"">
        <div class=""card-body""><h5 class=""card-title"">Não há tarefas cadastradas.</h5>
            <p class=""card-text"">Após cadastrar tarefas, elas serão apresentadas. Favor cadastrar uma tarefa.</p></div></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
}
else if (tarefas == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazor_WebAssembly1.Shared.Alerta>(7);
            __builder.AddAttribute(8, "Mensagem", "Ainda não há tarefas cadastradas");
            __builder.AddAttribute(9, "TipoAlerta", "alert alert-danger");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, @"<div class=""card"" style=""width: 18rem;""><img class=""card-img-top"" src=""https://semantic-ui.com/images/wireframe/image.png"" alt=""Card image cap"">
            <div class=""card-body""><h5 class=""card-title"">Não há tarefas cadastradas.</h5>
                <p class=""card-text"">Após cadastrar tarefas, elas serão apresentadas. Favor cadastrar uma tarefa.</p></div></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "<thead><tr><th scope=\"col\">Ações</th>\r\n            <th scope=\"col\">Data</th>\r\n            <th scope=\"col\">Descrição</th>\r\n            <th scope=\"col\">Concluida</th></tr></thead>\r\n    ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 39 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
         foreach (var item in tarefas)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
            __builder.OpenComponent<Blazor_WebAssembly1.Shared.TarefaIndividual>(17);
            __builder.AddAttribute(18, "item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor_WebAssembly1.Entities.Tarefa>(
#nullable restore
#line 42 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
                                        item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "RemoverTarefa", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazor_WebAssembly1.Entities.Tarefa>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazor_WebAssembly1.Entities.Tarefa>(this, 
#nullable restore
#line 42 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
                                                             RemoveTarefa

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
 if (tarefas != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "<label>Tarefa</label>\r\n        ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "placeholder", "Informe a tarefa");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
                                                                 novaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => novaTarefa = __value, novaTarefa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
                                                  AdicionarNovaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Adicionar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Pedro\source\repos\Blazor_WebAssembly1\Blazor_WebAssembly1\Shared\Tarefas.razor"
       


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
