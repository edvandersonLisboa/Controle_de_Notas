
using Applications.Queries.GetAllNotaFiscalQueries;
using Applications.Services;
using Applications.Services.Interfaces;
using Controle_de_notas.Controller;
using Data.Context;
using Data.Repositories;
using Domain.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Shared.Handles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "ControleDeNotaFiscal.db");
// Add services to the container.
builder.Services.AddDbContext<AppSqlLiteContext>(options =>
                   options.UseSqlite($"Data Source={dbPath}"));

builder.Services.AddScoped<NotaFiscalController>();
builder.Services.AddScoped<NotaFiscalController>();
builder.Services.AddScoped<INotaFiscalService, NotaFiscalService>();
builder.Services.AddScoped<INotaFiscalRepository, NotaFiscalRepository>();

builder.Services.AddScoped<IQueryHandler<GetAllNotaFiscalQuery, GetAllNotaFiscalQueryResult>, GetAllNotaFiscalQueryHandler>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
