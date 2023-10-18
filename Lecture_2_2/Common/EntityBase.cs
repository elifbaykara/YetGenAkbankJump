using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_2.EntityBase
{
    public class EntityBase<TKey> //TKey ? ==> TypeKey yani anahtar tipi, aşağıda yazdığım sorun için kullanılır.
{
        //public Guid Id { get; set; }
        //Burada ufak bir sorun var, biz entityBase classına ıd'yi guid olarak ekledik.
        //Yani veritabanına gidecek tüm idler guid olacak. Biz başka bir gün bir entityde int kullanalım desek ? 
        //Bu yapıyı nasıl bir şeye çevirmeliyim ki EntityBase türetirken ben sana ne veriyorsam onu kullansın.
        //String diyorsam string kullansın, int diyorsam int kullansın.
        public TKey Id { get; set; } //Bu şekilde kullanmam gerek.
        public DateTimeOffset CreatedOn { get; set; } //datetimeoffset c# diline ve mssql'e özeldir !!!!!
    }
}
