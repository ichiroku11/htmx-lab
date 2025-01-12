var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddRazorPages();

services.Configure<RouteOptions>(options => {
	options.LowercaseQueryStrings = true;
	options.LowercaseUrls = true;
});

var app = builder.Build();

app.MapRazorPages();

app.Run();
