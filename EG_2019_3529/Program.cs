using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using WebApplication3529.Contextclass;
using WebApplication3529.ModelClass;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RajiniAyurvedaContext>(options => options.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=RajiniAyurveda;Trusted_Connection=True;"));
builder.Services.AddScoped<Customer>();
builder.Services.AddDbContext<RajiniAyurvedaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RajiniAyurvedaContext")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
