using Lecture_2_2.EntityBase;
using Lecture_2_2.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_2.Entities
{
    public class AccessControlLog:EntityBase<Guid> //Burada entitybase'den kalıtım aldık fakat TKey kullandığımız için entity base tanımlarken de tkey yerine <dönüş_tipi> yazmalıyız !!!!!!!!!!
    {
        public long PersonId { get; set; } //normalde userId olarak geçer, long intten daha çok yer kaplar. Convert.ToInt64 !!!!!! 32 değil !!!!!!!!,
        
        public string DeviceSerialNo { get; set; }
        public AccessType AccessType { get; set; }
        public DateTime LogTime { get; set; }
        
        public static AccessType ConvertStringToAccessType(string accessType)
        {
            switch (accessType)
            {
                case "FP":
                    return AccessType.FingerPrint;
                case "FACE":
                    return AccessType.Face;
                case "CARD":
                    return AccessType.Card;
                default:
                    throw new Exception("ciyuaydi");
            }
        }

    }
}
