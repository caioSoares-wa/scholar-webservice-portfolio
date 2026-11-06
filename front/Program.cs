using front;
using front.Services;
using front.StateContainers;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5266") });
//adicionando DI 
builder.Services.AddScoped<LoginService>();
builder.Services.AddScoped<UsuarioStateContainer>();
builder.Services.AddScoped<ResumoHomeService>();



await builder.Build().RunAsync();
