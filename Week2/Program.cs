//Propertylerimizin değerlerinin bizim izin verdiğimiz ölçüde değişmesini istiyorsak encapsulation kullanabiliriz.
using Week2.Entities;
using Week2.Services;

//Account account1 = new("Elif", "Baykara");
//account1.WithDraw(2000);
//account1.WithDraw(200);
//Console.WriteLine($"{account1.Balance}");

//Playlist playlist1 = new("Karagümrük yanıyor");
//playlist1.AddSong("Neye Yarar");
//playlist1.AddSong(""); //ama white space ya da empty olabilir, ne yapmam gerek ? Kontrol etmeliyim. AddSong fonksiyonu ekleyeyim.

//Console.WriteLine();

string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
Console.WriteLine();

//var song1 = new Song("Requiem K.626", "W. A. Mozart", "Orchestre national de France", null);
//var song2 = new Song("Sonata No.6 in F Major", "L. Beethoven", "Fazıl Say", " Warner Music");
//var song3 = new Song("Moonlight Sonata", "Ludwig van Beethoven", "Various Artists", "Classical Records");

//var playlist1 = new Playlist(song1);
//playlist1.AddSong(song2);
//playlist1.AddSong(song3);

//playlist1.ShuffleSong();

//Console.WriteLine(playlist1.GetSongs());

//NotepadService notepadService = new NotepadService();
//notepadService.WriteToNotepad(playlist1.GetSongs());


Meeting meeting1 = new Meeting()
{
    Title = "Yetgen Akbank Jump Tanışma Toplantısı",
    Details = "Katılımcıların alım süreçleri konuşulacak.",
    StartTime = new DateTime(2023, 09, 18, 19, 00, 00),
    EndTime = new DateTime(2023, 09, 18, 20, 00, 00),
    Guests = new() { "elif@deneme.com", "hakan@deneme.com", "alper@deneme.com"},
};

Todo todo1 = new Todo()
{
    Title = "Yetgen Akbank Jump Tanışma Toplantısı",
    Details = "Katılımcıların alım süreçleri konuşulacak.",
    StartTime = new DateTime(2023, 09, 20, 21, 00, 00),
    EndTime = new DateTime(2023, 09, 20, 22, 00, 00),
    Importance = "High Priority",

};
SamsungPrinter samsungPrinter = new SamsungPrinter();
samsungPrinter.PrintPage();

HPPrinter hPPrinter = new HPPrinter();
hPPrinter.PrintPage();

meeting1.GetNotification();
todo1.GetNotification();