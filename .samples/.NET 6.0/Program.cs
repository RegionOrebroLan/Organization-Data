using Microsoft.EntityFrameworkCore;
using RegionOrebroLan.Organization.Data;
using RegionOrebroLan.Organization.Data.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddSqliteOrganizationContext(options => options.UseSqlite(builder.Configuration.GetConnectionString("Organization")), ServiceLifetime.Transient, ServiceLifetime.Transient);

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
	scope.ServiceProvider.GetRequiredService<OrganizationContext>().Database.Migrate();
}

app.UseRouting();
app.MapRazorPages();

app.Run();