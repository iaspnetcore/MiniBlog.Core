var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//https://www.iaspnetcore.com/blogpost-618aaa94635c733c81e1486d-aspnet-core-6x-w3clogger
builder.Services.AddW3CLogging(logging =>
{
    // Log all W3C fields
    logging.LoggingFields = W3CLoggingFields.All;

    ////logging.FileSizeLimit = 5 * 1024 * 1024;
    ////logging.RetainedFileCountLimit = 2;
    ////logging.FileName = "MyLogFile";
    ////logging.LogDirectory = @"C:\logs";
    //logging.FlushInterval = TimeSpan.FromSeconds(2);
});

// Add custom services to the container.
builder.Services.AddSingleton<IUserServices, BlogUserServices>();
builder.Services.AddSingleton<IBlogService, FileBlogService>();
#region 配置数据保护，Preventing Cross-Site Request Forgery (XSRF/CSRF) Attacks in ASP.NET Core
//https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/configuration/overview?view=aspnetcore-3.1

var keysFolder = "";

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    keysFolder = "C:\\artifacts";
else
    keysFolder = "/var/artifacts";

builder.Services.AddDataProtection()
        .PersistKeysToFileSystem(new DirectoryInfo(keysFolder)); //把加密信息保存大文件夹

#endregion

builder.Services.AddControllersWithViews();

//.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddHttpContextAccessor();




builder.Services.AddSingleton<IUserServices, BlogUserServices>();
builder.Services.AddSingleton<IBlogService, FileBlogService>();

//Add  Configure Options https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/fundamentals/configuration/index/samples/6.x/ConfigSample/Program.cs
builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.Configure<BlogSettings>(
    builder.Configuration.GetSection("blog"));

//builder.Services.AddProxies();




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

builder.Services
     .AddWebMarkupMin(options =>
     {
         options.AllowMinificationInDevelopmentEnvironment = true;
         options.AllowCompressionInDevelopmentEnvironment = true;
                     // options.DisableMinification = !EngineContext.Current.Resolve<CommonSettings>().EnableHtmlMinification;
                     options.DisableCompression = true;
         options.DisablePoweredByHttpHeaders = true;
     })
     .AddHtmlMinification(options =>
     {
         options.CssMinifierFactory = new NUglifyCssMinifierFactory();
         options.JsMinifierFactory = new NUglifyJsMinifierFactory();
     })
     .AddXmlMinification(options =>
     {
         var settings = options.MinificationSettings;
         settings.RenderEmptyTagsWithSpace = true;
         settings.CollapseTagsWithoutContent = true;
     });




var app = builder.Build();

// Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}



app.UseStaticFiles();

app.UseWebMarkupMin();

app.UseRouting();

app.UseW3CLogging();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
