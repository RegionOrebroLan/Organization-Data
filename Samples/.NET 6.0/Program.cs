using Microsoft.EntityFrameworkCore;
using RegionOrebroLan.Organization.Data;
using RegionOrebroLan.Organization.Data.Builder;
using RegionOrebroLan.Organization.Data.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddSqliteDatabaseContext(options => options.UseSqlite(builder.Configuration.GetConnectionString("Database")));
builder.Services.AddScoped<DatabaseContextBase>(serviceProvider => serviceProvider.GetRequiredService<SqliteDatabaseContext>());

var app = builder.Build();

app.UseSqliteDatabaseContext();
app.UseRouting();
app.MapRazorPages();

app.Run();