using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazor_WebAssembly1.Services;
using Blazor_WebAssembly1.Repositories;
using Blazored.LocalStorage;

namespace Blazor_WebAssembly1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<Singleton>();
            builder.Services.AddScoped<Scoped>();
            builder.Services.AddTransient<Transient>();
            builder.Services.AddTransient<IRepositoryProduct, RepositoryProduct>();
            builder.Services.AddBlazoredLocalStorage();
            
            
            builder.Services.AddScoped<IRepository, Repository>();

            await builder.Build().RunAsync();
        }
    }
}
