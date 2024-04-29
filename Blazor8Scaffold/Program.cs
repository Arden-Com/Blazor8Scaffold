using Blazor8Scaffold.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Blazor8Scaffold.Data;
using Microsoft.AspNetCore.Identity;

namespace Blazor8Scaffold
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Blazor8DbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Blazor8DbContext") ?? throw new InvalidOperationException("Connection string 'Blazor8DbContext' not found.")));

            builder.Services.AddQuickGridEntityFrameworkAdapter();;

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
