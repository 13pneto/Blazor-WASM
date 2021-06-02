using Blazor_WebAssembly1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_WebAssembly1.Repositories
{
    interface IRepository
    {
        List<Tarefa> GetTarefas();
    }
}
