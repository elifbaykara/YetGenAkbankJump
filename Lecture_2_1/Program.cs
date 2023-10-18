using System.Xml;

Console.WriteLine("Reference Type vs Value Type");
int a = 0;
int b = a;
a = 1;
Console.WriteLine(b);
//sonucumuz 0 olur çünkü değer tiplerde stack'in içinde her değişkenin yanında bir kutu olduğunu düşün ve içine değer atandığını düşün.
//Atama yaptığımızda değer tipler arasında, a=0 diye tanımlanmış b=a denmiş. A=0 iken b'nin değeri a'yı gösteriyor.
//Ve a'nın kutucuğunun içindeki değer b'ye kopyalanıyor. Sonrasında a'nın değeri değişse de b'nin değeri değişmiyo çünkü zaten atama işlemi sırasında a'nın o an olan değeri atandı :)
//Değer tiplerin işlemesi bu şekilde oluyor, değeri kopyalamak gibi düşün :)


//Person person1 = new("Zeynep", "Çevik");
//Person person2 = person1;
//person2.Surname = "Genel";
//Console.WriteLine(person1.Surname);
//class Person
//{
//    public Person(string name, string surname)
//    {
//        Name = name;
//        Surname = surname;
//    }

//    public string Name { get; set; }
//    public string Surname { get; set; }
//}

//Burada person1.Surname'in çıktısı Genel olur sebebi de referans tip olması.
//Değer tip ve referans tip burada ayrılıyor, person1.surname bir şeyin referansı gibi düşün.
//Yani önce person1 zeynep çevik yani person 1'in referansı name=zeynep surname=çevik
//sonrasında person2=person1 oluyor yani person1'in referansını aynı zamanda oklarla person2 de gösteriyor.
//Sonrasonda person2.surname = genel oluyor yani person1 ve person2 aynı kutudaki surname referansını gösteriyordu
//Eğer değişirse kutudaki surname referans değeri değişecek,böylece çevik'in üstünü çizip genel yazarız
//Person2 değeri için de person1 değeri için de surname genel olur :)


Person person1 = new(20);
Person person2 = new(25);
person1=person2;
Console.WriteLine(person1.Age);
person1.Age = person2.Age;
person1.Age = 10;
Console.WriteLine(person1.Age);
class Person
{
    public Person(int age)
    {
        Age = age;
    }

    public int Age { get; set; }
}

//Stack ve Heap için karşılaştırmalar
//=> Stack mi daha hızlı çalışır heap mi ? => Stack daha hızlı çalışır, her zaman daha performanslıdır
//=> Const nerede saklanır, neden ? => Const heap'te saklanır sebebi de şudur : Const sabit olarak bir kere tanımlanır.
//Daha sonrasında sürekli olarak ona  ulaşıp o değeri kullanması gerekecektir. Fakat stack'te üst üste gelip bir alta geçtiği için
//kolay bir şekilde ona ulaşamayacaktır. Bu nedenle heap'i tercih eder.
//=> Heap'te değer değişkenler bulunuyor.int,guid,bool,char... bulunuyor.
//Referans değişkenlerde ise string,class,object,interface.
