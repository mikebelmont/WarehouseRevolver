using MudBlazor.Services;
using WarehouseRevolver.Components;
using WarehouseRevolver.Database.helper;
using WarehouseRevolver.Database;
using WarehouseRevolver.UseCases.databasePlugin;
using WarehouseRevolver.UseCases.interfaces;
using WarehouseRevolver.UseCases;


var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// interface
builder.Services.AddTransient<IP21DataAccess>(sp => new P21DataAccess(builder.Configuration.GetConnectionString("P21")));
builder.Services.AddTransient<IRepositoryP21, RepositoryP21>();

// P21
builder.Services.AddTransient<IReadbel_warehouse_revolver_readytopickUseCase, Readbel_warehouse_revolver_readytopickUseCase>();
builder.Services.AddTransient<IReadWarehouseActivityUseCase, ReadWarehouseActivityUseCase>();
builder.Services.AddTransient<IReadbelWirelessTransactionsDailyUseCase, ReadbelWirelessTransactionsDailyUseCase>();
builder.Services.AddTransient<IReadtotalweightUseCase, ReadtotalweightUseCase>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
