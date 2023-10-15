
using Lecture_1_2.Entities;
using Lecture_1_2.Enums;


//Guid studentId = Guid.NewGuid();
//string studentName = "Elif";
//string studentSurname = "Baykara";
//Gender studentGender = Gender.Female;  Her yeni öğrenci oluşturmak istediğimde bu şekilde mi oluşturacağım ? Daha kullanışlı bir yol kullanmam gerek.

var student = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "Elif",
    LastName = "Baykara",
    Gender = Gender.Male,
    No = 1,
    RegistrationDate = DateTimeOffset.Now,
    CreatedOn = DateTimeOffset.Now,
};   // benim şu an 1 öğrencim var. Şimdi ise öğrencilerim için bir liste oluşturacağım.

List<Student> students = new List<Student>();
Console.WriteLine($"Öğrenci Bilgileri : No - {student.No}  - {student.FirstName}  {student.LastName} {student.Gender}");
var teacher = new Teacher();
teacher.FirstName = "Elif";
teacher.LastName = "Baykara";
Console.WriteLine(teacher.FullName);
student.SayMyName();