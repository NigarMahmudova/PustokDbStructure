using Microsoft.EntityFrameworkCore;
using PustokProject.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PustokDbContext>(opt =>
{
    opt.UseSqlServer("Server=DESKTOP-VNR360D\\SQLEXPRESS;Database=PustokProject;Integrated Security=true");
});
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.UseStaticFiles();
app.UseRouting();
app.Run();
