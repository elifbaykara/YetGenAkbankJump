//Linq Methods

using System.Globalization;
using System.Runtime.ExceptionServices;
using Week4.Entities;
using Week4.Enums;

List<int> numbers = new() { 100, 150, 160, 45};

bool allItemsGreater = numbers.All(number => number > 40); //number yerine bu ifadelerin içinde x kullanmak daha sağlıklı

//bool allItemsGreater = true;

//foreach(int number in numbers)
//{
//    if (number <= 40)
//    {
//        allItemsGreater = false;
//        break;
//    }


//}
//şimdi ise bunu All metoduyla yapacağız

Console.WriteLine(allItemsGreater);

//şimdi de any metodunu inceliyoruz. Any metodu da All metodu gibi boolean bir geri dönüş tipine sahip. Aralarında te bir fark var : 
//All'da şartı karşılamayan tek bir varsa bile direkt false dönüyor. Any'de öyle değil. Şartı karşılayan tek bir şey varsa bile direkt true dönüyor :)
//Yani All'da true dönmesi için tüm şartların sağlanması gerek,  any'de bir tanesi bile sağlarsa okey :)

List<User> userList = new List<User>
{
    new User("TravelExplorer_", 100),
    new User("FoodieAdventures", 1000000),
    new User("FitnessFreak101", 170),
    new User("ArtisticSoul_", 300),
    new User("FashionInstaStyle", 1800),
};

Console.WriteLine(userList.Any(x => x.FollowerCount >=1000 && x.Username.Contains("Style"))); //true dönecek çünkü hepsi olmasa da 2 tanesi bu şartı sağlıyor :)

List<Person> people = new List<Person>
{
    new Person {FirstName = "Alice", LastName="Smith", Age=30, Gender=Gender.Female},
    new Person {FirstName = "Bob", LastName="Johnson", Age=25, Gender=Gender.Male},
    new Person {FirstName = "Charlie", LastName="Brown", Age=40, Gender=Gender.Male},
    new Person {FirstName = "David", LastName="Wilson", Age=28, Gender=Gender.Male},
    new Person {FirstName = "Emma", LastName="Lee", Age=35, Gender=Gender.Female},
    new Person {FirstName = "Frank", LastName="Davis", Age=45, Gender=Gender.Male},
    new Person {FirstName = "Grace", LastName="Taylor", Age=22, Gender=Gender.Female},
    new Person {FirstName = "Hannah", LastName="White", Age=32, Gender=Gender.Female},
    new Person {FirstName = "Isaac", LastName="Clark", Age=27, Gender=Gender.Male},
    new Person {FirstName = "Jack", LastName="Hall", Age=38, Gender=Gender.Male},
};

List<Person> filterResult = people.Where(x => x.Age<30).ToList();

foreach (Person person in filterResult)
{
    Console.WriteLine(person.FirstName);
}

//first-firstordefault metotlar

// var book = books.First(); //ilk elemanı getirir. where ile de yazabilirim
// var book = books.Where(x=> x.Genre == Genre.Romance).First(); //böylece türü romance olan ilk kitabı getirir. Ama diyelim ki öyle bir kitap yok ? 
// var book = books.Where(x=> x.Genre == Genre.Romance).FirstOrDefault(); böylece direkt null döndürür -Eğer öyle bir eleman yoksa !!!!!!!!!!!!!!!-

//single ve first arasındaki fark ? single metotları sona tek bir eleman kalmış olmasını istiyor. Yani eğer tek eleman kalmışsa değer döndürür !
//singleordefault'un single'dan tek farkı eleman yoksa hata vermemesi !!! ortak noktaları ise birden fazla eleman varsa ikisi de hata verir :)

List<int> grades = new List<int>() { 78, 92, 100, 37, 81 };
//Console.WriteLine(Enumerable.Average(grades));
Console.WriteLine(grades.Average());