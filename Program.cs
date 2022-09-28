using BulkyBookWeb.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//we have injected our dbcontext here
//after that we have to run EFC migration and create our database
builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();  //adds HTTPS Redirection Middleware to enforce HTTPS by redirecting all HTTP requests to HTTPS.
app.UseStaticFiles();       //adds Static File Middleware which enables static files to be served.

app.UseRouting();          //    this are all middleware. 

app.UseAuthorization();   // 

app.MapControllerRoute(  
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
