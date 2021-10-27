var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add custom services to the container.
builder.Services.AddSingleton<IUserServices, BlogUserServices>();
builder.Services.AddSingleton<IBlogService, FileBlogService>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddMetaWeblog<MetaWeblogService>();

//Add  Configure Options https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/fundamentals/configuration/index/samples/6.x/ConfigSample/Program.cs
builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.Configure<BlogSettings>(
    builder.Configuration.GetSection("blog"));



// Progressive Web Apps https://github.com/madskristensen/WebEssentials.AspNetCore.ServiceWorker
builder.Services.AddProgressiveWebApp(
    new WebEssentials.AspNetCore.Pwa.PwaOptions
    {
        OfflineRoute = "/shared/offline/"
    });




// Output caching (https://github.com/madskristensen/WebEssentials.AspNetCore.OutputCaching)
builder.Services.AddOutputCaching(
    options =>
    {
        options.Profiles["default"] = new OutputCacheProfile
        {
            Duration = 3600
        };
    });

// Cookie authentication.
builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(
        options =>
        {
            options.LoginPath = "/login/";
            options.LogoutPath = "/logout/";
        });

// HTML minification (https://github.com/Taritsyn/WebMarkupMin)
builder.Services
    .AddWebMarkupMin(
        options =>
        {
            options.AllowMinificationInDevelopmentEnvironment = true;
            options.DisablePoweredByHttpHeaders = true;
        })
    .AddHtmlMinification(
        options =>
        {
            options.MinificationSettings.RemoveOptionalEndTags = false;
            options.MinificationSettings.WhitespaceMinificationMode = WhitespaceMinificationMode.Safe;
        });
builder.Services.AddSingleton<IWmmLogger, WmmNullLogger>(); // Used by HTML minifier

// Bundling, minification and Sass transpilation (https://github.com/ligershark/WebOptimizer)
builder.Services.AddWebOptimizer(
    pipeline =>
    {
        pipeline.MinifyJsFiles();
        pipeline.CompileScssFiles()
                .InlineImages(1);
    });




var app = builder.Build();

// Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseOutputCaching();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
