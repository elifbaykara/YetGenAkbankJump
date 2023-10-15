using Lecture_1_2.Common;
using Lecture_1_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lecture_1_2.Entities 
{

    //teacher ve student classları arasında çok fazla ortak özellik var. Tek tek yazmama gerek yok, ortak bir class yazarım ve onlara bu classtan aktarırım yani kalıtım yaparken :) classları birbirine kalıtırım :) 
    public class Teacher : PersonBase   // bu şekilde yazarak personbase classının içindekileri teacher classına kalıttım.
    {

        public DateTimeOffset RegistrationDate { get; set; }

        //public void SayMyName()
        //{
        //    Console.WriteLine($"{FirstName} {LastName}");
        //} BUNU FARKLI BİR ŞEKİLDE YAZACAĞIM ŞİMDİ
        

        //bu şekilde de yazılabilir.
        //public void SayMyName() => Console.WriteLine($"{FirstName} {LastName}"); 
    }
}
