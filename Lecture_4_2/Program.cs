using Lecture_4_2.Utilities;

var passwordGenerator = new PasswordGenerator();

Console.WriteLine("Lütfen şifreniz için istediğiniz karakter sayısını giriniz.");

var passwordLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Şifreniz sayıları içersin mi ? ");
var includeNumbers = Console.ReadLine()=="evet";

Console.WriteLine("Şifreniz küçük harfler içersin mi ? ");
var includeLowerCase = Console.ReadLine() == "evet";

Console.WriteLine("Şifreniz büyük harfler içersin mi ? ");
var includeUpperCase = Console.ReadLine() == "evet";

Console.WriteLine("Şifreniz özel karakterler içersin mi ? ");
var includeSpecialChars = Console.ReadLine() == "evet";

var password = passwordGenerator.Generate(passwordLength,includeNumbers,includeLowerCase,includeUpperCase,includeSpecialChars);

Console.WriteLine($"Şifreniz:{password}");
Console.ReadLine();
return 1;
