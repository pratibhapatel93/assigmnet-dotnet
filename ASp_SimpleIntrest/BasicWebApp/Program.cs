using BasicWebApp.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IInterest, SimpleInterest>();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
