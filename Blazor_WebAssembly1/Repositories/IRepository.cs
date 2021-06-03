using Blazor_WebAssembly1.Entities;
using System.Collections.Generic;

namespace Blazor_WebAssembly1.Repositories
{
    public interface IRepository
    {
        List<Tarefa> GetTarefas();
    } 
}
