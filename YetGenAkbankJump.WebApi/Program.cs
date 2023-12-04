using Lecture_4_2.Utilities;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using YetGenAkbankJump.Persistence.Contexts;
using YetGenAkbankJump.Shared.Services;
using YetGenAkbankJump.Shared.Utilities;
using YetGenAkbankJump.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<PasswordGenerator>();  //singleton=> eklediðim servisin sadece bir kopyasý olabilir birisi ona ihtiyaç duyarsa sen ona bu kopyayý döndür.

builder.Services.AddSingleton<RequestCountService>(new RequestCountService()); //uygulamanýn her yerindeki passwordleri almak için

var textPath = builder.Configuration.GetSection("TextPath").Value;

builder.Services.AddSingleton<IIPService, IPService>();

builder.Services.AddSingleton<ITextService, TextService>(x => new TextService(textPath));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyMethod()
            .AllowCredentials()
            .SetIsOriginAllowed((host) => true)
            .AllowAnyHeader());
});

var connectionString = builder.Configuration.GetSection("YetGenPostgreSQLDB").Value;

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));

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
