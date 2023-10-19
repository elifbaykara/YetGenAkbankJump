//id,created,firstname,lastname,phonenumber  split(",")
//peki neden program akışı içinde değil de ayrıca services klasörü açıp onun içinde yapıyoruz ?
//çünkü ortak bir yerde bir kere yazalım ve defalarca kullanabilelim.
using Lecture_3_1.Entities;
using Lecture_3_1.Services;

// File.WriteAllText("C:\\Users\\elif\\Documents\\GitHub\\YetGenAkbankJump\\Lecture_3_1\\Deneme.txt", "deneme");


Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Surname: ");
string surname = Console.ReadLine();

Console.Write("Phone Number: ");
string phone = Console.ReadLine();


Customer customer1 = new()
{
    Id = Guid.NewGuid(),
    FirstName = name,
    LastName = surname,
    CreatedOn = DateTimeOffset.Now,
    PhoneNumber = phone,
};

NotepadService notepadService = new();
//notepadService.SaveToNotepad(customer1.GetValuesCSV());
