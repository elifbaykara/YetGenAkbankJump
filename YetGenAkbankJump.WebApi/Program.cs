using Lecture_4_2.Utilities;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using YetGenAkbankJump.Shared.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<PasswordGenerator>(new PasswordGenerator());  //singleton=> ekledi�im servisin sadece bir kopyas� olabilir birisi ona ihtiya� duyarsa sen ona bu kopyay� d�nd�r.
builder.Services.AddSingleton<RequestCountService>(new RequestCountService()); //uygulaman�n her yerindeki passwordleri almak i�in
 
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyMethod()
            .AllowCredentials()
            .SetIsOriginAllowed((host) => true)
            .AllowAnyHeader());
});

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var trCulture = new CultureInfo("tr-TR");

    List<CultureInfo> cultureInfos = new()
    {
        trCulture,
        new("en-GB"),
        new("ru-RU")
    }; 

    options.SupportedCultures = cultureInfos;
    options.SupportedUICultures = cultureInfos;
    options.DefaultRequestCulture = new RequestCulture(trCulture);
    options.ApplyCurrentCultureToResponseHeaders = true;

});

var app = builder.Build();

app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
