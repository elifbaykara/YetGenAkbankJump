//bir class bir interface ı implemente ettiyse o sınıfın oluşturulmuş olan instance ı implemente etmiş olduğu interface ın değişkeni tarafından referans gösterilebilir

using System;
using Week3.Entities;
using Week3.Services;

Console.WriteLine("Product Shipping! ");

Product product1 = new ("Product 1", 2.5m, 19.99m);
Product product2 = new ("Product 2", 1.8m, 14.99m);
Product product3 = new ("Product 3", 3.2m, 24.99m);
Product product4 = new ("Product 4", 1.0m, 9.99m);
Product product5 = new ("Product 5", 2.7m, 17.99m);

ShippingService shippingService1 = new();

Console.WriteLine(shippingService1.CalculateTax(product1, "Türkiye"));
Console.WriteLine(shippingService1.CalculateTax(product1, "Spain"));  //fakat şu an open closed principle prensibine uymuyoruz.
//OPEN CLOSED PRINCIPLE ==> Yeni özellikler eklerken (gelişime açık olmak) önceden yazdığımız kodları revize etmeye ihtiyaç duymuyor olmamız gerekiyor (değişime kapalı olmak)

string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Database\\CountryInfos.txt";

NotepadService notepadService = new();
string[] lines = notepadService.ReadFromNotepad(path).Split("\r\n");

List<CountryInformation> countryInformationList = new();

foreach(var line in lines)
{
    CountryInformation countryInformations = new(line);
}

Console.WriteLine();