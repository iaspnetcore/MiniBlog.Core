var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add custom services to the container.
builder.Services.AddSingleton<IUserServices, BlogUserServices>();
builder.Services.AddSingleton<IBlogService, FileBlogService>();
builder.Services.Configure<BlogSettings>(this.Configuration.GetSection("blog"));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddMetaWeblog<MetaWeblogService>();



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
