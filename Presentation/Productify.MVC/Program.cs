//MVC PROJESÝNÝN ÇALIÞMA MANTIÐI ==> localhost:port/controllerÝsmi/actionÝsmi ==>localhost:4200/product/getall



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=GetAll}/{id?}");

app.Run();    //burada aslýnda route mapleniyor  controller = home yazýyor action olarak da ýndex 
