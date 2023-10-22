using Week6.Common;
using Week6.Contexts;
using Week6.Entities;
using Week6.Enums;

Console.WriteLine("Change Tracker");

JobPost jobPost1 = new()
{
    Title = "Junior Dev",
    Company = "FoolTech",
    Description = "Bachelor's degree in CS or relevant areas, min 3 years experience in Net Framework & C# programming language.",
    WorkMode = WorkMode.InOffice,
    CreatedOn = DateTime.UtcNow,
   


};

JobHunterDbContext context = new();

//EntityBase State Example

var state1 = context.Entry(jobPost1).State; //entry metodu içerisine parametre olarak verdiğimiz entity'nin ChangeTracking mekanizması ile ilgili bilgileri almamızı sağlar.

context.JobPosts.Add(jobPost1);

var state2 = context.Entry(jobPost1).State;

context.SaveChanges();

//var state3 = context.Entry(jobPost1).State;

//jobPost1.WorkMode = WorkMode.Hybrid;

//var state4 = context.Entry(jobPost1).State;

//context.SaveChanges();

//var state5 = context.Entry(jobPost1).State;

//context.JobPosts.Remove(jobPost1);

//var state6 = context.Entry(jobPost1).State;

//context.SaveChanges();

//var state7 = context.Entry(jobPost1).State;

//Console.WriteLine();


//JobPost jobPost1 = context.JobPosts.Where(x => x.Id == Guid.Parse("//")).FirstOrDefault();

Console.WriteLine();

//interception ==> program içerisinde oluşturduğumuz entitymiz ef core sayesinde database e gönderiliyor.
//interception yapısı sayesinde entitymiz veritabanıan gönderilmeden önce çeşitli manipülasyonlar yapabiliriz, propertylerimizi değiştirebiliriz
//yani aslında bize merkezi bir değiştirme noktası sunuyor :)