using LystfiskerPortalen.Components;
using LystfiskerPortalen.Data;
using LystfiskerPortalen.Models;
using LystfiskerPortalen.Persistence;
using Microsoft.EntityFrameworkCore;
using LystfiskerPortalen.Components.Account;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LystFiskerContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentityApiEndpoints<Profile>()
    .AddEntityFrameworkStores<LystFiskerContext>();

builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();
builder.Services.AddGeolocationServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IdentityUserAccessor>();

builder.Services.AddScoped<IdentityRedirectManager>();

builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddIdentityCore<Profile>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<LystFiskerContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints(); ;

app.Run();
