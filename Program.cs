using SocialMediaLinks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<SocialMediaLinksOptions>(builder.Configuration.GetSection("SocialMediaLinks"));
var app = builder.Build();
app.UseRouting();
app.UseStaticFiles();
app.MapControllers();
app.Run();
