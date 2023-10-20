using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Entities
{
    public class Student
    {
        public int Id { get; set; } //bunların her birine property denir
        public string Name { get; set; } //property     
        public string Surname { get; set; } //property
        //şimdi buradaki  studenttan çeşitli örnekler yani instances oluşturalım. Bunun için program.cs'e gidiyorum
        //ctrl + . 'ya basınca otomatik olarak ctor oluşuyor. Ctor oluşturunca nasıl bir fark oluyor ? program.cs'te göstereceğim
        public Student(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }



}

