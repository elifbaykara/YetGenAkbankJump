// OOP dilden bağımsız bir yaklaşımdır. Kodun okunabilirliğini sağlamak,
// kodun yeniden kullanılabilir olmadı ve bakım maliyetlerinin düşük olması nedeniyle kullanılır

//Instance ve property kavramları ==> Diyelim ki öğrenci verilerimizin olduğu bir tablo var. Id, name,surname gibi..
//Her bir satır instance olarak adlandırılır. Diyelim ki tablo 120160 id numaralı name elif surname baykara olan biri var. İşte bu satır bir instance örneği oluşturur.
//Peki property nedir ?

using System.Net.WebSockets;
using Week1.Entities;
using Week1.Entities.ComputerComponents;
using Week1.Enums;

//Student student = new Student()  //yeni bir student nesnesi oluşturdum şimdi buna student classındaki özellikleri atacağım
//{
//    Id = 120160,
//    Name = "Elif",
//    Surname = "Baykara",
//};

//Console.WriteLine($"Id: {student.Id}- Name: {student.Name}- Surname: {student.Surname}");
// --------------------BUNUN YERİNE, CTOR YAZDIKTAN SONRA ŞU ŞEKİLDE OLUŞTURACAĞIM---------------
Student student1 = new Student(120160, "Elif", "Baykara"); //öğrencimi oluşturmuş oldum :)
Console.WriteLine($"{student1.Id}, {student1.Name}, {student1.Surname}");


Storage storage1 = new Storage("WD Blue", 1, CapacitySizeType.TB);
RAM memory1 = new RAM("Corsair", 16, CapacitySizeType.GB);
RAM memory2 = new RAM("Corsair", 8, CapacitySizeType.GB);
CPU Cpu1 = new CPU("intel", "i7", 2.4, CapacitySizeType.GHz, 16, CapacitySizeType.GB);

Computer computer1 = new Computer("Apple", "MacBook", Cpu1, memory1, storage1);
//iki tane computer instance var tek farkları depolama alanları ama ben bunları bu şekilde  string değerken karşılaştıramam. Ne yapmam gerek ? StorageSize ekleyeceğim.
Console.WriteLine($"Marka: {computer1.Brand} Model: {computer1.Model}\n CPU: {computer1.CPU}");