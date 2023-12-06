using Lecture_4_1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.Domain.Entities;

namespace YetGenAkbankJump.Domain.Identity
{
    public class UserSetting: Entities.EntityBase<Guid>
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Int16 TimeZone {  get; set; }
        public string LanguageCode { get; set; }
    }
}
