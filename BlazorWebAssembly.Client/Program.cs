using BlazorWebAssembly.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shop.Shared.Configuration;
using Shop.Shared.Services.ProdcutService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var appSettings = builder.Configuration.GetSection(nameof(AppSettings));
var appSettingsSection = appSettings.Get<AppSettings>();

var uriBuilder = new UriBuilder(appSettingsSection.BaseApiUrl)
{
    Path = appSettingsSection.ProductEndpoint.BaseUrl,
};

builder.Services.Configure<AppSettings>(appSettings);

builder.Services.AddHttpClient<IProductService, ProductService>(client=>client.BaseAddress = uriBuilder.Uri);

await builder.Build().RunAsync();
