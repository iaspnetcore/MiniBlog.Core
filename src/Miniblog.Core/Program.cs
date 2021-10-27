var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add custom services to the container.
builder.Services.AddSingleton<IUserServices, BlogUserServices>();
builder.Services.AddSingleton<IBlogService, FileBlogService>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddMetaWeblog<MetaWeblogService>();

//Add  Configure
//https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/fundamentals/configuration/index/samples/6.x/ConfigSample/Program.cs
builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.Configure<BlogSettings>(
    builder.Configuration.GetSection("blog"));

var app = builder.Build();

// Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
