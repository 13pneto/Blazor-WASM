using Blazor_WebAssembly1.Entities;
using Blazor_WebAssembly1.Repositories;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_WebAssembly1.Pages
{
    public class Tarefas2020Base: ComponentBase
    {
        [Inject] IRepository repository { get; set; }

        protected List<Tarefa> tarefas = new List<Tarefa>();

        protected override void OnInitialized()
        {
            tarefas = repository.GetTarefas();
        }

        protected List<Tarefa> GetTarefas()
        {
            return tarefas;
        }
    }
}
