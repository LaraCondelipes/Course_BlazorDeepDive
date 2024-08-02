using ServerManagement.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//middleware functions:
app.UseHttpsRedirection();

//middleware responsable for mapping static resources
app.UseStaticFiles();

app.UseAntiforgery();

//middleware responsable for mapping requests to Blazor
app.MapRazorComponents<App>();

app.Run();
