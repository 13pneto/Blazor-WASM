using Blazor_WebAssembly1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_WebAssembly1.Repositories
{
    public class Repository : IRepository
    {
        public List<Tarefa> GetTarefas()
        {
            return new List<Tarefa>()
            {
                new Tarefa
                {
                    ID = new Guid(Guid.NewGuid().ToString()),
                    Descricao = "Tarefa 1",
                    Concluida = false,
                    DataCriacao = DateTime.Now
                },
                new Tarefa
                {
                    ID = new Guid(Guid.NewGuid().ToString()),
                    Descricao = "Tarefa 1",
                    Concluida = false,
                    DataCriacao = Convert.ToDateTime("2019-12-30")
                }
            };
        }
    }
}
